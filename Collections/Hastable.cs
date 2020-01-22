using System;
using System.Collections;
using CollectionLibrary;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Hastable:Employee
    {
       
            Hashtable Employee = new Hashtable();                  //create an hash table
            public void GetEmployeeList(int employeeNumber)
            {

                if (!Employee.Contains(employeeNumber))
                {
                    throw new Exception("Employee Name was not found");
                }
                else
                {
                    Console.WriteLine("Employee Detail of EmployeeID {0} is {1}", employeeNumber, Employee[employeeNumber]);
                }
            }
            public bool AddEmployeeData(Employee employee)
            {
               Employee.Add(employee.employeeNumber, employee.employeeName+" "+employee.employeeNumber );     //add a key and value
                return true;
            }
            public void DeleteKey(int index)
            {
                Console.WriteLine("Enter a removing key");                                                                                              //delete a key values
                employeeName.Remove(index);
                DisplayEmployeeHash();
            }
        public void AddEmployeeData1()
        {
            Console.WriteLine("Enter an Employee Name");
            string employeeName = Console.ReadLine();
            Console.WriteLine("Enter an Employee ID");
            int employeeNumber = int.Parse(Console.ReadLine());
            Employee employee = new Employee(employeeName, employeeNumber);
            bool status = AddEmployeeData(employee);
            if (status)
            {
                Console.WriteLine("Details Added Successfully");
            }
        }
        public void DisplayEmployeeHash()                                                                                                               //display
            {
                Console.WriteLine("Name    ID  ");
                foreach (DictionaryEntry employee in Employee)
                {
                    Console.Write(employee.Value);
                     //Console.Write(employee.Key);
            }
            }
        

    }
}
