// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ProjectPullout : ModuleRules
{
	public ProjectPullout(ReadOnlyTargetRules Target) : base(Target)
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
			"ProjectPullout",
			"ProjectPullout/Variant_Platforming",
			"ProjectPullout/Variant_Platforming/Animation",
			"ProjectPullout/Variant_Combat",
			"ProjectPullout/Variant_Combat/AI",
			"ProjectPullout/Variant_Combat/Animation",
			"ProjectPullout/Variant_Combat/Gameplay",
			"ProjectPullout/Variant_Combat/Interfaces",
			"ProjectPullout/Variant_Combat/UI",
			"ProjectPullout/Variant_SideScrolling",
			"ProjectPullout/Variant_SideScrolling/AI",
			"ProjectPullout/Variant_SideScrolling/Gameplay",
			"ProjectPullout/Variant_SideScrolling/Interfaces",
			"ProjectPullout/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
