using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Wh40kCharacterList.Core.DiceRolls;
using Wh40kCharacterList.Core.DiceRolls.RollResults;
using Wh40kCharacterList.WebApi.Services;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class DiceController : ControllerBase
{
    private readonly DiceService _diceService;
    public DiceController(DiceService diceService)
    {
        _diceService = diceService;
    }

    [HttpPost("roll/skill-check")]
    [ProducesResponseType(typeof(SkillCheckRollResult), StatusCodes.Status200OK)]
    public async Task<IActionResult> RollSkillCheck([FromBody] SkillCheckRoll request)
    {
        return Ok(await _diceService.RollSkillCheck(request));
    }
}
