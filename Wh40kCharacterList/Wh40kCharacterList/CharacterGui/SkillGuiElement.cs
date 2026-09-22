using Wh40kCharacterList.Core.IngameEntities.CharacterProperties;

namespace Wh40kCharacterList.CharacterGui;

internal class SkillGuiElement
{
    public required Panel Panel { get; set; }

    public required Label Label { get; set; }

    public required SkillLevel SkillLevel { get; set; }
}
