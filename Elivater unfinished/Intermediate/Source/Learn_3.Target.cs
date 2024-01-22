using UnrealBuildTool;

public class Learn_3Target : TargetRules
{
	public Learn_3Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Learn_3");
	}
}
