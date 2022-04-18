using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1
{
    public class Employee

    {
        private int EmpNO;
        private string EmpName;
        private double Salary;
        private double HRA;
        private double TA;
        private double DA;
        private double PF;
        private double TDS;
        private double NetSalary;
        private double GrossSalary;

        public int empno
        {
            get
            {
                return EmpNO;
            }
            set
            {
                EmpNO = value;
            }
        }
        public string empname
        {
            get
            {
                return EmpName;
            }
            set
            {
                EmpName = value;
            }
        }
        public double empsalry
        {
            get
            {
                return Salary;
            }
            set
            {
                Salary = value;
            }

        }
        public double empnetsalry
        {
            get
            {
                return NetSalary;
            }
            set
            {
                NetSalary = value;
            }

        }



        public void CalculateSalary()
        {
            if (Salary < 5000)
            {
                HRA = (Salary * 10) / 100;
                TA = (Salary * 5) / 100;
                DA = (Salary * 15) / 100;
            }
            else if (Salary >= 5000 && Salary < 10000)
            {
                HRA = (Salary * 15) / 100;
                TA = (Salary * 10) / 100;
                DA = (Salary * 20) / 100;
            }
            else if (Salary >= 10000 && Salary < 15000)
            {
                HRA = (Salary * 20) / 100;
                TA = (Salary * 15) / 100;
                DA = (Salary * 25) / 100;
            }
            else if (Salary >= 15000 && Salary < 20000)
            {
                HRA = (Salary * 25) / 100;
                TA = (Salary * 20) / 100;
                DA = (Salary * 30) / 100;
            }
            else if (Salary >= 20000)
            {
                HRA = (Salary * 30) / 100;
                TA = (Salary * 25) / 100;
                DA = (Salary * 35) / 100;
            }
            GrossSalary = Salary + HRA + TA + DA;
            PF = (GrossSalary * 10) / 100;
            TDS = (GrossSalary * 18) / 100;
            NetSalary = GrossSalary - (PF + TDS);

        }

    }

}
