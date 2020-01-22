using System;
using System.Collections;
using CollectionLibrary;
namespace Collections
{
    class StackFile : Employee
    {
        Stack stack = new Stack();
        public StackFile()
        {
            Employee employee = new Employee("jayanth", 1);
            stack.Push(employee);
        }
        public bool AddEmployee(Employee employee)
        {
            if (stack.Contains(employee))
                throw new MyException("This Employee is Present Already");
            stack.Push(employee);
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
            foreach (Employee employee in stack)
            {
                Console.Write("Employee Name : " + employee.employeeName);
                Console.Write("Employee Number : " + employee.employeeNumber);
            }
        }
        public void ToRemove()
        {
            stack.Pop();
            Console.Write("Last employee removed");
        }
        public void ToPeek()
        {
            Employee employee = (Employee)stack.Peek();
            Console.Write("The Last Value Present : ");
            Console.Write("Employee Name : " + employee.employeeName);
            Console.Write("Employee Number : " + employee.employeeNumber);
        }
    }
}