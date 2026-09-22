using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using Wh40kCharacterList.Core.IngameEntities;
using Wh40kCharacterList.Core.IngameEntities.CharacterProperties;
using Wh40kCharacterList.Core.Language;

namespace Wh40kCharacterList.CharacterGui;

internal class SkillGuiManagment
{
    public required CharacterFormManager CharacterFormManager { get; init; }

    public void Render(Character character)
    {
        Panel currentPanelToFill = CharacterFormManager.Form.LeftSkillPanel;
        var totalUpperMargin = 0;
        for (int i = 0; i < 49; i++)
        {
            if (i == 26)
            {
                currentPanelToFill = CharacterFormManager.Form.RightSkillPanel;
                totalUpperMargin = 0;
            }

            Skill skill = (Skill)i;

            var skillPanel = new Panel()
            {
                //BackColor = Color.Blue,
                Location = new Point(10, totalUpperMargin),
                Size = new Size(190, 10)
            };
            currentPanelToFill.Controls.Add(skillPanel);
           
            var skillLabel = new Label()
            {
                Size = new Size(130, 10),
                Font = new("Segoe UI", 7),
                Text = CharacterFormManager.LanguagePack.TranslateSkill(skill)
            };
            skillPanel.Controls.Add(skillLabel);

            totalUpperMargin += 10;

            if (!SkillData.IsGroup(skill))
            {
                for (int skilButtonIndex = 0; skilButtonIndex < 4; skilButtonIndex++)
                {
                    var skillRadioButton = new RadioButton()
                    {
                        Location = new Point(130 + skilButtonIndex * 10, 0),
                        AutoCheck = false,
                        Checked = true,
                        Size = new Size(10, 10),
                    };
                    skillPanel.Controls.Add(skillRadioButton);
                }
                var skillRollDefaultChanceLabel = new Label()
                {
                    Location = new Point(170, 0),
                    Size = new Size(140, 10),
                    Font = new("Segoe UI", 7),
                    Text = "50%"
                };
                skillPanel.Controls.Add(skillRollDefaultChanceLabel);
            }
            //var value = character.GetCharacteristic(skill);
            //characteristicLabel.Text = value.ToString();
        }


    }
}