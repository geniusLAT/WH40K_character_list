namespace Wh40kCharacterList.CharacterGui;

public partial class CharacterForm : Form
{
    private readonly CharacterFormManager _manager;

    public CharacterForm()
    {
        _manager = new(this);

        InitializeComponent();

        //test only

        _manager.RenderCharacter(new()
            {
                WeaponSkill = 10,
                BallisticSkill = 20,
                Strenght = 30,
                Toughness = 40,
                Agility = 50,
                Intelligence = 60,
                Perception = 70,
                WillPower = 80,
                FellowShip  = 90,
            }
        );

    }
}
