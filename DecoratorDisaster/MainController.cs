using Microsoft.AspNetCore.Mvc;

namespace DecoratorDisaster;

[ApiController]
public sealed class MainController(IServiceOne serviceOne, IServiceTwo serviceTwo) : ControllerBase
{
    [HttpGet("One")]
    public string GetFromServiceOne() => serviceOne.GetData();

    [HttpGet("Two")]
    public string GetFromServiceTwo() => serviceTwo.GetData();
}