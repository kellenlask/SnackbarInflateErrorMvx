# SnackbarInflateErrorMvx
Demonstration project for Mvx snackbar inflation error when using compat library. 

Project simply inflates snackbars infintely with a count. 

###Stack Trace:
java.lang.ClassCastException: android.support.v7.widget.AppCompatTextView cannot be cast to android.widget.Button
	at android.support.design.widget.Snackbar$SnackbarLayout.onFinishInflate(Snackbar.java:696)
	at android.view.LayoutInflater.rInflate(LayoutInflater.java:826)
	at android.view.LayoutInflater.inflate(LayoutInflater.java:511)
	at android.view.LayoutInflater.inflate(LayoutInflater.java:415)
	at md5bf0126c95bf9fc0db24c02c9adb4cfa7.MvxLayoutInflater.n_inflate(Native Method)
	at md5bf0126c95bf9fc0db24c02c9adb4cfa7.MvxLayoutInflater.inflate(MvxLayoutInflater.java:50)
	at android.support.design.widget.Snackbar.<init>(Snackbar.java:188)
	at android.support.design.widget.Snackbar.make(Snackbar.java:215)
	at mono.java.lang.RunnableImplementor.n_run(Native Method)
	at mono.java.lang.RunnableImplementor.run(RunnableImplementor.java:30)
	at android.os.Handler.handleCallback(Handler.java:739)
	at android.os.Handler.dispatchMessage(Handler.java:95)
	at android.os.Looper.loop(Looper.java:145)
	at android.app.ActivityThread.main(ActivityThread.java:6837)
	at java.lang.reflect.Method.invoke(Native Method)
	at java.lang.reflect.Method.invoke(Method.java:372)
	at com.android.internal.os.ZygoteInit$MethodAndArgsCaller.run(ZygoteInit.java:1404)
	at com.android.internal.os.ZygoteInit.main(ZygoteInit.java:1199)
Xamarin caused by: Java.Lang.ClassCastException: android.support.v7.widget.AppCompatTextView cannot be cast to android.widget.Button
  at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw () <0x7f9881b4b8 + 0x00028> in <filename unknown>:0 
  at Java.Interop.JniEnvironment+InstanceMethods.CallNonvirtualObjectMethod (JniObjectReference instance, JniObjectReference type, Java.Interop.JniMethodInfo method, Java.Interop.JniArgumentValue* args) <0x7fac020088 + 0x000c7> in <filename unknown>:0 
  at Java.Interop.JniPeerMembers+JniInstanceMethods.InvokeVirtualObjectMethod (System.String encodedMember, IJavaPeerable self, Java.Interop.JniArgumentValue* parameters) <0x7fac01fe48 + 0x00193> in <filename unknown>:0 
  at Android.Views.LayoutInflater.Inflate (Int32 resource, Android.Views.ViewGroup root, Boolean attachToRoot) <0x7f980f5718 + 0x001a3> in <filename unknown>:0 
  at MvvmCross.Binding.Droid.Views.MvxLayoutInflater.Inflate (Int32 resource, Android.Views.ViewGroup root, Boolean attachToRoot) <0x7f980f2190 + 0x000eb> in <filename unknown>:0 
  at Android.Views.LayoutInflater.n_Inflate_ILandroid_view_ViewGroup_Z (IntPtr jnienv, IntPtr native__this, Int32 resource, IntPtr native_root, Boolean attachToRoot) <0x7f9889d158 + 0x00073> in <filename unknown>:0 
  at (wrapper dynamic-method) System.Object:c804c682-4d9a-444b-91a8-6b63a8491f3d (intptr,intptr,int,intptr,bool)
