using System;
using System.Collections;
using System.Linq;
using CollectionLibrary;
using System.Threading.Tasks;

namespace Collections
{
    class Sortedlist : Employee
    {

        SortedList Employee = new SortedList();                  //create an hash table
        public void GetEmployeeList(int employeeNumber)
        {

            if (!Employee.Contains(employeeNumber))
            {
                throw new Exception("Employee Name was not found");
            }
            else
            {
                Console.WriteLine("Employee Detail of EmployeeID {0} is {1}\n", employeeNumber, Employee[employeeNumber]);
            }
        }
        public bool AddSortedEmployeeData(Employee employee)
        {
            Employee.Add(employee.employeeNumber, employee.employeeName + " " + employee.employeeNumber);     //add a key and value
            return true;
        }
        public void DeleteSortedKey(int index)
        {
            Console.WriteLine("Enter a removing key");                                                                                              //delete a key values
            employeeName.Remove(index);
            DisplaySortedEmployeeHash();
        }
        public void AddSortedEmployeeData()
        {
            Console.WriteLine("Enter an Employee Name");
            string employeeName = Console.ReadLine();
            Console.WriteLine("Enter an Employee ID");
            int employeeNumber = int.Parse(Console.ReadLine());
            Employee employee = new Employee(employeeName, employeeNumber);
            bool status = AddSortedEmployeeData(employee);
            if (status)
            {
                Console.WriteLine("Details Added Successfully");
            }
        }
        public void DisplaySortedEmployeeHash()                                                                                                               //display
        {
            foreach (DictionaryEntry employee in Employee)
            {
                Console.Write(employee.Value+"\n");
                //Console.Write(employee.Key);
            }
        }


    }
}
