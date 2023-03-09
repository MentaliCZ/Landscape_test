using UnrealBuildTool;

public class Enviroment_testwaterTarget : TargetRules
{
	public Enviroment_testwaterTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Enviroment_testwater");
	}
}
