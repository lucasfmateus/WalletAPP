package mono.androidx.leanback.widget;


public class SearchBar_SearchBarPermissionListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		androidx.leanback.widget.SearchBar.SearchBarPermissionListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_requestAudioPermission:()V:GetRequestAudioPermissionHandler:AndroidX.Leanback.Widget.SearchBar/ISearchBarPermissionListenerInvoker, Xamarin.AndroidX.Leanback\n" +
			"";
		mono.android.Runtime.register ("AndroidX.Leanback.Widget.SearchBar+ISearchBarPermissionListenerImplementor, Xamarin.AndroidX.Leanback", SearchBar_SearchBarPermissionListenerImplementor.class, __md_methods);
	}


	public SearchBar_SearchBarPermissionListenerImplementor ()
	{
		super ();
		if (getClass () == SearchBar_SearchBarPermissionListenerImplementor.class)
			mono.android.TypeManager.Activate ("AndroidX.Leanback.Widget.SearchBar+ISearchBarPermissionListenerImplementor, Xamarin.AndroidX.Leanback", "", this, new java.lang.Object[] {  });
	}


	public void requestAudioPermission ()
	{
		n_requestAudioPermission ();
	}

	private native void n_requestAudioPermission ();

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
