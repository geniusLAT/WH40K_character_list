using Wh40kCharacterList.Core.IngameEntities;
using Wh40kCharacterList.Core.Language;
using Wh40kCharacterList.Core.IngameEntities.CharacterProperties;

namespace Wh40kCharacterList.CharacterGui;

public partial class CharacterForm : Form
{
    private readonly CharacterFormManager _manager;

    public CharacterForm()
    {
        _manager = new(this, new RussianLanguagePack());

        InitializeComponent();

        //test only

        Character character = new()
        {
            WeaponSkill = 10,
            BallisticSkill = 20,
            Strenght = 30,
            Toughness = 40,
            Agility = 50,
            Intelligence = 60,
            Perception = 70,
            WillPower = 80,
            FellowShip = 90,
        };
        character.Skills.Add(new()
        {
            Level = 4,
            Skill = Skill.TechUse
        });

        character.Skills.Add(new GroupSkillLevel()
        {
            Level = 1,
            Skill = Skill.SpeakLanguage,
            GroupName = "Низкий готик"
        });
        character.Skills.Add(new GroupSkillLevel()
        {
            Level = 3,
            Skill = Skill.SpeakLanguage,
            GroupName = "Высокий готик"
        });
        //for (int i = 0; i < 40; i++)
        //{
        //    character.Skills.Add(new GroupSkillLevel()
        //    {
        //        Level = 3,
        //        Skill = Skill.SpeakLanguage,
        //        GroupName = $"Высокий готик {i}"
        //    });
        //}

        //for (int i = 0; i < 40; i++)
        //{
        //    character.Skills.Add(new GroupSkillLevel()
        //    {
        //        Level = 3,
        //        Skill = Skill.Ciphers,
        //        GroupName = $"Шифры {i}"
        //    });
        //}


        _manager.RenderCharacter(character);

    }
}
