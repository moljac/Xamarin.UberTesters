using MonoTouch.ObjCRuntime;


[assembly: 
	LinkWith 
	(
	  "UbertestersSDK.a"
	, LinkTarget.Simulator | LinkTarget.ArmV6 | LinkTarget.ArmV7
	, ForceLoad = true
	, WeakFrameworks=
			"AdSupport" 
			+ " " +
			"QuartzCore"
			+ " " +
			"CoreImage"
			+ " " +
			"SystemConfiguration"
			+ " " +
			"CoreTelephony"
			+ " " +
			"CoreLocation"
			+ " " +
			"AudioToolbox" 
			+ " " +
			"OpenGLES"
			+ " " +
			"CoreMotion"
	)
]
