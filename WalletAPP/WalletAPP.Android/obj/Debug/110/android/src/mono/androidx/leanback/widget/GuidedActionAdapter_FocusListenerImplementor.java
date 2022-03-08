package mono.androidx.leanback.widget;


public class GuidedActionAdapter_FocusListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		androidx.leanback.widget.GuidedActionAdapter.FocusListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onGuidedActionFocused:(Landroidx/leanback/widget/GuidedAction;)V:GetOnGuidedActionFocused_Landroidx_leanback_widget_GuidedAction_Handler:AndroidX.Leanback.Widget.GuidedActionAdapter/IFocusListenerInvoker, Xamarin.AndroidX.Leanback\n" +
			"";
		mono.android.Runtime.register ("AndroidX.Leanback.Widget.GuidedActionAdapter+IFocusListenerImplementor, Xamarin.AndroidX.Leanback", GuidedActionAdapter_FocusListenerImplementor.class, __md_methods);
	}


	public GuidedActionAdapter_FocusListenerImplementor ()
	{
		super ();
		if (getClass () == GuidedActionAdapter_FocusListenerImplementor.class)
			mono.android.TypeManager.Activate ("AndroidX.Leanback.Widget.GuidedActionAdapter+IFocusListenerImplementor, Xamarin.AndroidX.Leanback", "", this, new java.lang.Object[] {  });
	}


	public void onGuidedActionFocused (androidx.leanback.widget.GuidedAction p0)
	{
		n_onGuidedActionFocused (p0);
	}

	private native void n_onGuidedActionFocused (androidx.leanback.widget.GuidedAction p0);

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
