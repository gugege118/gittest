package md55e006678c9de789c3dea38497923bc22;


public class BackgroundServiceBinder
	extends android.os.Binder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Plugin.BackgroundService.BackgroundServiceBinder, Plugin.BackgroundService", BackgroundServiceBinder.class, __md_methods);
	}


	public BackgroundServiceBinder ()
	{
		super ();
		if (getClass () == BackgroundServiceBinder.class)
			mono.android.TypeManager.Activate ("Plugin.BackgroundService.BackgroundServiceBinder, Plugin.BackgroundService", "", this, new java.lang.Object[] {  });
	}

	public BackgroundServiceBinder (md55e006678c9de789c3dea38497923bc22.NativeBackgroundServiceHost p0)
	{
		super ();
		if (getClass () == BackgroundServiceBinder.class)
			mono.android.TypeManager.Activate ("Plugin.BackgroundService.BackgroundServiceBinder, Plugin.BackgroundService", "Plugin.BackgroundService.NativeBackgroundServiceHost, Plugin.BackgroundService", this, new java.lang.Object[] { p0 });
	}

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
