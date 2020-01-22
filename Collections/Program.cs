using System;
namespace Collections
{
    class EmployeeHub
    {
        //public void ToArrayList()
        //{
        //    start:
        //    try
        //    {
        //        ArrayListCollection company = new ArrayListCollection();
        //        Console.WriteLine("*********************Welcome to ArrayList Page*************************");
        //        Console.WriteLine("Enter your choice\n1.Add\n2.View Details\n3.Check\n4.Remove\n5.Exit");
        //        int choice = int.Parse(Console.ReadLine());
        //        do
        //        {
        //            switch (choice)
        //            {
        //                case 1:
        //                    AddEmployees();
        //                    break;
        //                case 2:
        //                    company.DisplayEmployee();
        //                    break;
        //                case 3:
        //                    Console.WriteLine("Enter an Employee ID");
        //                    int employeeID = int.Parse(Console.ReadLine());
        //                    company.GetEmployee(employeeID);
        //                    break;
        //                case 4:
        //                    Console.WriteLine("Enter an Employee ID");
        //                    int employeeNumbers = int.Parse(Console.ReadLine());
        //                    company.toRemove(employeeNumbers);
        //                    break;
        //                case 5:
        //                    ToControl();
        //                    break;
        //            }
        //            Console.WriteLine("*********************Welcome to ArrayList Page*************************");
        //            Console.WriteLine("Enter your choice\n1.Add\n2.View Details\n3.Check\n4.Remove\n5.Exit");
        //            choice = int.Parse(Console.ReadLine());
        //        } while (choice != 6);
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //        FileLogger.Feed(e.Message);
        //        goto start;
        //    }
      //  }
        public void ToStack()
        {
            start:
            try
            {
                StackFile stackCollection = new StackFile();
                Console.WriteLine("*********************Welcome to Stack Page*************************");
                Console.WriteLine("Enter your choice\n1.Add Details\n2.View Details\n3.Remove Last Value \n4.Show Last Value\n5.Exit");
                int option = int.Parse(Console.ReadLine());
                do
                {
                    switch (option)
                    {
                        case 1:
                            stackCollection.AddEmployees();
                            break;
                        case 2:
                            stackCollection.DisplayEmployee();
                            break;
                        case 3:
                            stackCollection.ToRemove();
                            break;
                        case 4:
                            stackCollection.ToPeek();
                            break;
                        case 5:
                            ToControl();
                            break;
                    }
                    Console.WriteLine("*********************Welcome to Stack Page*************************");
                    Console.WriteLine("Enter your choice\n1.Add Details\n2.View Details\n3.Remove Last Value \n4.Show Last Value\n5.Exit");
                    option = int.Parse(Console.ReadLine());
                } while (option != 6);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                FileLogger.Feed(e.Message);
                goto start;
            }
        }
        public void ToQueue()
        {
            start:
            try
            {
                QueueFile queueCollection = new QueueFile();
                Console.WriteLine("*********************Welcome to Queue Page*************************");
                Console.WriteLine("Enter your choice\n1.Add Details\n2.View Details\n3.Remove First Value \n4.Show First Value\n5.Exit");
                int option = int.Parse(Console.ReadLine());
                do
                {
                    switch (option)
                    {
                        case 1:
                            queueCollection.AddEmployees();
                            break;
                        case 2:
                            queueCollection.DisplayEmployee();
                            break;
                        case 3:
                            queueCollection.ToRemove();
                            break;
                        case 4:
                            queueCollection.ToPeek();
                            break;
                        case 5:
                            ToControl();
                            break;
                    }
                    Console.WriteLine("*********************Welcome to Queue Page*************************");
                    Console.WriteLine("Enter your choice\n1.Add Details\n2.View Details\n3.Remove First Value \n4.Show First Value\n5.Exit");
                    option = int.Parse(Console.ReadLine());
                } while (option != 6);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                FileLogger.Feed(e.Message);
                goto start;
            }
        }
        public void ToHashtable()
        {
            try
            {
                Hastable hashtableCollection = new Hastable();
                Console.WriteLine("*********************Welcome to hastable Page*************************");
                Console.WriteLine("\n1.Add\n2.View Details\n3.CheckID\n4.Delete Specific index\n5.exit");
                Console.WriteLine("Enter your choice");
                int choice = int.Parse(Console.ReadLine());
                do
                {
                    switch (choice)
                    {
                        case 1:

                            hashtableCollection.AddEmployeeData1();
                            break;
                        case 2:
                            hashtableCollection.DisplayEmployeeHash();
                            break;
                        case 3:
                            Console.WriteLine("Enter an Employee ID");
                            int employeeNumber = int.Parse(Console.ReadLine());
                            hashtableCollection.GetEmployeeList(employeeNumber);
                            
                            break;
                        case 4:
                            Console.WriteLine("Enter an Key");
                            hashtableCollection.DeleteKey(int.Parse(Console.ReadLine()));
                            break;
                        case 5:
                            ToControl();
                            
                            break;
                    }
                    Console.WriteLine("*********************Welcome to hastable Page*************************");
                    Console.WriteLine("\n1.Add\n2.View Details\n3.CheckID\n4.Delete Specific index\n5.exit");
                    Console.WriteLine("Enter your choice");
                    choice = int.Parse(Console.ReadLine());
                } while (choice != 5);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                FileLogger.Feed(e.Message);
            }
            Console.ReadLine();
        }
        public void ToSortedList()
        {
            try
            {
                Sortedlist sortedCollection = new Sortedlist();
                Console.WriteLine("*********************Welcome to hastable Page*************************");
                Console.WriteLine("\n1.Add\n2.View Details\n3.CheckID\n4.Delete Specific index\n5.exit");
                Console.WriteLine("Enter your choice");
                int choice = int.Parse(Console.ReadLine());
                do
                {
                    switch (choice)
                    {
                        case 1:

                            sortedCollection.AddSortedEmployeeData();
                            break;
                        case 2:
                            sortedCollection.DisplaySortedEmployeeHash();
                            break;
                        case 3:
                            Console.WriteLine("Enter an Employee ID");
                            int employeeNumber = int.Parse(Console.ReadLine());
                            sortedCollection.GetEmployeeList(employeeNumber);
                            break;
                        case 4:
                            Console.WriteLine("Enter an Key");
                            sortedCollection.DeleteSortedKey(int.Parse(Console.ReadLine()));
                            break;
                        case 5:
                            ToControl();
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine("*********************Welcome to hastable Page*************************");
                    Console.WriteLine("\n1.Add\n2.View Details\n3.CheckID\n4.Delete Specific index\n5.exit");
                    Console.WriteLine("Enter your choice");
                    choice = int.Parse(Console.ReadLine());
                } while (choice != 5);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                FileLogger.Feed(e.Message);
            }
            Console.ReadLine();
        }
        public  void ToControl()
        {
            start:
            try
            {
                StackFile stackCollection = new StackFile();
                Console.WriteLine("*********************Welcome to Main Page*************************");
                Console.WriteLine("Enter your choice\n1.Stack\n2.Queue\n3.Hastable\n4.Sortedlist\n5.Exit");
                int select = int.Parse(Console.ReadLine());
                do
                {
                    switch (select)
                    {
                        case 1:
                            ToStack();
                            break;
                        case 2:
                            ToQueue();
                            break;
                        case 3:
                            ToHashtable();
                            break;
                        case 4:
                            ToHashtable();
                            break;
                        case 5:
                            ToHashtable();
                            break;
                           
                    }
                    Console.WriteLine("*********************Welcome to Main Page*************************");
                    Console.WriteLine("Enter your choice\n1.Stack\n2.Queue\n3.Hastable\n4.Sortedlist\n5.Exit");
                    select = int.Parse(Console.ReadLine());
                } while (select != 6);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                FileLogger.Feed(e.Message);
                goto start;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeHub employeeHub = new EmployeeHub();
            employeeHub.ToControl();
            Console.Read();
        }
    }
}