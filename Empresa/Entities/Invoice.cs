using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Empresa.Entities
{
    class Invoice
    {
        public Double BasicPayment { get; set; }
        public Double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public Double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            return "Invoice:" +
                "Basic payment: "+BasicPayment.ToString("F2",CultureInfo.InvariantCulture)+
                "Tax: "+Tax+
                "Total payment: "+TotalPayment;
        }
    }
}
