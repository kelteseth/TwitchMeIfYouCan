// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class TwitchMeIfYouCanEditorTarget : TargetRules
{
	public TwitchMeIfYouCanEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "TwitchMeIfYouCan" } );
	}
}
