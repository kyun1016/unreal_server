// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Overwatch : ModuleRules
{
	public Overwatch(ReadOnlyTargetRules Target) : base(Target)
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

		PrivateDependencyModuleNames.AddRange(new string[] { "GameplayAbilities", "GameplayTags", "GameplayTasks", "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });

		PublicIncludePaths.AddRange(new string[] {
			"Overwatch",
			"Overwatch/Variant_Platforming",
			"Overwatch/Variant_Platforming/Animation",
			"Overwatch/Variant_Combat",
			"Overwatch/Variant_Combat/AI",
			"Overwatch/Variant_Combat/Animation",
			"Overwatch/Variant_Combat/Gameplay",
			"Overwatch/Variant_Combat/Interfaces",
			"Overwatch/Variant_Combat/UI",
			"Overwatch/Variant_SideScrolling",
			"Overwatch/Variant_SideScrolling/AI",
			"Overwatch/Variant_SideScrolling/Gameplay",
			"Overwatch/Variant_SideScrolling/Interfaces",
			"Overwatch/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
