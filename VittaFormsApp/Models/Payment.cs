using System;
using System.Collections.Generic;

namespace VittaFormsApp.Models;

public partial class Payment
{
    public int IdPayment { get; set; }

    public int OrderId { get; set; }

    public int ReceiptMoneyId { get; set; }

    public decimal Amount { get; set; }
}
