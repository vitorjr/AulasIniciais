using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa
{
    class OutsourcerEmployee : Employee
    {
        public Double AdditionalCharge { get; set; }

        public OutsourcerEmployee(int id, string name, double salary, double additionalCharge) : base (id,name,salary)
        {
            AdditionalCharge = additionalCharge;
        }

        public OutsourcerEmployee(string name, int hours, double valueporhours, double additionalCharge) : base(name, hours, valueporhours)
        {
            AdditionalCharge = additionalCharge;
        }

        public OutsourcerEmployee() { }

        public override double Payment()
        {
            Double adicional = AdditionalCharge * 1.1;
            return base.Payment() + adicional;
        }
    }
}
