using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_fundamentals
{
    class DifferentInputs
    {
        static void Main(string[] args)
        {

            int Employeecode;
            string Employeename;
            float Employeesalary;
            double Employeecontact;
            bool isfresher;

            Console.Write("Entername: ");
            Employeename = Console.ReadLine();
            Console.Write("Enter code: ");
            Employeecode = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter salary:");
            Employeesalary = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter contact number: ");
            Employeecontact = Convert.ToDouble(Console.ReadLine());
            Console.Write("are you fresher ");
            isfresher = Convert.ToBoolean(Console.ReadLine());


            Console.WriteLine("Employee code : " + Employeecode);
            Console.WriteLine("Employee name: " + Employeename);
            Console.WriteLine("Employee salary : " + Employeesalary);
            Console.WriteLine("Employee contact: " + Employeecontact);
            Console.WriteLine("Are you fresher:" + isfresher);



        }
    }
}

