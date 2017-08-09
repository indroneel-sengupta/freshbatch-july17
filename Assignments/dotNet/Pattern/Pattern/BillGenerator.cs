using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    class BillGenerator
    {
        public void CalBill()
        {
            Console.WriteLine(" Please enter customer Id, Customer Name And Units Consumed");
            int cId = Convert.ToInt32(Console.ReadLine());
            string cName = Console.ReadLine();
            int cUnits = Convert.ToInt32(Console.ReadLine());
            double uPrice = 0;
            double bill;
            double surCharge = 0;
            if (cUnits < 200)
            {
                uPrice = 1.20;
            }else
            {
                if (cUnits >= 200 && cUnits <400)
                {
                    uPrice = 1.50;
                }
                if (cUnits >= 400 && cUnits < 600)
                {
                    uPrice = 1.80;
                }
                if (cUnits >= 600)
                {
                    uPrice = 2.0;
                }

            }

            bill = cUnits * uPrice;
            if (bill > 400)
            {
                surCharge = (bill * 0.15);
            }
            else
            {
                if (bill < 100) bill = 100;
            }

            Console.WriteLine("Customer IDNO : "+cId);
            Console.WriteLine("Customer Name : " + cName);
            Console.WriteLine("Units Consumed : " + cUnits);
            Console.WriteLine("Amount charged @Rs. {0} per unit : {1}",uPrice,bill);
            Console.WriteLine("Surcharge Amount : " + surCharge);
            Console.WriteLine("Net Amount Paid By the Customer : " + (surCharge+bill));

        }

    }
}
