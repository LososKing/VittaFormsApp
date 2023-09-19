using System;
using System.Collections.Generic;

namespace VittaFormsApp.Models;

public partial class Order
{
    public int IdOrder { get; set; }

    public DateTime Date { get; set; }

    public decimal Amount { get; set; }

    public decimal? PaymentAmount { get; set; }
    public decimal NeedToPay
    {
        get { return (decimal)(Amount - PaymentAmount); }
    }

}
