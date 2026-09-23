using Microsoft.AspNetCore.Mvc;
using Wh40kCharacterList.Core.DiceRolls;
using Wh40kCharacterList.Core.DiceRolls.RollResults;

namespace Wh40kCharacterList.WebApi.Services;

public class DiceService
{
    private readonly ILogger<DiceService> _logger;

    private readonly Random _random = new();

    public DiceService(ILogger<DiceService> logger)
    {
        _logger = logger;
    }

    public async Task<SkillCheckRollResult?> RollSkillCheck(SkillCheckRoll request)
    {
        request.Roll(_random);
        return request.RollResult;
    }
}
