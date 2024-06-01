﻿namespace LAB11CoreMvc.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public DateTime Date { get; set; }
        public string InvoiceNumber { get; set; }
        public float Total { get; set; }

        public Customer? Customer { get; set; }
        public int CustomerId { get; set; }
    }
}
