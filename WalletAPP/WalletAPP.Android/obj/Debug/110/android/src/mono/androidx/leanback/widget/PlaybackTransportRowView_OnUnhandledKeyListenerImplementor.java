package mono.androidx.leanback.widget;


public class PlaybackTransportRowView_OnUnhandledKeyListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		androidx.leanback.widget.PlaybackTransportRowView.OnUnhandledKeyListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onUnhandledKey:(Landroid/view/KeyEvent;)Z:GetOnUnhandledKey_Landroid_view_KeyEvent_Handler:AndroidX.Leanback.Widget.PlaybackTransportRowView/IOnUnhandledKeyListenerInvoker, Xamarin.AndroidX.Leanback\n" +
			"";
		mono.android.Runtime.register ("AndroidX.Leanback.Widget.PlaybackTransportRowView+IOnUnhandledKeyListenerImplementor, Xamarin.AndroidX.Leanback", PlaybackTransportRowView_OnUnhandledKeyListenerImplementor.class, __md_methods);
	}


	public PlaybackTransportRowView_OnUnhandledKeyListenerImplementor ()
	{
		super ();
		if (getClass () == PlaybackTransportRowView_OnUnhandledKeyListenerImplementor.class)
			mono.android.TypeManager.Activate ("AndroidX.Leanback.Widget.PlaybackTransportRowView+IOnUnhandledKeyListenerImplementor, Xamarin.AndroidX.Leanback", "", this, new java.lang.Object[] {  });
	}


	public boolean onUnhandledKey (android.view.KeyEvent p0)
	{
		return n_onUnhandledKey (p0);
	}

	private native boolean n_onUnhandledKey (android.view.KeyEvent p0);

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
