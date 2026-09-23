using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Wh40kCharacterList.Core.DiceRolls;
using Wh40kCharacterList.Core.DiceRolls.RollResults;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class DiceController : ControllerBase
{
    public DiceController()
    {
    }

    [HttpPost("roll/skill-check")]
    [ProducesResponseType(typeof(SkillCheckRollResult), StatusCodes.Status200OK)]
    public async Task<IActionResult> RollSkillCheck([FromBody] SkillCheckRoll request)
    {
        Random random = new();
        request.Roll(random);
        return Ok(request.RollResult);
    }
}
