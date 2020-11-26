using System;

namespace coinbaseapi.Models
{
    public class Price
    {
        public float Value { get; set; }
        public DateTime Date { get; set; }
        public String Currency { get; set; }
    }
}
