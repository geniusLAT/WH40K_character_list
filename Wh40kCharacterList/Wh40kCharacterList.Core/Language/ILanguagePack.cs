using Wh40kCharacterList.Core.IngameEntities.CharacterProperties;

namespace Wh40kCharacterList.Core.Language;

public interface ILanguagePack
{
    string TranslateSkill(Skill skill);
}
