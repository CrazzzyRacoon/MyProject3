// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using System;
using System.IO;

using UnrealBuildTool;

public class NDIExamples : ModuleRules
{
	public NDIExamples(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;        

        // Include the Public include paths
        if (Directory.Exists(Path.Combine(ModuleDirectory, "Public")))
        {
            PublicIncludePaths.AddRange(new string[] {
                    // ... add public include paths required here ...
                    Path.Combine(ModuleDirectory, "Public" ),
                });
        }

        PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });
		
		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
