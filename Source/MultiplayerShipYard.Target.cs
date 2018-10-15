// bv01d7@gmail.com

using UnrealBuildTool;
using System.Collections.Generic;

public class MultiplayerShipYardTarget : TargetRules
{
	public MultiplayerShipYardTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "MultiplayerShipYard" } );
	}
}
