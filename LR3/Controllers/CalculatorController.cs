using LR3.Services;
using Microsoft.AspNetCore.Mvc;

namespace LR3.Controllers
{
    public class ArithmeticRequest
    {
        public int A { get; set; }
        public int B { get; set; }
    }

    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly CalcService _calcService;

        public CalculatorController(CalcService calcService)
        {
            _calcService = calcService;
        }

        [HttpGet("add")]
        public ActionResult<int> Add(int a, int b)
        {
            return _calcService.Add(a, b);
        }

        [HttpGet("subtract")]
        public ActionResult<int> Subtract(int a, int b)
        {
            return _calcService.Subtract(a, b);
        }

        [HttpGet("multiply")]
        public ActionResult<int> Multiply(int a, int b)
        {
            return _calcService.Multiply(a, b);
        }

        [HttpGet("divide")]
        public ActionResult<int> Divide(int a, int b)
        {
            return _calcService.Divide(a, b);
        }

        [HttpPost("add")]
        public ActionResult<int> Add([FromBody] ArithmeticRequest request)
        {
            return _calcService.Add(request.A, request.B);
        }
    }
}