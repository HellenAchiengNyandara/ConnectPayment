using Microsoft.AspNetCore.Mvc;

namespace ConnectUs.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RequestPaymentForm()
        {
            return View();
        }

     
        [HttpPost]
        public IActionResult SubmitPaymentRequest(decimal amount, string currency, string phoneNumber, string payerMessage, string payeeNote)
        {
         
            ViewBag.Message = $"Payment request submitted successfully for {amount} {currency} to {phoneNumber}.";
            return View("Response");
        }

        public IActionResult CheckTransactionStatusForm()
        {
            return View();
        }

      
        [HttpGet]
        public IActionResult SubmitTransactionStatus(string referenceId)
        {
           
            ViewBag.Message = $"Transaction status for Reference ID {referenceId} checked successfully.";
            return View("Response");
        }
    }
}
