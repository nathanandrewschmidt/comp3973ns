﻿using System;
using System.Collections.Generic;

namespace AspDb.Models.NW
{
    public partial class OrderSubtotals
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
