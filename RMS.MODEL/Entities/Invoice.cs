﻿using infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Model.Entities
{
    public class Invoice : IEntity
    {
        public int InvoiceID { get; set; }
        public int? CustomerID { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public decimal? TotalAmount { get; set; }
        public Customer? Customer { get; set; }

        public bool? IsActive { get; set; }
    }
}
