namespace DecoratorDisaster;

internal class Decorator(ILogger<Decorator> logger, IService service) : IServiceOne, IServiceTwo
{
    public string GetData()
    {
        var data = service.GetData();
        
        logger.LogInformation("Getting data from service. Data: {Data}", data);

        return data;
    }
}