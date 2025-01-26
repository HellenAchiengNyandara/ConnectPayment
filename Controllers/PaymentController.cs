using Microsoft.AspNetCore.Mvc;

namespace ConnectUs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        // POST api/payment/submit
        [HttpPost("submit")]
        public IActionResult SubmitPaymentRequest([FromBody] PaymentRequest request)
        {
            // Logic to process the payment request
            return Ok(new { Message = $"Payment request submitted for {request.Amount} {request.Currency} to {request.PhoneNumber}." });
        }

        // GET api/payment/status/{referenceId}
        [HttpGet("status/{referenceId}")]
        public IActionResult CheckTransactionStatus(string referenceId)
        {
            // Logic to check transaction status
            return Ok(new { Message = $"Transaction status for {referenceId}." });
        }
    }

    // Model to bind payment request data
    public class PaymentRequest
    {
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string PhoneNumber { get; set; }
        public string PayerMessage { get; set; }
        public string PayeeNote { get; set; }
    }
}
