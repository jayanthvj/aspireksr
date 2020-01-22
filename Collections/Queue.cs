using System;
using System.Collections;
using CollectionLibrary;
using System.IO;

namespace Collections
{
    class QueueFile : Employee
    {

        Queue queue = new Queue();
        public QueueFile()
        {
            Employee employee = new Employee("jayanth", 1);
            queue.Enqueue(employee);
        }
        public bool AddEmployee(Employee employee)
        {
            if (queue.Contains(employee))
                throw new MyException("This Employee is Present Already");
            queue.Enqueue(employee);
            return true;
        }
        public void AddEmployees()
        {
            Console.WriteLine("Enter an Employee Name");
            string employeeName = Console.ReadLine();
            Console.WriteLine("Enter an Employee ID");
            int employeeNumber = int.Parse(Console.ReadLine());
            Employee employee = new Employee(employeeName, employeeNumber);
            bool status = AddEmployee(employee);
            if (status)
            {
                Console.WriteLine("Details Added Successfully");
            }
        }

        public void DisplayEmployee()
        {
            foreach (Employee employee in queue)
            {
                Console.Write("Employee Name : " + employee.employeeName);
                Console.Write("Employee Number : " + employee.employeeNumber);
            }
        }
        public void ToRemove()
        {
            queue.Dequeue();
            Console.WriteLine("First employee removed");
        }
        public void ToPeek()
        {
            Employee employee = (Employee)queue.Peek();
            Console.Write("The First Value Present : ");
            Console.Write("Employee Name : " + employee.employeeName);
            Console.Write("Employee Number : " + employee.employeeNumber);
        }
    }
}
