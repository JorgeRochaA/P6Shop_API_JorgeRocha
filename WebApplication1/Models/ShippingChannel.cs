﻿using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class ShippingChannel
    {
        public ShippingChannel()
        {
            Shippings = new HashSet<Shipping>();
        }

        public int IdshippingChannel { get; set; }
        public string ShippingChannelDescription { get; set; } = null!;

        public virtual ICollection<Shipping> Shippings { get; set; }
    }
}
