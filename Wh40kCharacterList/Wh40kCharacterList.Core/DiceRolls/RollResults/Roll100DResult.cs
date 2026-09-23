using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Wh40kCharacterList.Core.DiceRolls.RollResults;

public class Roll100DResult 
{
    [Required]
    [JsonPropertyName("roll-result")]
    public required int RollResult { get; set; }

    [Required]
    [JsonPropertyName("roll-success")]
    public required bool RollSuccess { get; set; }

    [Required]
    [JsonPropertyName("grades")]
    public required int Grades { get; set; }

}
