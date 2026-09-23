using Wh40kCharacterList.Core.DiceRolls;
using Newtonsoft.Json;

namespace Wh40kCharacterList.CharacterGui;

internal class RollDiceManagment
{
    public required CharacterFormManager CharacterFormManager { get; init; }

    private int resultD100Chance = 0;

    public void RecalculateChance(int basicChance)
    {
        CharacterFormManager.Form.RollDiceChanceLabel.Text = basicChance.ToString();
        resultD100Chance = basicChance;
    }

    public void SendSkillCheckClicked()
    {
        SkillCheckRoll roll = new()
        {
            Difficulty = resultD100Chance
        };
        Random random = new();
        roll.Roll(random);
        CharacterFormManager.LogPanelGuiManagment.AddText(JsonConvert.SerializeObject(roll.RollResult));
    }
}
