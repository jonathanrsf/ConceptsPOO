using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsPOO
{
    class CommissionEmployee : Employee
    {
        public float CommissionPercentaje { get; set; }
        public decimal Sales { get; set; }

        public override decimal GetValueToPay()
        {
            return Sales * (decimal)CommissionPercentaje;
        }

        public override string ToString()
        {
            return $"{base.ToString()} \n" +
                $"\tCommision percentaje : {$"{CommissionPercentaje:P2}",20} \n" +
                $"\tSales................: {$"{Sales:C2}",20} \n" +
                $"\tValue to pay.........: {$"{GetValueToPay():C2}",20}";
        }
    }
}
