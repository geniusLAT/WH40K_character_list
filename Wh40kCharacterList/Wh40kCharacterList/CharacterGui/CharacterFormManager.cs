using Wh40kCharacterList.Core.IngameEntities;
using Wh40kCharacterList.Core.Language;

namespace Wh40kCharacterList.CharacterGui;

internal class CharacterFormManager
{
    public Character ChosenCharacter;

    public CharacterForm Form;

    public readonly ILanguagePack LanguagePack;

    public readonly RollDiceManagment RollDiceManagment;

    public readonly LogPanelGuiManagment LogPanelGuiManagment;

    private readonly CharacteristicGuiManagment _characteristicGuiManagment;

    private readonly SkillGuiManagment _skillGuiManagment;

    public CharacterFormManager(CharacterForm characterForm, ILanguagePack languagePack)
    {
        LanguagePack = languagePack;
        Form = characterForm;
        RollDiceManagment = new()
        { CharacterFormManager = this };
        LogPanelGuiManagment = new()
        { CharacterFormManager = this };
        _characteristicGuiManagment = new()
        { CharacterFormManager = this };
        _skillGuiManagment = new()
        { CharacterFormManager = this };

        ChosenCharacter = new();
    }

    public void RenderCharacter()
    {
        RenderCharacter(ChosenCharacter);
    }

    public void RenderCharacter(Character character)
    {
        ChosenCharacter = character;
        _characteristicGuiManagment.Render(character);
        _skillGuiManagment.Render(character);
    }
}
