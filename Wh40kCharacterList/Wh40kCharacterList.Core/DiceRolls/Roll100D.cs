using System.Text.Json.Serialization;

namespace Wh40kCharacterList.Core.DiceRolls;

public class Roll100D : RollDice
{
    #region result

    [JsonPropertyName("roll-result")]
    public int? RollResult { get; set; }

    [JsonPropertyName("roll-success")]
    public bool? RollSuccess { get; set; }

    [JsonPropertyName("grades")]
    public int? Grades { get; set; }

    #endregion

    [JsonPropertyName("difficulty")]
    public int Difficulty { get; set; }

    public override void Roll(Random random)
    {
        RollResult = random.Next(1, 101);
        RollSuccess = RollResult <= Difficulty;
        Grades = (RollResult - Difficulty) / 10;
        if (Grades < 0) Grades *= -1;
    }
}
