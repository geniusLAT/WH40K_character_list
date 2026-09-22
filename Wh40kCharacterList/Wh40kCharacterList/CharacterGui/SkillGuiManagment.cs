using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using Wh40kCharacterList.Core.IngameEntities;
using Wh40kCharacterList.Core.IngameEntities.CharacterProperties;

namespace Wh40kCharacterList.CharacterGui;

internal class SkillGuiManagment
{
    public required CharacterFormManager CharacterFormManager { get; init; }

    public void Render(Character character)
    {

        for (int i = 0; i < 49; i++)
        {
            Skill skill = (Skill)i;
            
            //var value = character.GetCharacteristic(skill);
            //characteristicLabel.Text = value.ToString();
        }


    }
}