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
        _manager.RenderCharacter(character);

    }
}
