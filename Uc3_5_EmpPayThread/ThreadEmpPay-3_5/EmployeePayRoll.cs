using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadEmpPay_3_5
{
    public class EmployeePayRoll
    {
        public List<EmpData> employeePayDetailList = new List<EmpData>();


        //UC 1,3
        public void addEmployeeToPayroll(List<EmpData> employeePayrollDataList)
        {
            employeePayrollDataList.ForEach(employeeData =>
            {
                Stopwatch Time = new Stopwatch();
                Time.Start();
                Console.WriteLine("Employee Being Added  :" + employeeData.EmployeeName);
                this.addEmployeeToPayroll(employeeData);
                Time.Stop();
                Console.WriteLine("Employee added : " + employeeData.EmployeeName + " ( Duration  : " + Time.Elapsed + ")");
            });
            Console.WriteLine(this.employeePayDetailList.ToString());
        }
        //UC 2,3
        public void addEmployeeToPayrollWithThread(List<EmpData> employeePayrollDataList)
        {
            employeePayrollDataList.ForEach(employeeData =>
            {
                Task thread = new Task(() =>
                {
                    Stopwatch Time = new Stopwatch();
                    Time.Start();

                    Console.WriteLine("Employee Being Added :" + employeeData.EmployeeName);
                    this.addEmployeeToPayroll(employeeData);
                    Time.Stop();
                    Console.WriteLine("Employee added : " + employeeData.EmployeeName + " ( Duration : " + Time.Elapsed + ")");
                });
                thread.Start();
            });
            Console.WriteLine(this.employeePayDetailList.Count);
        }
        public void addEmployeeToPayroll(EmpData emp)
        {
            employeePayDetailList.Add(emp);

        }
    }
}
