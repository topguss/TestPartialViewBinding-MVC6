using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestPartialViewBinding.ViewModel
{
  public class PaymentViewModel
  {
    public PaymentViewModel()
    {
      SplittedPayment = new List<SplittedPaymentViewModel>();
    }

    public decimal? Payment { get; set; }

    [StringLength(10, MinimumLength = 1)]
    public string Description { get; set; }

    public List<SplittedPaymentViewModel> SplittedPayment { get; set; }
  }

  public class SplittedPaymentViewModel
  {
    public short SplittedPaymentId { get; set; }

    public decimal? Payment { get; set; }

    [StringLength(20, MinimumLength = 2)]
    public string Description { get; set; }
  }
}
