package mono.androidx.leanback.widget;


public class BaseOnItemViewClickedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		androidx.leanback.widget.BaseOnItemViewClickedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onItemClicked:(Landroidx/leanback/widget/Presenter$ViewHolder;Ljava/lang/Object;Landroidx/leanback/widget/RowPresenter$ViewHolder;Ljava/lang/Object;)V:GetOnItemClicked_Landroidx_leanback_widget_Presenter_ViewHolder_Ljava_lang_Object_Landroidx_leanback_widget_RowPresenter_ViewHolder_Ljava_lang_Object_Handler:AndroidX.Leanback.Widget.IBaseOnItemViewClickedListenerInvoker, Xamarin.AndroidX.Leanback\n" +
			"";
		mono.android.Runtime.register ("AndroidX.Leanback.Widget.IBaseOnItemViewClickedListenerImplementor, Xamarin.AndroidX.Leanback", BaseOnItemViewClickedListenerImplementor.class, __md_methods);
	}


	public BaseOnItemViewClickedListenerImplementor ()
	{
		super ();
		if (getClass () == BaseOnItemViewClickedListenerImplementor.class)
			mono.android.TypeManager.Activate ("AndroidX.Leanback.Widget.IBaseOnItemViewClickedListenerImplementor, Xamarin.AndroidX.Leanback", "", this, new java.lang.Object[] {  });
	}


	public void onItemClicked (androidx.leanback.widget.Presenter.ViewHolder p0, java.lang.Object p1, androidx.leanback.widget.RowPresenter.ViewHolder p2, java.lang.Object p3)
	{
		n_onItemClicked (p0, p1, p2, p3);
	}

	private native void n_onItemClicked (androidx.leanback.widget.Presenter.ViewHolder p0, java.lang.Object p1, androidx.leanback.widget.RowPresenter.ViewHolder p2, java.lang.Object p3);

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
