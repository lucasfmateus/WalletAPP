package mono.androidx.leanback.widget;


public class ImeKeyMonitor_ImeKeyListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		androidx.leanback.widget.ImeKeyMonitor.ImeKeyListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onKeyPreIme:(Landroid/widget/EditText;ILandroid/view/KeyEvent;)Z:GetOnKeyPreIme_Landroid_widget_EditText_ILandroid_view_KeyEvent_Handler:AndroidX.Leanback.Widget.IImeKeyMonitorImeKeyListenerInvoker, Xamarin.AndroidX.Leanback\n" +
			"";
		mono.android.Runtime.register ("AndroidX.Leanback.Widget.IImeKeyMonitorImeKeyListenerImplementor, Xamarin.AndroidX.Leanback", ImeKeyMonitor_ImeKeyListenerImplementor.class, __md_methods);
	}


	public ImeKeyMonitor_ImeKeyListenerImplementor ()
	{
		super ();
		if (getClass () == ImeKeyMonitor_ImeKeyListenerImplementor.class)
			mono.android.TypeManager.Activate ("AndroidX.Leanback.Widget.IImeKeyMonitorImeKeyListenerImplementor, Xamarin.AndroidX.Leanback", "", this, new java.lang.Object[] {  });
	}


	public boolean onKeyPreIme (android.widget.EditText p0, int p1, android.view.KeyEvent p2)
	{
		return n_onKeyPreIme (p0, p1, p2);
	}

	private native boolean n_onKeyPreIme (android.widget.EditText p0, int p1, android.view.KeyEvent p2);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
