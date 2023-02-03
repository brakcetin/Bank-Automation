using System;
using System.Data;
using System.IO;



public class Program

{
    static string FirstsChoice;
    static string SecondChoice;
    static string ThirdChoice;
    static string selected = "* ";
    static int sayi = 0;
    static int kontrol = 1;
    static string[] admin_id = new string[50];
    static string[] admin_pass = new string[50];
    static string admin1_id = "0202230001";
    static string admin1_pass = "2adm/-BjG";

    static void login_admin()
    {
        Console.Write("To log in, enter your information:\n\n");
        Console.Write("ID:");
        string id_entry = (Console.ReadLine());
        Console.Write("Password:");
        string pass_entry = (Console.ReadLine());
        while (id_entry != admin1_id && pass_entry != admin1_pass)
        {
            Console.Clear();
            Console.WriteLine("ADMIN");
            Console.WriteLine("-----\n\n");
            Console.WriteLine("ID or password is incorrect! Please re-enter!\n");
            Console.Write("ID:");
            id_entry = (Console.ReadLine());
            Console.Write("Password:");
            pass_entry = (Console.ReadLine());

        }
    }
    static void login_user()
    {
        Console.Write("To log in, enter your information:\n\n");
        Console.Write("ID:");
        string id_entry = (Console.ReadLine());
        Console.Write("Password:");
        string pass_entry = (Console.ReadLine());
        while (id_entry != admin1_id && pass_entry != admin1_pass)
        {
            Console.Clear();
            Console.WriteLine("USER");
            Console.WriteLine("-----\n\n");
            Console.WriteLine("ID or password is incorrect! Please re-enter!\n");
            Console.Write("ID:");
            id_entry = (Console.ReadLine());
            Console.Write("Password:");
            pass_entry = (Console.ReadLine());
            
        }
    }


    /* for (int i = 0; i<length; i++)
             {
                 admin_id[i] == girilen did ve admin_sifre[i] == girlen pass


             }*/
    static void yazdir(int secim)
    {
        if (secim % 2 == 0)
        {
            Console.WriteLine(selected + FirstsChoice);
            Console.WriteLine("  " + SecondChoice);
        }
        else
        {
            Console.WriteLine("  " + FirstsChoice);
            Console.WriteLine(selected + SecondChoice);
        }

    }
    static void print(int secim)
    {
        if (secim % 3 == 0)
        {
            Console.WriteLine(selected + FirstsChoice);
            Console.WriteLine("  " + SecondChoice);
            Console.WriteLine("  " + ThirdChoice);
        }
        else if (secim % 3 == 1)
        {
            Console.WriteLine("  " + FirstsChoice);
            Console.WriteLine(selected + SecondChoice);
            Console.WriteLine("  " + ThirdChoice);
        }
        else
        {
            Console.WriteLine("  " + FirstsChoice);
            Console.WriteLine("  " + SecondChoice);
            Console.WriteLine(selected + ThirdChoice);
        }

    }

    static void choose_admin(int secim, int i)
    {
        var key = new ConsoleKeyInfo().Key;
        int queue = 0;
        string users = @"C:\Users\brakc\source\repos\BankAutomation\users.txt";
        FirstsChoice = "Add user";
        SecondChoice = "List users";
        ThirdChoice = "Log out";
        Console.Clear();
        do
        {
            //  Console.Clear();
            //  print(sayi);
            /*  while (true)
              {
                  key = Console.ReadKey().Key;
                  if (key == ConsoleKey.Enter)
                  {
                      break;
                  }
                  else if (key == ConsoleKey.DownArrow || key == ConsoleKey.UpArrow)
                  {
                      sayi++;
                      Console.Clear();
                      print(sayi);
                  }
                  else
                  {
                      Console.Clear();
                      print(sayi);
                  }
              }   */


            /* if (sayi % 3 == 0)
             {
                 Console.Clear();
                 Console.Write("ID:");
                 admin_id[queue] = Convert.ToInt32(Console.ReadLine());
                 Console.Write("Password:");
                 admin_pass[queue] = Convert.ToInt32(Console.ReadLine());
                 queue++;
             }

             else if (sayi % 3 == 1)
             {
                 Console.Clear();
                 Console.WriteLine("List of Users\n");
                 Console.WriteLine("ID\tPassword");
                 Console.WriteLine("----\t--------");
                 for (i = 0; i < queue; i++)
                 {
                     Console.Write(admin_id[i] + "\t");
                     Console.WriteLine(admin_pass[i]);

                 }
             }
             else
             {
                 break;
             }
            */

            Console.WriteLine("Select the action you want to do:\n(Write 1,2 or 3)");
            Console.WriteLine("1. Add User\n2. List Users\n3. Log out");
            string x = Console.ReadLine();

            //  while (true)
            //  {
            switch (x)
            {
                case "1":
                    Console.Clear();
                    Console.Write("ID:");
                    admin_id[queue] = Console.ReadLine();

                    //        admin_id[queue] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Password:");
                    admin_pass[queue] = Console.ReadLine();
                    //       admin_pass[queue] = Convert.ToInt32(Console.ReadLine());
                   // Console.WriteLine("\r\n" + users);
                    //   File.AppendAllText(users, Environment.NewLine);

                    for (int j = 0; j <= queue; j++)
                    {
                        File.AppendAllText(users, admin_id[queue] + "," + admin_pass[queue] + Environment.NewLine);
                    }
                    //queue++;
                    Console.WriteLine("\n");
                    break;
                case "2":
                    Console.Clear();
                    //  Console.WriteLine("List of Users\n");
                    // Console.WriteLine("ID\tPassword");
                    // Console.WriteLine("----\t--------");
                    string[] lines = File.ReadAllLines(users);
                    string[] id_column = new string[lines.Length];
                    string[] pass_column = new string[lines.Length];

                    for (i = 0; i < lines.Length; i++)
                    {
                        string[] columns = lines[i].Split(',');
                        id_column[i] = columns[0];
                        pass_column[i] = columns[1];
                        Console.WriteLine(id_column[i] + "\t" + pass_column[i]);
                    }
                    Console.WriteLine("\n");
                    break;
                case "3":
                    Main(new string[] { });
                    //      kontrol = -1;
                    break;

                default:
                    break;
            }
            //  }

        } while (kontrol != -1);




    }

    static void choose_user()
    {
        Console.Clear();
        var key = new ConsoleKeyInfo().Key;
        while (true)
        {
            Console.WriteLine("* Log out");
            key = Console.ReadKey().Key;
            if (key == ConsoleKey.Enter)
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("* Log out");
            }
        }
        Main(new string[] { });
    }

    static void Main(string[] args)
    {
        var key = new ConsoleKeyInfo().Key;
        int i = 0;
        FirstsChoice = "admin";
        SecondChoice = "password";
        ThirdChoice = "Exit";

        Console.Clear();
        print(sayi);


        while (true)
        {
            //Console.Write("Select to continue.\n\n");
            key = Console.ReadKey().Key;
            if (key == ConsoleKey.Enter)
            {
                break;
            }
            else if (key == ConsoleKey.DownArrow || key == ConsoleKey.UpArrow)
            {
                sayi++;
                Console.Clear();
                print(sayi);
            }
            else
            {
                Console.Clear();
                print(sayi);
            }
        }


        if (sayi % 3 == 0)
        {
            Console.Clear();
            Console.WriteLine("ADMIN");
            Console.WriteLine("-----\n\n");
            login_admin();
            choose_admin(sayi, i);


        }



        else if (sayi % 3 == 1)
        {
            Console.Clear();
            Console.WriteLine("USER");
            Console.WriteLine("-----\n\n");
            login_user();
            choose_user();
        }
        else
        {
            Console.Clear();
            Environment.Exit(0);
        }



        /*   if (key == ConsoleKey.DownArrow)
           {

               Console.Clear();
               Console.WriteLine("* user");
               Console.Write("To log in, enter your information:\n\n");
               Console.Write("ID:");
               Console.ReadLine();
               Console.Write("Password:");
               Console.ReadLine();
           }   */

        /*   Console.Write("Are you a member?\n");
           Console.WriteLine("If you are member please write 'yes'," +
               "if you are not member please write 'no'.");*/

        /* 

         string admin;
         Console.Write("Select to continue.\n");
         Console.Write("* admin\n* user\n: ");
         do
         {
             Console.Clear();
             Console.Write("Select to continue.\n");
             if()
             Console.Write("* admin\n: ");
          //   admin = Console.ReadLine();

             if(key == ConsoleKey.DownArrow)
             {
                 Console.WriteLine("* user");
             }

             if (admin == "admin")
             {
              //   Console.WriteLine("")
             }
             else if (admin == "user")
             {
                 Console.Clear();
                 Console.Write("To log in, enter your information:\n\n");
                 Console.Write("ID:");
                 Console.ReadLine();
                 Console.Write("Password:");
                 Console.ReadLine();
             }

         } while (admin != "admin" && admin != "user");


         */


        /* {
         Console.Clear();
         Console.Write("Please enter something valid for the action you want to take.\n");
         Console.Write("* admin\n* user\n: ");
         admin = Console.ReadLine();
     }*/





        /*   string uye = Console.ReadLine();
           switch (uye)
           {
               case "yes":
                   Console.Write("ID:");
                   Console.ReadLine();

                   Console.Write("\nPassword:");
                   Console.ReadLine();
                   break;
               case "no":
                   Console.Write("Name: ");
                   Console.ReadLine();
                   Console.Write("Surname: ");
                   Console.ReadLine();
                   Console.Write("Birth Date: ");
                   Console.ReadLine();
                   Console.Write("e-mail: ");
                   Console.ReadLine();
                   Console.Write("Credit Card Numbers: ");
                   Console.ReadLine();
                   Console.Write("CVV: ");
                   Console.ReadLine();
                   Console.Write("Password: ");
                   string password = Console.ReadLine();
                   Console.Write("Password again :");
                   string password2 = Console.ReadLine();
                   while (password != password2)
                   {
                       Console.Write("You entered wrong. Please re-enter: ");
                       password2 = Console.ReadLine();
                   }
                   break;
           }*/


    }
}


