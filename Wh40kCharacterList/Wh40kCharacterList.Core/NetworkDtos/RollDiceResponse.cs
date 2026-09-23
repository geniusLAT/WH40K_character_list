using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Wh40kCharacterList.Core.DiceRolls;

namespace Wh40kCharacterList.Core.NetworkDtos;

public class RollDiceResponse
{
    [Required]
    [JsonPropertyName("roll-dice")]
    public required RollDice RollDice { get; set; }
}
