using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestPartialViewBinding.ViewModel;

namespace TestPartialViewBinding.Controllers
{
  public class PaymentController : Controller
  {

    public IActionResult CreatePayment()
    {
      PaymentViewModel payment = new PaymentViewModel()
      {
        Payment = 321,
        Description = "Regular 321"
      };

      payment.SplittedPayment.Add(new SplittedPaymentViewModel()
      {
        SplittedPaymentId = 0,
        Payment = 123,
        Description = "Partial 123"
      });

      payment.SplittedPayment.Add(new SplittedPaymentViewModel()
      {
        SplittedPaymentId = 1,
        Payment = 456,
        Description = "Partial 456"
      });

      return View("CreatePayment", payment);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult CreatePayment(PaymentViewModel model)
    {
      return View("CreatePayment", model);
    }

    public IActionResult SplittedPaymentPartial()
    {
      SplittedPaymentViewModel splittedPayment = new SplittedPaymentViewModel()
      {
        SplittedPaymentId = 1,
        Payment = 123,
        Description = "Partial 123"
      };

      return PartialView("SplittedPaymentPartial", splittedPayment);
    }
  }
}