﻿using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class PaymentMethod
    {
        public PaymentMethod()
        {
            Invoices = new HashSet<Invoice>();
        }

        public int IdpaymentMethod { get; set; }
        public string PaymentMethodDescription { get; set; } = null!;

        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
