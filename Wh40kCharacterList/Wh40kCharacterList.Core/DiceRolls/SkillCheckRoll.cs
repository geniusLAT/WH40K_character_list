using System.Text.Json.Serialization;
using Wh40kCharacterList.Core.DiceRolls.RollResults;

namespace Wh40kCharacterList.Core.DiceRolls;

public class SkillCheckRoll : RollDice
{
    [JsonPropertyName("roll-result")]
    public SkillCheckRollResult? RollResult { get; set; }

    [JsonPropertyName("difficulty")]
    public int Difficulty { get; set; }

    public override void Roll(Random random)
    {
        var rollResult = random.Next(1, 101);
        var rollSuccess = rollResult <= Difficulty;
        var grades = (rollResult - Difficulty) / 10;
        if (grades < 0) grades *= -1;

        RollResult = new()
        {
            Grades = grades,
            RollResult = rollResult,
            RollSuccess = rollSuccess
        };
    }
}
