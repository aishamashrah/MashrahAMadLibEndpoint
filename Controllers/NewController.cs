using Microsoft.AspNetCore.Mvc;

namespace MashrahAMadLibEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class NewController : ControllerBase
{
   [HttpGet]
    [Route("MiniCh5")]

    public string MadLib()
    {
        return " You will be asked  questions andthat will make a story";
    }
}
