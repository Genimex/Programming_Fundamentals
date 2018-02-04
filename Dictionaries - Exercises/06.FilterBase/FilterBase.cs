using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterBase
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            Dictionary<string,int> age = new Dictionary<string, int>();
            Dictionary<string,decimal> salary = new Dictionary<string, decimal>();
            Dictionary<string,string> position = new Dictionary<string, string>();

            while (input[0] != "filter")
            {
                string name = input[0];
                string dataStore = input[2];

                int employeeAge = 0;
                decimal employeeSalary = 0m;

                if (int.TryParse(dataStore,out employeeAge))
                {
                    if (!age.ContainsKey(name))
                    {
                        age[name] = 0;
                    }
                    age[name] = employeeAge;
                }
                else if (decimal.TryParse(dataStore,out employeeSalary))
                {
                    if (!salary.ContainsKey(name))
                    {
                        salary[name] = 0m;
                    }
                    salary[name] = employeeSalary;
                }
                else
                {
                    if (!position.ContainsKey(name))
                    {
                        position[name] = String.Empty;
                    }
                    position[name] = dataStore;
                }
                input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            if (input[0] == "Position")
            {
                foreach (KeyValuePair<string,string> data in position)
                {
                    Console.WriteLine($"Name: {data.Key}");
                    Console.WriteLine($"Position: {data.Value}");
                    Console.WriteLine("{0}",new string('=',20));
                }
            }
            else if (input[0] == "Age")
            {
                foreach (KeyValuePair<string,int> data in age)
                {
                    Console.WriteLine($"Name: {data.Key}");
                    Console.WriteLine($"Age: {data.Value}");
                    Console.WriteLine("{0}", new string('=', 20));
                }
            }
            else if (input[0] == "Salary")
            {
                foreach (KeyValuePair<string,decimal> data in salary)
                {
                    Console.WriteLine($"Name: {data.Key}");
                    Console.WriteLine($"Salary: {data.Value}");
                    Console.WriteLine("{0}", new string('=', 20));
                }
            }
        }
    }
}
