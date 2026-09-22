namespace Wh40kCharacterList.Core.IngameEntities.CharacterProperties;

static public class SkillData
{
    static bool Advanced = true;
    
    static bool Basic = false;

    public static bool MustBeAdvancedByDefault(Skill skill)
    {
        return skill switch
        {
            Skill.Acrobatics => Advanced,
            Skill.Awareness => Basic,
            Skill.Barther => Basic,
            Skill.Blather => Advanced,
            Skill.Carouse => Basic,
            Skill.Charm => Basic,
            Skill.ChemUse => Advanced,
            Skill.Ciphers => Advanced,

            Skill.Climb => Basic,
            Skill.Command => Basic,
            Skill.Commerce => Advanced,
            Skill.CommonLore => Advanced,
            Skill.Concealment => Basic,
            Skill.Contortionist => Basic,
            Skill.Deceive => Basic,
            Skill.Demolition => Advanced,
            Skill.Disguise => Basic,
            Skill.Dodge => Basic,
            Skill.Drive => Advanced,
            Skill.Evaluate => Basic,
            Skill.ForbiddenLore => Advanced,
            Skill.Gamble => Basic,
            Skill.Inquiry => Basic,
            Skill.Interrogation => Advanced,
            Skill.Intimidate => Basic,
            Skill.Invocation => Advanced,
            Skill.LipReading => Advanced,
            Skill.Literacy => Advanced,
            Skill.Logic => Basic,
            Skill.Medicae => Advanced,
            Skill.Navigation => Advanced,
            Skill.Performer => Advanced,
            Skill.Pilot => Advanced,
            Skill.Psyniscience => Advanced,
            Skill.ScholasticLore => Advanced,
            Skill.Scrunity => Basic,
            Skill.Search => Basic,
            Skill.SecretTongue => Advanced,
            Skill.Security => Advanced,
            Skill.Shadowing => Advanced,
            Skill.SilentMove => Basic,
            Skill.SleightOfHand => Advanced,
            Skill.SpeakLanguage => Advanced,
            Skill.Survival => Advanced,
            Skill.Swim => Basic,
            Skill.TechUse => Advanced,
            Skill.Tracking => Advanced,
            Skill.Trade => Advanced,
            Skill.Wrangling => Advanced,
            _ => Advanced,
        };
    }

    public static bool IsGroup(Skill skill)
    {
        return skill switch
        {
            Skill.Ciphers => true,
            Skill.CommonLore => true,
            Skill.Drive => true,
            Skill.ForbiddenLore => true,
            Skill.Navigation => true,
            Skill.Performer => true,
            Skill.Pilot => true,
            Skill.ScholasticLore => true,
            Skill.SecretTongue => true,
            Skill.SpeakLanguage => true,
            Skill.Trade => true,
            _ => false,
        };
    }

    

    public static Characteristic? GetAssisiatedDefaultCharacteristic(Skill skill)
    {
        return skill switch
        {
            Skill.Acrobatics => Characteristic.Agility,
            Skill.Awareness => Characteristic.Perception,
            Skill.Barther => Characteristic.FellowShip,
            Skill.Blather => Characteristic.FellowShip,
            Skill.Carouse => Characteristic.Toughness,
            Skill.Charm => Characteristic.FellowShip,
            Skill.ChemUse => Characteristic.Intelligence,
            Skill.Ciphers => Characteristic.Intelligence,
            Skill.Climb => Characteristic.Strenght,
            Skill.Command => Characteristic.FellowShip,
            Skill.Commerce => Characteristic.FellowShip,
            Skill.CommonLore => Characteristic.Intelligence,
            Skill.Concealment => Characteristic.Agility,
            Skill.Contortionist => Characteristic.Agility,
            Skill.Deceive => Characteristic.FellowShip,
            Skill.Demolition => Characteristic.Intelligence,
            Skill.Disguise => Characteristic.FellowShip,
            Skill.Dodge => Characteristic.Agility,
            Skill.Drive => Characteristic.Agility,
            Skill.Evaluate => Characteristic.Intelligence,
            Skill.ForbiddenLore => Characteristic.Intelligence,
            Skill.Gamble => Characteristic.Intelligence,
            Skill.Inquiry => Characteristic.FellowShip,
            Skill.Interrogation => Characteristic.WillPower,
            Skill.Intimidate => Characteristic.Strenght,
            Skill.Invocation => Characteristic.WillPower,
            Skill.LipReading => Characteristic.Perception,
            Skill.Literacy => Characteristic.Intelligence,
            Skill.Logic => Characteristic.Intelligence,
            Skill.Medicae => Characteristic.Intelligence,
            Skill.Navigation => Characteristic.Intelligence,
            Skill.Performer => Characteristic.FellowShip,
            Skill.Pilot => Characteristic.Agility,
            Skill.Psyniscience => Characteristic.Perception,
            Skill.ScholasticLore => Characteristic.Intelligence,
            Skill.Scrunity => Characteristic.Perception,
            Skill.Search => Characteristic.Perception,
            Skill.SecretTongue => Characteristic.Intelligence,
            Skill.Security => Characteristic.Agility,
            Skill.Shadowing => Characteristic.Agility,
            Skill.SilentMove => Characteristic.Agility,
            Skill.SleightOfHand => Characteristic.Agility,
            Skill.SpeakLanguage => Characteristic.Intelligence,
            Skill.Survival => Characteristic.Intelligence,
            Skill.Swim => Characteristic.Strenght,
            Skill.TechUse => Characteristic.Intelligence,
            Skill.Tracking => Characteristic.Intelligence,
            Skill.Trade => null,
            Skill.Wrangling => Characteristic.Intelligence,
            _ => null,
        };
    }
}
