package mono.androidx.leanback.widget.picker;


public class Picker_PickerValueListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		androidx.leanback.widget.picker.Picker.PickerValueListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onValueChanged:(Landroidx/leanback/widget/picker/Picker;I)V:GetOnValueChanged_Landroidx_leanback_widget_picker_Picker_IHandler:AndroidX.Leanback.Widget.Picker.Picker/IPickerValueListenerInvoker, Xamarin.AndroidX.Leanback\n" +
			"";
		mono.android.Runtime.register ("AndroidX.Leanback.Widget.Picker.Picker+IPickerValueListenerImplementor, Xamarin.AndroidX.Leanback", Picker_PickerValueListenerImplementor.class, __md_methods);
	}


	public Picker_PickerValueListenerImplementor ()
	{
		super ();
		if (getClass () == Picker_PickerValueListenerImplementor.class)
			mono.android.TypeManager.Activate ("AndroidX.Leanback.Widget.Picker.Picker+IPickerValueListenerImplementor, Xamarin.AndroidX.Leanback", "", this, new java.lang.Object[] {  });
	}


	public void onValueChanged (androidx.leanback.widget.picker.Picker p0, int p1)
	{
		n_onValueChanged (p0, p1);
	}

	private native void n_onValueChanged (androidx.leanback.widget.picker.Picker p0, int p1);

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
