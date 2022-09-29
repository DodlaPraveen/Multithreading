using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadEmp_Uc6
{
    public class EmpPayRollService
    {

        public List<EmployeeData> PayrollDetailList = new List<EmployeeData>();

        //UC 5 without Thread
        public void addPayrollWithoutThread(List<EmployeeData> payrollDataList)
        {
            Console.WriteLine("\n Add Payroll WithOut Thread \n");

            payrollDataList.ForEach(payrollData =>
            {
                Stopwatch Time = new Stopwatch();
                Time.Start();
                Console.WriteLine("Payment Being Added  :" + payrollData.BasicPay + ", Employee Id : " + payrollData.EmployeeID + ", Deduction Added : " + payrollData.Deductions + " ,TaxablePay Added : " + payrollData.TaxablePay + ", Tax Added : " + payrollData.Tax + ", NetPay Added : " + payrollData.NetPay);
                this.addToPayroll(payrollData);
                Time.Stop();
                Console.WriteLine("Payment added : " + payrollData.BasicPay + ", Employee Id : " + payrollData.EmployeeID + ", Deduction Added : " + payrollData.Deductions + " ,TaxablePay Added : " + payrollData.TaxablePay + ", Tax Added : " + payrollData.Tax + ", NetPay Added : " + payrollData.NetPay + " ( Duration  : " + Time.Elapsed + ")");
            });
            Console.WriteLine(this.PayrollDetailList.ToString());
        }
        //UC 5, With Thread
        public void addPayrolllWithThread(List<EmployeeData> payrollDataList)
        {
            Console.WriteLine("\n Add Payroll With Thread \n");
            payrollDataList.ForEach(payrollData =>
            {
                Task thread = new Task(() =>
                {
                    Stopwatch Time = new Stopwatch();
                    Time.Start();

                    Console.WriteLine("Payment Being Added  : " + payrollData.BasicPay + ", Employee Id : " + payrollData.EmployeeID + ", Deduction Added : " + payrollData.Deductions + " ,TaxablePay Added : " + payrollData.TaxablePay + ", Tax Added : " + payrollData.Tax + ", NetPay Added : " + payrollData.NetPay);
                    this.addToPayroll(payrollData);
                    Time.Stop();
                    Console.WriteLine("Basic added : " + payrollData.BasicPay + ", Employee Id : " + payrollData.EmployeeID + ", Deduction Added : " + payrollData.Deductions + " ,TaxablePay Added : " + payrollData.TaxablePay + ", Tax Added : " + payrollData.Tax + ", NetPay Added : " + payrollData.NetPay + " ( Duration : " + Time.Elapsed + ")");
                });
                thread.Start();
            });
            Console.WriteLine(this.PayrollDetailList.Count);
        }

        public void addToPayroll(EmployeeData pay)
        {
            PayrollDetailList.Add(pay);
        }

        //UC 6 Update Payroll
        public void UpdatePayWithoutThread(List<EmployeeData> payroll)
        {
            Console.WriteLine("\n Update Without Thread \n");

            Stopwatch Time = new Stopwatch();
            var result = payroll.Select(p =>
            {
                if (p.EmployeeID == 1)
                {
                    Time.Start();
                    p.BasicPay = 28000;
                    p.Deductions = 300;
                    p.TaxablePay = 200;
                    p.Tax = 150;
                    p.NetPay = 27000;
                    Time.Stop();
                    Console.WriteLine("Duration : " + Time.Elapsed + " Employee Id : 1" + " Basic Pay : " + p.BasicPay + " Deductions : " + p.Deductions + " Taxable Pay : " + p.TaxablePay + " Tax" + p.Tax + " NetPay : " + p.NetPay);
                }
                else if (p.EmployeeID == 2)
                {
                    Time.Start();
                    p.BasicPay = 23000;
                    p.Deductions = 300;
                    p.TaxablePay = 200;
                    p.Tax = 150;
                    p.NetPay = 22000;
                    Time.Stop();
                    Console.WriteLine("Duration : " + Time.Elapsed + "Employee Id : 2" + " Basic Pay : " + p.BasicPay + " Deductions : " + p.Deductions + " Taxable Pay : " + p.TaxablePay + " Tax" + p.Tax + " NetPay : " + p.NetPay);

                }
                else if (p.EmployeeID == 3)
                {
                    Time.Start();
                    p.BasicPay = 24000;
                    p.Deductions = 300;
                    p.TaxablePay = 200;
                    p.Tax = 150;
                    p.NetPay = 24000;
                    Time.Stop();
                    Console.WriteLine("Duration : " + Time.Elapsed + "Employee Id : 3" + " Basic Pay : " + p.BasicPay + " Deductions : " + p.Deductions + " Taxable Pay : " + p.TaxablePay + " Tax" + p.Tax + " NetPay : " + p.NetPay);

                }
                else if (p.EmployeeID == 4)
                {
                    Time.Start();
                    p.BasicPay = 23000;
                    p.Deductions = 300;
                    p.TaxablePay = 200;
                    p.Tax = 150;
                    p.NetPay = 22000;
                    Time.Stop();
                    Console.WriteLine("Duration : " + Time.Elapsed + "Employee Id : 4" + " Basic Pay : " + p.BasicPay + " Deductions : " + p.Deductions + " Taxable Pay : " + p.TaxablePay + " Tax" + p.Tax + " NetPay : " + p.NetPay);

                }
                else if (p.EmployeeID == 5)
                {
                    Time.Start();
                    p.BasicPay = 34000;
                    p.Deductions = 300;
                    p.TaxablePay = 200;
                    p.Tax = 150;
                    p.NetPay = 33000;
                    Time.Stop();
                    Console.WriteLine("Duration : " + Time.Elapsed + "Employee Id : 5" + " Basic Pay : " + p.BasicPay + " Deductions : " + p.Deductions + " Taxable Pay : " + p.TaxablePay + " Tax" + p.Tax + " NetPay : " + p.NetPay);

                }
                else if (p.EmployeeID == 6)
                {
                    Time.Start();
                    p.BasicPay = 3000;
                    p.Deductions = 300;
                    p.TaxablePay = 200;
                    p.Tax = 150;
                    p.NetPay = 2000;
                    Time.Stop();
                    Console.WriteLine("Duration : " + Time.Elapsed + "Employee Id : 6" + " Basic Pay : " + p.BasicPay + " Deductions : " + p.Deductions + " Taxable Pay : " + p.TaxablePay + " Tax" + p.Tax + " NetPay : " + p.NetPay);

                }
                else if (p.EmployeeID == 7)
                {
                    Time.Start();
                    p.BasicPay = 15000;
                    p.Deductions = 300;
                    p.TaxablePay = 200;
                    p.Tax = 150;
                    p.NetPay = 14000;
                    Console.WriteLine("Duration : " + Time.Elapsed + "Employee Id : 7" + " Basic Pay : " + p.BasicPay + " Deductions : " + p.Deductions + " Taxable Pay : " + p.TaxablePay + " Tax" + p.Tax + " NetPay : " + p.NetPay);

                }
                else if (p.EmployeeID == 8)
                {
                    Time.Start();
                    p.BasicPay = 13000;
                    p.Deductions = 300;
                    p.TaxablePay = 200;
                    p.Tax = 150;
                    p.NetPay = 12000;
                    Time.Stop();
                    Console.WriteLine("Duration : " + Time.Elapsed + "Employee Id : 8" + " Basic Pay : " + p.BasicPay + " Deductions : " + p.Deductions + " Taxable Pay : " + p.TaxablePay + " Tax" + p.Tax + " NetPay : " + p.NetPay);

                }
                else if (p.EmployeeID == 9)
                {
                    Time.Start();
                    p.BasicPay = 34000;
                    p.Deductions = 300;
                    p.TaxablePay = 200;
                    p.Tax = 150;
                    p.NetPay = 33000;
                    Time.Stop();

                    Console.WriteLine("Duration : " + Time.Elapsed + "Employee Id : 9" + " Basic Pay : " + p.BasicPay + " Deductions : " + p.Deductions + " Taxable Pay : " + p.TaxablePay + " Tax" + p.Tax + " NetPay : " + p.NetPay);

                }
                else if (p.EmployeeID == 10)
                {
                    Time.Start();
                    p.BasicPay = 44000;
                    p.Deductions = 300;
                    p.TaxablePay = 200;
                    p.Tax = 150;
                    p.NetPay = 43000;
                    Time.Stop();
                    Console.WriteLine("Duration : " + Time.Elapsed + "Employee Id : 10" + " Basic Pay : " + p.BasicPay + " Deductions : " + p.Deductions + " Taxable Pay : " + p.TaxablePay + " Tax" + p.Tax + " NetPay : " + p.NetPay);

                }
                return p;
            }).ToList();

        }
        //UC With Update With Thread
        public void UpdatePayWithThread(List<EmployeeData> payroll)
        {
            Console.WriteLine("\n Update With Thread \n");
            payroll.ForEach(payrollData =>
            {
                Task thread1 = new Task(() =>
                {
                    Stopwatch Time = new Stopwatch();
                    Time.Start();
                    var result = payroll.Select(p =>
                    {
                        if (p.EmployeeID == 1)
                        {
                            p.BasicPay = 48000;
                            p.Deductions = 300;
                            p.TaxablePay = 200;
                            p.Tax = 150;
                            p.NetPay = 47000;
                            Console.WriteLine("Employee Id : 1" + " Basic Pay : " + p.BasicPay + " Deductions : " + p.Deductions + " Taxable Pay : " + p.TaxablePay + " Tax" + p.Tax + " NetPay : " + p.NetPay);


                        }
                        else if (p.EmployeeID == 2)
                        {
                            p.BasicPay = 53000;
                            p.Deductions = 300;
                            p.TaxablePay = 200;
                            p.Tax = 150;
                            p.NetPay = 52000;
                            Console.WriteLine("Employee Id : 2" + " Basic Pay : " + p.BasicPay + " Deductions : " + p.Deductions + " Taxable Pay : " + p.TaxablePay + " Tax" + p.Tax + " NetPay : " + p.NetPay);

                        }
                        else if (p.EmployeeID == 3)
                        {
                            p.BasicPay = 64000;
                            p.Deductions = 300;
                            p.TaxablePay = 200;
                            p.Tax = 150;
                            p.NetPay = 63000;
                            Console.WriteLine("Employee Id : 3" + " Basic Pay : " + p.BasicPay + " Deductions : " + p.Deductions + " Taxable Pay : " + p.TaxablePay + " Tax" + p.Tax + " NetPay : " + p.NetPay);

                        }
                        else if (p.EmployeeID == 4)
                        {
                            p.BasicPay = 73000;
                            p.Deductions = 300;
                            p.TaxablePay = 200;
                            p.Tax = 150;
                            p.NetPay = 72000;
                            Console.WriteLine("Employee Id : 4" + " Basic Pay : " + p.BasicPay + " Deductions : " + p.Deductions + " Taxable Pay : " + p.TaxablePay + " Tax" + p.Tax + " NetPay : " + p.NetPay);

                        }
                        else if (p.EmployeeID == 5)
                        {
                            p.BasicPay = 34000;
                            p.Deductions = 300;
                            p.TaxablePay = 200;
                            p.Tax = 150;
                            p.NetPay = 33000;
                            Console.WriteLine("Employee Id : 5" + " Basic Pay : " + p.BasicPay + " Deductions : " + p.Deductions + " Taxable Pay : " + p.TaxablePay + " Tax" + p.Tax + " NetPay : " + p.NetPay);

                        }
                        else if (p.EmployeeID == 6)
                        {
                            p.BasicPay = 3500;
                            p.Deductions = 300;
                            p.TaxablePay = 200;
                            p.Tax = 150;
                            p.NetPay = 34000;
                            Console.WriteLine("Employee Id : 6" + " Basic Pay : " + p.BasicPay + " Deductions : " + p.Deductions + " Taxable Pay : " + p.TaxablePay + " Tax" + p.Tax + " NetPay : " + p.NetPay);

                        }
                        else if (p.EmployeeID == 7)
                        {
                            p.BasicPay = 105000;
                            p.Deductions = 300;
                            p.TaxablePay = 200;
                            p.Tax = 150;
                            p.NetPay = 104000;
                            Console.WriteLine("Employee Id : 7" + " Basic Pay : " + p.BasicPay + " Deductions : " + p.Deductions + " Taxable Pay : " + p.TaxablePay + " Tax" + p.Tax + " NetPay : " + p.NetPay);


                        }
                        else if (p.EmployeeID == 8)
                        {
                            p.BasicPay = 123000;
                            p.Deductions = 300;
                            p.TaxablePay = 200;
                            p.Tax = 150;
                            p.NetPay = 122000;
                            Console.WriteLine("Employee Id : 8" + " Basic Pay : " + p.BasicPay + " Deductions : " + p.Deductions + " Taxable Pay : " + p.TaxablePay + " Tax" + p.Tax + " NetPay : " + p.NetPay);

                        }
                        else if (p.EmployeeID == 9)
                        {
                            p.BasicPay = 324000;
                            p.Deductions = 300;
                            p.TaxablePay = 200;
                            p.Tax = 150;
                            p.NetPay = 323000;
                            Console.WriteLine("Employee Id : 9" + " Basic Pay : " + p.BasicPay + " Deductions : " + p.Deductions + " Taxable Pay : " + p.TaxablePay + " Tax" + p.Tax + " NetPay : " + p.NetPay);

                        }
                        else if (p.EmployeeID == 10)
                        {
                            p.BasicPay = 424000;
                            p.Deductions = 300;
                            p.TaxablePay = 200;
                            p.Tax = 150;
                            p.NetPay = 423000;
                            Console.WriteLine("Employee Id : 10" + " Basic Pay : " + p.BasicPay + " Deductions : " + p.Deductions + " Taxable Pay : " + p.TaxablePay + " Tax" + p.Tax + " NetPay : " + p.NetPay);

                        }
                        return p;
                    });

                });
                thread1.Start();
            });
        }
    }
}
