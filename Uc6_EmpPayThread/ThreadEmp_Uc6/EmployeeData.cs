using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadEmp_Uc6
{



    public class EmployeeData
    {
        public int EmployeeID { get; set; }
        public double BasicPay { get; set; }
        public double Deductions { get; set; }
        public double TaxablePay { get; set; }
        public double Tax { get; set; }
        public double NetPay { get; set; }
        //UC 5
        public EmployeeData(int EmployeeID, double BasicPay, double Deductions, double TaxablePay, double Tax, double NetPay)
        {
            this.EmployeeID = EmployeeID;
            this.BasicPay = BasicPay;
            this.Deductions = Deductions;
            this.TaxablePay = TaxablePay;
            this.Tax = Tax;
            this.NetPay = NetPay;

        }

    }
}
