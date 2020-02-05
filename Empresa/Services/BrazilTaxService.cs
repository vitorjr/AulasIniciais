using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa.Services
{
    class BrazilTaxService : ITaxService
    {
        public Double Tax(double amount)
        {
            if(amount <= 100) { return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }

        }
    }
}
