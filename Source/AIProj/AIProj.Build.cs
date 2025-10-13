// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class AIProj : ModuleRules
{
	public AIProj(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"AIProj",
			"AIProj/Variant_Platforming",
			"AIProj/Variant_Platforming/Animation",
			"AIProj/Variant_Combat",
			"AIProj/Variant_Combat/AI",
			"AIProj/Variant_Combat/Animation",
			"AIProj/Variant_Combat/Gameplay",
			"AIProj/Variant_Combat/Interfaces",
			"AIProj/Variant_Combat/UI",
			"AIProj/Variant_SideScrolling",
			"AIProj/Variant_SideScrolling/AI",
			"AIProj/Variant_SideScrolling/Gameplay",
			"AIProj/Variant_SideScrolling/Interfaces",
			"AIProj/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
