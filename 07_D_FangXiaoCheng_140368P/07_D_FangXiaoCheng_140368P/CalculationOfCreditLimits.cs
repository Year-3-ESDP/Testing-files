using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_D_FangXiaoCheng_140368P
{
    class CalculationOfCreditLimits
    {
        int individual=3, corporate=4, international=5;
        //null constructors 
        public CalculationOfCreditLimits()
        {
        }
        //method use to calculate the credit limits

        public float CalculateCreditLimit(string typecard, float salary)
        {
            if (typecard == "Individual")
            {
                return (individual * salary);
            }
            else if (typecard == "Corporate")
            {
                return (corporate * salary);
            }
            else { return (international * salary); }
        }

    }
}
