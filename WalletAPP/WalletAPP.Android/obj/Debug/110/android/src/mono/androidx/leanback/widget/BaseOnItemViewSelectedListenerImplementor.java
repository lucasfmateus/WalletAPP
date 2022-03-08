package mono.androidx.leanback.widget;


public class BaseOnItemViewSelectedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		androidx.leanback.widget.BaseOnItemViewSelectedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onItemSelected:(Landroidx/leanback/widget/Presenter$ViewHolder;Ljava/lang/Object;Landroidx/leanback/widget/RowPresenter$ViewHolder;Ljava/lang/Object;)V:GetOnItemSelected_Landroidx_leanback_widget_Presenter_ViewHolder_Ljava_lang_Object_Landroidx_leanback_widget_RowPresenter_ViewHolder_Ljava_lang_Object_Handler:AndroidX.Leanback.Widget.IBaseOnItemViewSelectedListenerInvoker, Xamarin.AndroidX.Leanback\n" +
			"";
		mono.android.Runtime.register ("AndroidX.Leanback.Widget.IBaseOnItemViewSelectedListenerImplementor, Xamarin.AndroidX.Leanback", BaseOnItemViewSelectedListenerImplementor.class, __md_methods);
	}


	public BaseOnItemViewSelectedListenerImplementor ()
	{
		super ();
		if (getClass () == BaseOnItemViewSelectedListenerImplementor.class)
			mono.android.TypeManager.Activate ("AndroidX.Leanback.Widget.IBaseOnItemViewSelectedListenerImplementor, Xamarin.AndroidX.Leanback", "", this, new java.lang.Object[] {  });
	}


	public void onItemSelected (androidx.leanback.widget.Presenter.ViewHolder p0, java.lang.Object p1, androidx.leanback.widget.RowPresenter.ViewHolder p2, java.lang.Object p3)
	{
		n_onItemSelected (p0, p1, p2, p3);
	}

	private native void n_onItemSelected (androidx.leanback.widget.Presenter.ViewHolder p0, java.lang.Object p1, androidx.leanback.widget.RowPresenter.ViewHolder p2, java.lang.Object p3);

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
