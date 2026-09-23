using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wh40kCharacterList.Core.NetworkDtos;


public record LoginRequest(string UserName, string Password);
