// Isaiah Keith Ferguson
//10/25/2022
//Say Hello End Point Challenge
//Getting the user input to say hello
//reviewed by:



using Microsoft.AspNetCore.Mvc;

namespace FergusonISayHelloEndPoints.Controllers;

[ApiController]
[Route("[controller]")]
public class SayHelloController : ControllerBase
{
    [HttpGet]
    [Route("Hello/{name}")]

    public string SayHello(string name)
    {
        return $"Hello, {name} nice to meet you";
    }
}