using Wh40kCharacterList.Core.IngameEntities;
using Wh40kCharacterList.Core.IngameEntities.CharacterProperties;

namespace Wh40kCharacterList.CharacterGui;

internal class CharacteristicGuiManagment
{
    public required CharacterFormManager CharacterFormManager { get; init; }

    public void Render(Character character)
    {
        for (int i = 0; i < 9; i++)
        {
            Characteristic characteristic = (Characteristic)i;
            var characteristicLabel = GetCharacteristicValueLabel(characteristic);
            var value = character.GetCharacteristic(characteristic);
            characteristicLabel.Text = value.ToString();
        }
    }

    public Label GetCharacteristicValueLabel(Characteristic characteristic)
    {
        switch (characteristic)
        {
            case Characteristic.WeaponSkill:
                return CharacterFormManager.Form.WeaponSkillValueLabel;
            case Characteristic.BallisticSkill:
                return CharacterFormManager.Form.BallisticSkillValueLabel;
            case Characteristic.Strenght:
                return CharacterFormManager.Form.StrenghtValueLabel;
            case Characteristic.Toughness:
                return CharacterFormManager.Form.ToughnessValueLabel;
            case Characteristic.Agility:
                return CharacterFormManager.Form.AgilityValueLabel;
            case Characteristic.Intelligence:
                return CharacterFormManager.Form.IntelligenceValueLabel;
            case Characteristic.Perception:
                return CharacterFormManager.Form.PerceptionValueLabel;
            case Characteristic.WillPower:
                return CharacterFormManager.Form.WillpowerValueLabel;
            case Characteristic.FellowShip:
                return CharacterFormManager.Form. FellowShipValueLabel;
            default:
                throw new ArgumentException();
        }
    }
}