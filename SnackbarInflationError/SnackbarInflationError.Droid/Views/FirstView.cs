using System;
using Android.App;
using Android.OS;
using Android.Support.Design.Widget;

namespace SnackbarInflationError.Droid.Views
{
    [Activity(Label = "View for FirstViewModel")]
    public class FirstView : BaseView
    {
        protected override int LayoutResource => Resource.Layout.FirstView;

        private CoordinatorLayout _coordinator;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SupportActionBar.SetDisplayHomeAsUpEnabled(false);

            _coordinator = FindViewById<CoordinatorLayout>(Resource.Id.snackbarLayout);

            var snackbar = Snackbar.Make(_coordinator, "Iteration: 0", Snackbar.LengthShort);
            snackbar.SetCallback(new SnackbarCallback(_coordinator));
            snackbar.SetAction("Button", view => { });
            snackbar.Show();

        }

    }

    internal class SnackbarCallback : Snackbar.Callback
    {
        private readonly CoordinatorLayout _coordinator;
        private int _count = 1;


        public SnackbarCallback(CoordinatorLayout coordinator)
        {
            _coordinator = coordinator;
        }


        public override void OnDismissed(Snackbar snackbar, int evt)
        {
            var newSnackbar = Snackbar.Make(_coordinator, $"Iteration: {_count}", Snackbar.LengthShort);
            newSnackbar.SetCallback(this);
            newSnackbar.SetAction("Button", view => { });
            newSnackbar.Show();

            _count++;
        }
    }


}
