using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wh40kCharacterList.Core.IngameEntities.CharacterProperties;

static class SkillData
{
    public static bool MustBeBasicByDefault(Skill skill)
    {
        return skill switch
        {
            Skill.Acrobatics => false,
            Skill.Awareness => true,
            Skill.Barther => true,
            Skill.Blather => false,
            Skill.Carouse => true,
            Skill.Charm => true,
            Skill.ChemUse => false,
            Skill.Ciphers => false,
            Skill.Climb => true,
            Skill.Command => true,
            Skill.Commerce => false,
            Skill.CommonLore => false,
            Skill.Concealment => true,
            Skill.Contortionist => true,
            Skill.Deceive => true,
            Skill.Demolition => false,
            Skill.Disguise => true,
            Skill.Dodge => true,
            Skill.Drive => false,
            Skill.Evaluate => true,
            Skill.ForbiddenLore => false,
            Skill.Gamble => true,
            Skill.Inquiry => true,
            Skill.Interrogation => false,
            Skill.Intimidate => true,
            Skill.Invocation => false,
            Skill.LipReading => false,
            Skill.Literacy => false,
            Skill.Logic => true,
            Skill.Medicae => true,
            Skill.Navigation => true,
            Skill.Performer => true,
            Skill.Pilot => true,
            Skill.Psyniscience => true,
            Skill.ScholasticLore => true,
            Skill.Scrunity => true,
            Skill.Search => true,
            Skill.SecretTongue => false,
            Skill.Security => false,
            Skill.Shadowing => false,
            Skill.SilentMove => true,
            Skill.SleightOfHand => false,
            Skill.SpeakLanguage => false,
            Skill.Survival => false,
            Skill.Swim => true,
            Skill.TechUse => false,
            Skill.Tracking => false,
            Skill.Trade => false,
            Skill.Wrangling => false,
            _ => false,
        };
    }
}
