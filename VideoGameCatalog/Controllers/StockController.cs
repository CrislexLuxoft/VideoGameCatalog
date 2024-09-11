using Microsoft.AspNetCore.Mvc;

[Route("/try")]
public class StockController : ControllerBase{
    private readonly ILogger<StockController> _logger;

    public StockController(ILogger<StockController> logger){
        _logger = logger;
    }

    [HttpGet]
    public ActionResult Hello(){
        return Ok("Hello World");
    }
}