using System;

namespace UbertestersSDK
{
	//---------------------------------------------------------------------------------------
	// Objective Sharpies generated
	// moved to Structs and Enums
	// ...................................................................
	public enum UbertestersOptions 
	//: [unmapped: unexposed: Elaborated] 
	{
		TOptionsDefault = 0,
		TOptionsSlider = 1 << 0,
		TOptionsShake = 1 << 1,
		TOptionsManual = 1 << 2,
		TOptionsLockingModeDisableUbertestersIfBuildNotExist = 1 << 3,
		TOptionsLockingModeAppIfBuildNotExist = 1 << 4
	}

	public enum LockingMode 
	//: [unmapped: unexposed: Elaborated] 
	{
		DisableUbertestersIfBuildNotExist = 0,
		LockAppIfBuildNotExist = 1
	}

	public enum ActivationMode 
	//: [unmapped: unexposed: Elaborated] 
	{
		UTSlider = 0,
		UTShake = 1,
		UTManual = 2
	}

	public enum UTLogLevel 
	//: [unmapped: unexposed: Elaborated] 
	{
		Error,
		Warning,
		Info
	}
	// ...................................................................
	//---------------------------------------------------------------------------------------

}

