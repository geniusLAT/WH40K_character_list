using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wh40kCharacterList.Core.IngameEntities;

namespace Wh40kCharacterList.CharacterGui;

internal class CharacterFormManager
{
    public Character ChosenCharacter;

    public CharacterForm Form;

    private readonly CharacteristicGuiManagment _characteristicGuiManagment;

    public CharacterFormManager(CharacterForm characterForm)
    {
        Form = characterForm;
        _characteristicGuiManagment = new()
        { CharacterFormManager = this };
    }

    public void RenderCharacter()
    {
        RenderCharacter(ChosenCharacter);
    }

    public void RenderCharacter(Character character)
    {
        ChosenCharacter = character;
        _characteristicGuiManagment.Render(character);
    }
}
