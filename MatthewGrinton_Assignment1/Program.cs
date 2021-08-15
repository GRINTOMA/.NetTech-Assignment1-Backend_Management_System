using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatthewGrinton_Assignment1
{
    class Program
    {

        static void Main(string[] args)
        {
            int flag = 0, menuNum = 0;
            string userIn;
            List<Employee> employeeList = new List<Employee>();
            List<Payroll> payrollList = new List<Payroll>();
            List<Vacation> vacationList = new List<Vacation>();
            PopulateLists(employeeList, payrollList, vacationList);
            string[] menu1 = { "Press 1 to modify employees\n", "Press 2 to add payroll\n", "Press 3 to view vacation days\n", "Press 4 to exit program\n" };
            string[] menu2 = { "Press 1 to list all employees\n", "Press 2 to add new employee\n", "Press 3 to update\n", "Press 4 to delete\n", "Press 5 to return to main menu\n" };
            string[] menu3 = { "Press 1 to inset new payroll entry\n", "Press 2 to view payroll history for an employee\n", "Press 3 to return to main menu\n" };
            string[] menu4 = { "Press 1 to view vacation days\n", "Press 2 to ...\n", "Press 3 to return to the main menu\n" };
            do
            {
                while (menuNum == 0)
                {
                    for (int i = 0; i < menu1.Length; i++)
                    {
                        Console.WriteLine(menu1[i]);
                    }
                    userIn = Console.ReadLine();
                    int x;
                    bool check = int.TryParse(userIn, out x);
                    if (check)
                    {
                        if (int.Parse(userIn) == 1)
                        {
                            Console.Clear();
                            for (int i = 0; i < menu2.Length; i++)
                            {
                                Console.WriteLine(menu2[i]);
                            }
                            userIn = Console.ReadLine();
                            check = int.TryParse(userIn, out x);
                            if (check)
                            {
                                if (int.Parse(userIn) == 1)
                                {
                                    Console.Clear();
                                    string title1 = "ID",
                                        title2 = "Name",
                                        title3 = "Address",
                                        title4 = "Email",
                                        title5 = "Phone",
                                        title6 = "Role";

                                    Console.WriteLine($"{title1,-5} {title2,-15} {title3,-25} {title4,-20} {title5,-10} {title6,13}");
                                    foreach (var item in employeeList)
                                        Console.WriteLine(item);
                                }
                                else if (int.Parse(userIn) == 2)
                                {
                                    Console.Clear();
                                    Employee e = new Employee();
                                    AddEmployee(out e);
                                    employeeList.Add(e);
                                }
                                else if (int.Parse(userIn) == 3)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Which employee will you be updating?(PROVIDE EMPOYEE ID)");
                                    int empID = int.Parse(Console.ReadLine());
                                    UpdateEmployee(employeeList, empID);
                                }
                                else if (int.Parse(userIn) == 4)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Which employee will you be deleting?(PROVIDE EMPLOYEE ID)");
                                    int empID = int.Parse(Console.ReadLine());
                                    DeleteEmployee(employeeList, empID);
                                }
                                else if (int.Parse(userIn) == 5)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Returning to main menu");
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Unfortunatley that wasn't an option. Returning to main menu");
                                    Console.ReadLine();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Unfortunatley that wasn't a menu option.");
                                Console.ReadLine();
                                Console.Clear();
                            }

                        }
                        else if (int.Parse(userIn) == 2)
                        {
                            Console.Clear();
                            for (int i = 0; i < menu3.Length; i++)
                            {
                                Console.WriteLine(menu3[i]);
                            }
                            userIn = Console.ReadLine();
                            check = int.TryParse(userIn, out x);
                            if (check)
                            {
                                if (int.Parse(userIn) == 1)
                                {
                                    Console.Clear();
                                    Payroll p = new Payroll();
                                    AddPayroll(out p);
                                    payrollList.Add(p);
                                }
                                else if (int.Parse(userIn) == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Which employee would you like to view the payroll history for?(PROVIDE EMPLOYEE ID)");
                                    int empID = int.Parse(Console.ReadLine());
                                    var payHistory = from pay in payrollList
                                                     where pay.EmployeeID == empID
                                                     select pay;
                                    string title1 = "Payroll ID",
                                        title2 = "Employee ID",
                                        title3 = "Date",
                                        title4 = "Hours Worked",
                                        title5 = "Hourly Rate";

                                    Console.WriteLine($"{title1,-10} {title2,-10} {title3,-12} {title4,-8} {title5,10}");
                                    foreach (var item in payHistory)
                                    {
                                        Console.WriteLine(item);
                                    }
                                }
                                else if (int.Parse(userIn) == 3)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Returning to main menu");
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Unfortunatley that wasn't an option. Returning to main menu");
                                    Console.ReadLine();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Unfortunatley that wasn't a menu option.");
                                Console.ReadLine();
                                Console.Clear();
                            }
                        }
                        else if (int.Parse(userIn) == 3)
                        {
                            Console.Clear();
                            for (int i = 0; i < menu4.Length; i++)
                            {
                                Console.WriteLine(menu4[i]);
                            }
                            userIn = Console.ReadLine();
                            check = int.TryParse(userIn, out x);
                            if (check)
                            {
                                if (int.Parse(userIn) == 1)
                                {
                                    string title1 = "Vacation ID",
                                        title2 = "Employee ID",
                                        title3 = "Number of Days";
                                    Console.Clear();
                                    Console.WriteLine($"{title1,-10} {title2,-10} {title3,10}");
                                    foreach (var item in vacationList)
                                        Console.WriteLine(item);
                                }
                                else if (int.Parse(userIn) == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine("...");
                                }
                                else if (int.Parse(userIn) == 3)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Returning to main menu");
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Unfortunatley that wasn't an option. Returning to main menu");
                                    Console.ReadLine();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Unfortunatley that wasn't a menu option.");
                                Console.ReadLine();
                                Console.Clear();
                            }

                        }
                        else if (int.Parse(userIn) == 4)
                        {
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Unfortunatley that wasn't a menu option.");
                        Console.ReadLine();
                        Console.Clear();
                    }

                    menuNum = 0;
                }
            } while (flag != 0);
            static void PopulateLists(List<Employee> e, List<Payroll> p, List<Vacation> v)
            {
                e.Add(new Employee(1, "Matt", "5 Main Street", "name@email.com", "1234567890", "ADMIN"));
                e.Add(new Employee(2, "Mark", "2432 Other Street", "age@email.com", "1234567890", "USER"));
                e.Add(new Employee(3, "Dave", "1234 Number Cres", "height@email.com", "1234567890", "ADMIN"));
                e.Add(new Employee(4, "Frank", "2034 Main Street", "people@email.com", "1234567890", "GUEST"));
                e.Add(new Employee(5, "Peter", "6 Olive Ave", "world@email.com", "1234567890", "USER"));
                e.Add(new Employee(6, "Suzan", "2432 Main Street", "style@email.com", "1234567890", "USER"));
                e.Add(new Employee(7, "Sarah", "1111 Repeating Court", "example@email.com", "1234567890", "GUEST"));
                e.Add(new Employee(8, "Jules", "55 Lesser Street", "big@email.com", "1234567890", "USER"));
                e.Add(new Employee(9, "Kyle", "7 Prime Blvd", "small@email.com", "1234567890", "USER"));
                e.Add(new Employee(10, "Mitchel", "12 Twelfth Drive", "mitchel@email.com", "1234567890", "ADMIN"));

                p.Add(new Payroll(1, 5, "05042020", 40, 30));
                p.Add(new Payroll(2, 2, "05052020", 48, 28));
                p.Add(new Payroll(3, 5, "05112020", 45, 30));
                p.Add(new Payroll(4, 7, "05252020", 30, 24));
                p.Add(new Payroll(5, 10, "06052020", 21, 15));
                p.Add(new Payroll(6, 6, "06112020", 32, 38));
                p.Add(new Payroll(7, 4, "07252020", 21, 16));
                p.Add(new Payroll(8, 3, "08092020", 41, 37));
                p.Add(new Payroll(9, 8, "10302020", 20, 15));
                p.Add(new Payroll(10, 7, "01012021", 31, 24));

                v.Add(new Vacation(1, 4, 20));
                v.Add(new Vacation(2, 4, 10));
                v.Add(new Vacation(3, 1, 5));
                v.Add(new Vacation(4, 7, 15));
                v.Add(new Vacation(5, 9, 11));
                v.Add(new Vacation(6, 10, 2));
                v.Add(new Vacation(7, 1, 6));
                v.Add(new Vacation(8, 3, 25));
                v.Add(new Vacation(9, 5, 17));
                v.Add(new Vacation(10, 2, 14));
            }
            static Employee AddEmployee(out Employee e)
            {
                int i;
                string n, a, m, p, r;
                Console.WriteLine("What is the new Employee's ID?");
                i = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the new Employee's name?");
                n = Console.ReadLine();
                Console.WriteLine("What is the new Employee's address?");
                a = Console.ReadLine();
                Console.WriteLine("What is the new Employee's email?");
                m = Console.ReadLine();
                Console.WriteLine("What is the new Employee's phone number?");
                p = Console.ReadLine();
                Console.WriteLine("What is the new Employee's role?");
                r = Console.ReadLine();
                return e = new Employee(i, n, a, m, p, r);
            }
            static void UpdateEmployee(List<Employee> list, int id)
            {
                Console.WriteLine("What about employee " + id + " would you like to update?(Name/Address/Email/Phone/Role)");
                string choice = Console.ReadLine();
                var employeeUpdate = from emp in list
                                     where emp.Id == id
                                     select emp;
                if (choice == "Name" || choice == "name")
                {
                    Console.WriteLine("What would you like to change employee " + id + "'s name to?");
                    string newName = Console.ReadLine();
                    foreach (var item in employeeUpdate)
                    {
                        item.Name = newName;
                    }
                }
                else if (choice == "Address" || choice == "address")
                {
                    Console.WriteLine("What would you like to change employee " + id + "'s address to?");
                    string newAddress = Console.ReadLine();
                    foreach (var item in employeeUpdate)
                    {
                        item.Address = newAddress;
                    }
                }
                else if (choice == "Email" || choice == "email")
                {
                    Console.WriteLine("What would you like to change employee " + id + "'s email to?");
                    string newEmail = Console.ReadLine();
                    foreach (var item in employeeUpdate)
                    {
                        item.Email = newEmail;
                    }
                }
                else if (choice == "Phone" || choice == "phone")
                {
                    Console.WriteLine("What would you like to change employee " + id + "'s phone number to?");
                    string newPhone = Console.ReadLine();
                    foreach (var item in employeeUpdate)
                    {
                        item.Phone = newPhone;
                    }
                }
                else if (choice == "Role" || choice == "role")
                {
                    Console.WriteLine("What would you like to change employee " + id + "'s role to?");
                    string newRole = Console.ReadLine();
                    foreach (var item in employeeUpdate)
                    {
                        item.Role = newRole;
                    }
                }
                else
                {
                    Console.WriteLine("Unfortunatley that wasn't an option.");
                }
            }
            static void DeleteEmployee(List<Employee> list, int id)
            {
                list.RemoveAll(emp => emp.Id == id);
            }
            static Payroll AddPayroll(out Payroll p)
            {
                int pID, eID, h;
                string d;
                double r;
                Console.WriteLine("What is the new Payroll ID?");
                pID = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the Employee's ID?");
                eID = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the date?");
                d = Console.ReadLine();
                Console.WriteLine("How many hours were worked?");
                h = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the pay rate?");
                r = double.Parse(Console.ReadLine());
                return p = new Payroll(pID, eID, d, h, r);
            }
        }
    }
}
