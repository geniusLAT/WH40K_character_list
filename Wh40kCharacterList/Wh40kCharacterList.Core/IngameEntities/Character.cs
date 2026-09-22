using Wh40kCharacterList.Core.IngameEntities.CharacterProperties;

namespace Wh40kCharacterList.Core.IngameEntities;

public class Character
{
    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty ;

    #region Characteristics

    public int WeaponSkill { get; set; }

    public int WeaponSkillUpgrades { get; set; }

    public int BallisticSkill { get; set; }

    public int BallisticSkillUpgrades { get; set; }

    public int Strenght {  get; set; }

    public int StrenghtUpgrades {  get; set; }

    public int Toughness { get; set; }

    public int ToughnessUpgrades { get; set; }

    public int Agility { get; set; }

    public int AgilityUpgrades { get; set; }

    public int Intelligence { get; set; }

    public int IntelligenceUpgrades { get; set; }

    public int Perception { get; set; }

    public int PerceptionUpgrades { get; set; }

    public int WillPower { get; set; }

    public int WillPowerUpgrades { get; set; }

    public int FellowShip { get; set; }

    public int FellowShipUpgrades { get; set; }

    #endregion

    public List<SkillLevel> Skills { get; set; }

    public Character()
    {
        FillBasicSkill();
    }

    public void FillBasicSkill()
    {
        for (int i = 0; i < 49; i++)
        {
            var skill = (Skill)i;
            if (SkillData.MustBeBasicByDefault(skill))
            {
                Skills.Add(new SkillLevel()
                {
                    Skill = skill,
                    Level = 1
                }
                    );
            }
        }
    }


    #region CharacteristicMethods

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

    public int GetCharacteristicUpgrades(Characteristic characteristic)
    {
        return characteristic switch
        {
            Characteristic.WeaponSkill => WeaponSkillUpgrades,
            Characteristic.BallisticSkill => BallisticSkillUpgrades,
            Characteristic.Strenght => StrenghtUpgrades,
            Characteristic.Toughness => ToughnessUpgrades,
            Characteristic.Agility => AgilityUpgrades,
            Characteristic.Intelligence => IntelligenceUpgrades,
            Characteristic.Perception => PerceptionUpgrades,
            Characteristic.WillPower => WillPowerUpgrades,
            Characteristic.FellowShip => FellowShipUpgrades,
            _ => throw new ArgumentException(),
        };
    }

    public int SetCharacteristicUpgrades(Characteristic characteristic, int value)
    {
        if (value > 4) throw new ArgumentException();

        return characteristic switch
        {
            Characteristic.WeaponSkill => WeaponSkillUpgrades = value,
            Characteristic.BallisticSkill => BallisticSkillUpgrades = value,
            Characteristic.Strenght => StrenghtUpgrades = value,
            Characteristic.Toughness => ToughnessUpgrades = value,
            Characteristic.Agility => AgilityUpgrades = value,
            Characteristic.Intelligence => IntelligenceUpgrades = value,
            Characteristic.Perception => PerceptionUpgrades = value,
            Characteristic.WillPower => WillPowerUpgrades = value,
            Characteristic.FellowShip => FellowShipUpgrades = value,
            _ => throw new ArgumentException(),
        };
    }
    
    #endregion
}
