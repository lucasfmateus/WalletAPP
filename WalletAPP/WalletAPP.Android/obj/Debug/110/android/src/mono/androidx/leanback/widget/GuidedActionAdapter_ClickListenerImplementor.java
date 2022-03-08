package mono.androidx.leanback.widget;


public class GuidedActionAdapter_ClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		androidx.leanback.widget.GuidedActionAdapter.ClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onGuidedActionClicked:(Landroidx/leanback/widget/GuidedAction;)V:GetOnGuidedActionClicked_Landroidx_leanback_widget_GuidedAction_Handler:AndroidX.Leanback.Widget.GuidedActionAdapter/IClickListenerInvoker, Xamarin.AndroidX.Leanback\n" +
			"";
		mono.android.Runtime.register ("AndroidX.Leanback.Widget.GuidedActionAdapter+IClickListenerImplementor, Xamarin.AndroidX.Leanback", GuidedActionAdapter_ClickListenerImplementor.class, __md_methods);
	}


	public GuidedActionAdapter_ClickListenerImplementor ()
	{
		super ();
		if (getClass () == GuidedActionAdapter_ClickListenerImplementor.class)
			mono.android.TypeManager.Activate ("AndroidX.Leanback.Widget.GuidedActionAdapter+IClickListenerImplementor, Xamarin.AndroidX.Leanback", "", this, new java.lang.Object[] {  });
	}


	public void onGuidedActionClicked (androidx.leanback.widget.GuidedAction p0)
	{
		n_onGuidedActionClicked (p0);
	}

	private native void n_onGuidedActionClicked (androidx.leanback.widget.GuidedAction p0);

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
