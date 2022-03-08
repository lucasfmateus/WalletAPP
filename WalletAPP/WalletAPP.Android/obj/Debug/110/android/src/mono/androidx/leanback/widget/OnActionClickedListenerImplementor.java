package mono.androidx.leanback.widget;


public class OnActionClickedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		androidx.leanback.widget.OnActionClickedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onActionClicked:(Landroidx/leanback/widget/Action;)V:GetOnActionClicked_Landroidx_leanback_widget_Action_Handler:AndroidX.Leanback.Widget.IOnActionClickedListenerInvoker, Xamarin.AndroidX.Leanback\n" +
			"";
		mono.android.Runtime.register ("AndroidX.Leanback.Widget.IOnActionClickedListenerImplementor, Xamarin.AndroidX.Leanback", OnActionClickedListenerImplementor.class, __md_methods);
	}


	public OnActionClickedListenerImplementor ()
	{
		super ();
		if (getClass () == OnActionClickedListenerImplementor.class)
			mono.android.TypeManager.Activate ("AndroidX.Leanback.Widget.IOnActionClickedListenerImplementor, Xamarin.AndroidX.Leanback", "", this, new java.lang.Object[] {  });
	}


	public void onActionClicked (androidx.leanback.widget.Action p0)
	{
		n_onActionClicked (p0);
	}

	private native void n_onActionClicked (androidx.leanback.widget.Action p0);

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
