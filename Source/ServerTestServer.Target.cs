// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

//public class ServerTestServerTarget: TargetRules

    [SupportedPlatforms(UnrealPlatformClass.Server)]
    public class ServerTestServerTarget : TargetRules
{


	public ServerTestServerTarget(TargetInfo Target)
	{
		Type = TargetType.Server;
	}

	//
	// TargetRules interface.
	//

	public override void SetupBinaries(
		TargetInfo Target,
		ref List<UEBuildBinaryConfiguration> OutBuildBinaryConfigurations,
		ref List<string> OutExtraModuleNames
		)
	{
		OutExtraModuleNames.AddRange( new string[] { "ServerTest" } );
	}

   // public override bool GetSupportedPlatforms(ref List<UnrealTargetPlatform> OutPlatforms)
    //{
    //    // It is valid for only server platforms
    //    return UnrealBuildTool.UnrealBuildTool.GetAllServerPlatforms(ref OutPlatforms, false);
    //}


	
}
