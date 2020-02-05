using Empresa.Entities;
using Empresa.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa.Services
{
    class RentalService
    {
        public Double priceporHour { get; private set; }

        public Double priceporDay { get; private set; }

        public RentalService(double priceporHour, double priceporDay, ITaxService taxService)
        {
            this.priceporHour = priceporHour;
            this.priceporDay = priceporDay;
            _TaxService = taxService;
        }

        private ITaxService _TaxService;

        public void ProcessInvoice(CarRental carRental) {
            TimeSpan durancao = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;
            if(durancao.TotalHours <= 12.0)
            {
                basicPayment = priceporHour * Math.Ceiling(durancao.TotalHours);
            }
            else
            {
                basicPayment = priceporDay * Math.Ceiling(durancao.TotalDays);
            }

            double tax = _TaxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);

           
        }

    }
}
