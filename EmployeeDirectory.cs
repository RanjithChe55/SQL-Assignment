using Baseclass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Employee_Management

{
    internal class program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Console.Write("Enter the EmpNO:");
            emp.empno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the EmpName:");
            emp.empname = Console.ReadLine();
            Console.Write("Enter the EmpNetSalry:");
            emp.empsalry = Convert.ToDouble(Console.ReadLine());
            emp.CalculateSalary();
            Console.WriteLine(emp.empnetsalry);
            Console.ReadLine();
        }
    }

}
