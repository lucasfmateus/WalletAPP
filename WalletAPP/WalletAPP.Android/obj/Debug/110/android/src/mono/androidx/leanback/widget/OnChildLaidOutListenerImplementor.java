package mono.androidx.leanback.widget;


public class OnChildLaidOutListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		androidx.leanback.widget.OnChildLaidOutListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onChildLaidOut:(Landroid/view/ViewGroup;Landroid/view/View;IJ)V:GetOnChildLaidOut_Landroid_view_ViewGroup_Landroid_view_View_IJHandler:AndroidX.Leanback.Widget.IOnChildLaidOutListenerInvoker, Xamarin.AndroidX.Leanback\n" +
			"";
		mono.android.Runtime.register ("AndroidX.Leanback.Widget.IOnChildLaidOutListenerImplementor, Xamarin.AndroidX.Leanback", OnChildLaidOutListenerImplementor.class, __md_methods);
	}


	public OnChildLaidOutListenerImplementor ()
	{
		super ();
		if (getClass () == OnChildLaidOutListenerImplementor.class)
			mono.android.TypeManager.Activate ("AndroidX.Leanback.Widget.IOnChildLaidOutListenerImplementor, Xamarin.AndroidX.Leanback", "", this, new java.lang.Object[] {  });
	}


	public void onChildLaidOut (android.view.ViewGroup p0, android.view.View p1, int p2, long p3)
	{
		n_onChildLaidOut (p0, p1, p2, p3);
	}

	private native void n_onChildLaidOut (android.view.ViewGroup p0, android.view.View p1, int p2, long p3);

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
