using System.Numerics;
using Microsoft.AspNetCore.Mvc;
using Pollful.Tools;

namespace Pollful.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FunController : ControllerBase 
{
    
    [HttpGet]
    public ActionResult<string> GetFactorial(int N)
    {
        return Ok(MathStuff.Factorial(N));
    }
}