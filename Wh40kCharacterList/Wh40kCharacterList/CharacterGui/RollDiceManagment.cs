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
}
