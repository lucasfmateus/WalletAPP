package mono.androidx.leanback.widget;


public class BrowseFrameLayout_OnChildFocusListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		androidx.leanback.widget.BrowseFrameLayout.OnChildFocusListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onRequestChildFocus:(Landroid/view/View;Landroid/view/View;)V:GetOnRequestChildFocus_Landroid_view_View_Landroid_view_View_Handler:AndroidX.Leanback.Widget.BrowseFrameLayout/IOnChildFocusListenerInvoker, Xamarin.AndroidX.Leanback\n" +
			"n_onRequestFocusInDescendants:(ILandroid/graphics/Rect;)Z:GetOnRequestFocusInDescendants_ILandroid_graphics_Rect_Handler:AndroidX.Leanback.Widget.BrowseFrameLayout/IOnChildFocusListenerInvoker, Xamarin.AndroidX.Leanback\n" +
			"";
		mono.android.Runtime.register ("AndroidX.Leanback.Widget.BrowseFrameLayout+IOnChildFocusListenerImplementor, Xamarin.AndroidX.Leanback", BrowseFrameLayout_OnChildFocusListenerImplementor.class, __md_methods);
	}


	public BrowseFrameLayout_OnChildFocusListenerImplementor ()
	{
		super ();
		if (getClass () == BrowseFrameLayout_OnChildFocusListenerImplementor.class)
			mono.android.TypeManager.Activate ("AndroidX.Leanback.Widget.BrowseFrameLayout+IOnChildFocusListenerImplementor, Xamarin.AndroidX.Leanback", "", this, new java.lang.Object[] {  });
	}


	public void onRequestChildFocus (android.view.View p0, android.view.View p1)
	{
		n_onRequestChildFocus (p0, p1);
	}

	private native void n_onRequestChildFocus (android.view.View p0, android.view.View p1);


	public boolean onRequestFocusInDescendants (int p0, android.graphics.Rect p1)
	{
		return n_onRequestFocusInDescendants (p0, p1);
	}

	private native boolean n_onRequestFocusInDescendants (int p0, android.graphics.Rect p1);

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
