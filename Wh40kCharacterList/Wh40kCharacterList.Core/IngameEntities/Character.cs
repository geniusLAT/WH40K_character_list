using Wh40kCharacterList.Core.IngameEntities.CharacterProperties;

namespace Wh40kCharacterList.Core.IngameEntities;

public class Character
{
    public string Name { get; set; } = string.Empty;

    public string Description { get; set; }

    #region Characteristics

    public int WeaponSkill { get; set; }

    public int BallisticSkill { get; set; }

    public int Strenght {  get; set; }

    public int Toughness { get; set; }

    public int Agility { get; set; }

    public int Intelligence { get; set; }

    public int Perception { get; set; }

    public int WillPower { get; set; }

    public int FellowShip { get; set; }

    #endregion

    public int GetCharacteristic(Characteristic characteristic)
    {
        return characteristic switch
        {
            Characteristic.WeaponSkill => WeaponSkill,
            Characteristic.BallisticSkill => BallisticSkill,
            Characteristic.Strenght => Strenght,
            Characteristic.Toughness => Toughness,
            Characteristic.Agility => Agility,
            Characteristic.Intelligence => Intelligence,
            Characteristic.Perception => Perception,
            Characteristic.WillPower => WillPower,
            Characteristic.FellowShip => FellowShip,
            _ => throw new ArgumentException(),
        };
    }

    public int SetCharacteristic(Characteristic characteristic, int value)
    {
        return characteristic switch
        {
            Characteristic.WeaponSkill => WeaponSkill = value,
            Characteristic.BallisticSkill => BallisticSkill = value,
            Characteristic.Strenght => Strenght = value,
            Characteristic.Toughness => Toughness = value,
            Characteristic.Agility => Agility = value,
            Characteristic.Intelligence => Intelligence = value,
            Characteristic.Perception => Perception = value,
            Characteristic.WillPower => WillPower = value,
            Characteristic.FellowShip => FellowShip = value,
            _ => throw new ArgumentException(),
        };
    }
}
