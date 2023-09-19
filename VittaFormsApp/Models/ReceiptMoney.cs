using System;
using System.Collections.Generic;

namespace VittaFormsApp.Models;

public partial class ReceiptMoney
{
    public int IdReceiptMoney { get; set; }

    public DateTime Date { get; set; }

    public decimal Amount { get; set; }

    public decimal? Balance { get; set; }
}
