using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadEmp_Uc6
{
    public class EmpPayRollUpdate
    {

        public List<EmpModal> employeePayDetailList = new List<EmpModal>();


        //UC 1,3
        public void addEmployeeToPayroll(List<EmpModal> employeePayrollDataList)
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
        public void addEmployeeToPayrollWithThread(List<EmpModal> employeePayrollDataList)
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
        public void addEmployeeToPayroll(EmpModal emp)
        {
            employeePayDetailList.Add(emp);

        }

    }
}
