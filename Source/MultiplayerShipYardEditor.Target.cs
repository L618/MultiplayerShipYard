// bv01d7@gmail.com

using UnrealBuildTool;
using System.Collections.Generic;

public class MultiplayerShipYardEditorTarget : TargetRules
{
	public MultiplayerShipYardEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "MultiplayerShipYard" } );
	}
}
