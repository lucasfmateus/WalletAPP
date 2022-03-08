package mono.androidx.leanback.widget;


public class GuidedActionAdapter_EditListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		androidx.leanback.widget.GuidedActionAdapter.EditListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onGuidedActionEditCanceled:(Landroidx/leanback/widget/GuidedAction;)V:GetOnGuidedActionEditCanceled_Landroidx_leanback_widget_GuidedAction_Handler:AndroidX.Leanback.Widget.GuidedActionAdapter/IEditListenerInvoker, Xamarin.AndroidX.Leanback\n" +
			"n_onGuidedActionEditedAndProceed:(Landroidx/leanback/widget/GuidedAction;)J:GetOnGuidedActionEditedAndProceed_Landroidx_leanback_widget_GuidedAction_Handler:AndroidX.Leanback.Widget.GuidedActionAdapter/IEditListenerInvoker, Xamarin.AndroidX.Leanback\n" +
			"n_onImeClose:()V:GetOnImeCloseHandler:AndroidX.Leanback.Widget.GuidedActionAdapter/IEditListenerInvoker, Xamarin.AndroidX.Leanback\n" +
			"n_onImeOpen:()V:GetOnImeOpenHandler:AndroidX.Leanback.Widget.GuidedActionAdapter/IEditListenerInvoker, Xamarin.AndroidX.Leanback\n" +
			"";
		mono.android.Runtime.register ("AndroidX.Leanback.Widget.GuidedActionAdapter+IEditListenerImplementor, Xamarin.AndroidX.Leanback", GuidedActionAdapter_EditListenerImplementor.class, __md_methods);
	}


	public GuidedActionAdapter_EditListenerImplementor ()
	{
		super ();
		if (getClass () == GuidedActionAdapter_EditListenerImplementor.class)
			mono.android.TypeManager.Activate ("AndroidX.Leanback.Widget.GuidedActionAdapter+IEditListenerImplementor, Xamarin.AndroidX.Leanback", "", this, new java.lang.Object[] {  });
	}


	public void onGuidedActionEditCanceled (androidx.leanback.widget.GuidedAction p0)
	{
		n_onGuidedActionEditCanceled (p0);
	}

	private native void n_onGuidedActionEditCanceled (androidx.leanback.widget.GuidedAction p0);


	public long onGuidedActionEditedAndProceed (androidx.leanback.widget.GuidedAction p0)
	{
		return n_onGuidedActionEditedAndProceed (p0);
	}

	private native long n_onGuidedActionEditedAndProceed (androidx.leanback.widget.GuidedAction p0);


	public void onImeClose ()
	{
		n_onImeClose ();
	}

	private native void n_onImeClose ();


	public void onImeOpen ()
	{
		n_onImeOpen ();
	}

	private native void n_onImeOpen ();

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
