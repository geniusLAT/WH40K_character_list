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

            var skillLevels = character.GetSkills(skill);

            if (SkillData.IsGroup(skill))
            {
                skillPanel.Size = new Size(190, 10 * (skillLevels.Count + 1));
                for (int subSkillIndex = 0; subSkillIndex < skillLevels.Count; subSkillIndex++)
                {
                    var groupSkill = skillLevels[subSkillIndex] as GroupSkillLevel;

                    totalUpperMargin += 10;
                    var subSkillPanel = new Panel()
                    {
                        //BackColor = Color.Blue,
                        Location = new Point(0, 10 * (subSkillIndex + 1)),
                        Size = new Size(190, 10)
                    };
                    
                    skillPanel.Controls.Add(subSkillPanel);

                    var subSkillLabel = new Label()
                    {
                        Size = new Size(130, 10),
                        Font = new("Segoe UI", 7),
                        Text = $"   {groupSkill?.GroupName ?? string.Empty}"
                    };
                    subSkillPanel.Controls.Add(subSkillLabel);

                    RenderMonoSkill(skillLevels[subSkillIndex], character, subSkillPanel);
                }
            } else
            {
                RenderMonoSkill(skillLevels.FirstOrDefault(), character, skillPanel);
            }
            //var value = character.GetCharacteristic(skill);
            //characteristicLabel.Text = value.ToString();
        }
    }

    void RenderMonoSkill(
        SkillLevel? skillLevel,
        Character character,
        Panel skillPanel)
    {
        var chance = 0;


        var levelValue = 0;
        if (skillLevel is not null)
        {
            levelValue = skillLevel.Level;
            chance = CalculcateChanceForSkill(skillLevel, character);
        }


        for (int skilButtonIndex = 0; skilButtonIndex < 4; skilButtonIndex++)
        {
            var skillRadioButton = new RadioButton()
            {
                Location = new Point(130 + skilButtonIndex * 10, 0),
                AutoCheck = false,
                Checked = !(skilButtonIndex >= levelValue),
                Size = new Size(10, 10),
            };
            skillPanel.Controls.Add(skillRadioButton);
        }
        var skillRollDefaultChanceLabel = new Label()
        {
            Location = new Point(170, 0),
            Size = new Size(140, 10),
            Font = new("Segoe UI", 7),
            Text = $"{chance}%"
        };
        skillPanel.Controls.Add(skillRollDefaultChanceLabel);
    }

    int CalculcateChanceForSkill(SkillLevel skillLevel, Character character)
    {
        if (skillLevel.Level < 1)
        {
            return 0;
        }

        if (skillLevel.Skill is null)
        {
            return -1;
        }

        var assosiatedCharacteristic = SkillData.GetAssisiatedDefaultCharacteristic((Skill)skillLevel.Skill);

        if (assosiatedCharacteristic is null)
        {
            return -1;
        }

        var characteristicValue = character.GetCharacteristic((Characteristic)assosiatedCharacteristic);

        if (skillLevel.Level == 1)
        {
            return characteristicValue/2;
        }
        if (skillLevel.Level == 2)
        {
            return characteristicValue;
        }
        if (skillLevel.Level == 3)
        {
            return characteristicValue + 10;
        }
        return characteristicValue + 20;
    }
}