using Wh40kCharacterList.Core.IngameEntities;
using Wh40kCharacterList.Core.IngameEntities.CharacterProperties;

namespace Wh40kCharacterList.CharacterGui;

internal class SkillGuiManagment
{
    public required CharacterFormManager CharacterFormManager { get; init; }

    public SkillGuiElement? ChosenSkillGuiElement { get; set; }

    private List<SkillGuiElement> _skillGuiElements = [];

    public void ClearChoice()
    {
        if(ChosenSkillGuiElement is null) return; 

        ChosenSkillGuiElement.Panel.BackColor = Color.White;

        ChosenSkillGuiElement = null;
    }

    public void Render(Character character)
    {
        CharacterFormManager.Form.LeftSkillPanel.Controls.Clear();
        CharacterFormManager.Form.RightSkillPanel.Controls.Clear();
        _skillGuiElements.Clear();

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
                    var skillLevel = skillLevels[subSkillIndex];
                    var groupSkill = skillLevel as GroupSkillLevel;

                    totalUpperMargin += 10;
                    var subSkillPanel = new Panel()
                    {
                        //BackColor = Color.Blue,
                        Location = new Point(0, 10 * (subSkillIndex + 1)),
                        Size = new Size(190, 10)
                    };
                    subSkillPanel.Click += SkillGuiElement_Click;

                    skillPanel.Controls.Add(subSkillPanel);

                    var subSkillLabel = new Label()
                    {
                        Size = new Size(130, 10),
                        Font = new("Segoe UI", 7),
                        Text = $"   {groupSkill?.GroupName ?? string.Empty}"
                    };
                    subSkillLabel.Click += SkillGuiElement_Click;
                    subSkillPanel.Controls.Add(subSkillLabel);

                    RenderMonoSkill(skillLevel, character, subSkillPanel);
                    _skillGuiElements.Add(new()
                    {
                        Label = subSkillLabel,
                        Panel = subSkillPanel,
                        SkillLevel = skillLevel
                    }
                    );
                }
            } else
            {

                skillPanel.Click += SkillGuiElement_Click;
                skillLabel.Click += SkillGuiElement_Click;

                var skillLevel = skillLevels.FirstOrDefault();
                RenderMonoSkill(skillLevel, character, skillPanel);
                _skillGuiElements.Add(new()
                {
                    Label = skillLabel,
                    Panel = skillPanel,
                    SkillLevel = skillLevel
                }
                   );
            }
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

    private void SkillGuiElement_Click(object sender, EventArgs e)
    {
        ClearChoice();
        var skillGuiElement = _skillGuiElements.Where(element => element.Panel == sender || element.Label == sender).FirstOrDefault();

        if (skillGuiElement is null)
        {
            return;
        }

        skillGuiElement.Panel.BackColor = Color.Yellow;
        ChosenSkillGuiElement = skillGuiElement;
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