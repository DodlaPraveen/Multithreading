using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadEmp_Uc6
{
    public class EmpModal
    {

        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public char Gender { get; set; }

        public string City { get; set; }
        public string Country { get; set; }

        public EmpModal(int EmployeeID, string EmployeeName, string PhoneNumber, string Address, string Department, char Gender, string City, string Country)
        {
            this.EmployeeID = EmployeeID;
            this.EmployeeName = EmployeeName;
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
            this.Department = Department;
            this.Gender = Gender;
            this.City = City;
            this.Country = Country;

        }
    }
}
