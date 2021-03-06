using System;
using System.Threading;
using System.Data.OleDb;
using System.Data;
using System.Text;

namespace Tools
{
    internal class main
    {
        //  04/02/2002
        //  update
        //  04/02/2022
        static void Main(string[] args) // handling data and forms
        {
            Console.OutputEncoding = Encoding.UTF8;
            system();
            void system()
            {
                try
                {
                    /*
                     -> form -> if -> if case -> call sldata and put conditions 
                     */
                    form(1);
                    Console.Write("\t-> ");
                    int ifsystem = Convert.ToInt32(Console.ReadLine());
                    switch (ifsystem)
                    {
                        case 1:
                            form(3);
                            Console.Write("\t-> ");
                            int dk1 = Convert.ToInt32(Console.ReadLine());
                            if (dk1 == 1)
                            {
                                SLDatabase(1, 1);
                            }
                            if (dk1 == 2)
                            {
                                SLDatabase(1, 2);
                            }
                            system();
                            break;
                        case 2:
                            form(5);
                            Console.Write("\t-> ");
                            int dk2 = Convert.ToInt32(Console.ReadLine());
                            if (dk2 == 1)
                            {
                                SLDatabase(2, 1);
                            }
                            else if (dk2 == 2)
                            {
                                SLDatabase(2, 2);
                            }
                            else if (dk2 == 3)
                            {
                                SLDatabase(2, 3);
                            }
                            else if (dk2 == 4)
                            {
                                SLDatabase(2, 4);
                            }
                            else if (dk2 == 5)
                            {
                                SLDatabase(2, 5);
                            }
                            else if (dk2 == 6)
                            {
                                SLDatabase(2, 6);
                            }
                            system();
                            break;
                        default:
                            form(3);
                            system();
                            break;
                    }
                }
                catch (Exception)
                {
                    form(2);
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    system();
                }
            }
        }
        static void SLDatabase(int ifo, int ifi) //put data 
        {
            string linkdata = @"D:\Nghề"; // link source
            string data = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + linkdata + @"\Database.accdb";

            try
            {
                OleDbConnection conn = new OleDbConnection(data);
                conn.Open();
                OleDbCommand sqlcmd = new OleDbCommand();

                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.CommandText = "SELECT tk.tk, tk.mk FROM tk";
                sqlcmd.Connection = conn;
                OleDbDataReader reader = sqlcmd.ExecuteReader();
                int sl=0; //to set position
                while (reader.Read())//When you finish reading, stop
                {
                    /*
                      Read the data and pass it to the system -> then set condition
                     */
                    string tk = reader.GetString(0);
                    string mk = reader.GetString(1);
                    Thread t = new Thread(() =>
                    {
                        sl += 20;
                        if (ifo == 1)
                        {
                            if (ifi == 1)
                            {
                                system system = new system(1, tk, mk, "1", 0,sl);
                            }
                            else if (ifi == 2)
                            {
                                system system = new system(1, tk, mk, "1", 0,sl);
                            }
                        }
                        else if (ifo == 2)
                        {
                            if (ifi == 1)
                            {
                                system system = new system(2, tk, mk, "1", 1, sl);
                            }
                            else if (ifi == 2)
                            {
                                system system = new system(2, tk, mk, "1", 2, sl);
                            }
                            else if (ifi == 3)
                            {
                                system system = new system(2, tk, mk, "1", 3, sl);
                            }
                            else if (ifi == 4)
                            {
                                system system = new system(2, tk, mk, "1", 4, sl);
                            }
                            else if (ifi == 5)
                            {
                                system system = new system(2, tk, mk, "1", 5, sl);
                            }
                            else if (ifi == 6)
                            {
                                system system = new system(2, tk, mk, "1", 6, sl);
                            }
                        }
                    }); t.Start();
                }
                conn.Close();
            }
            catch (Exception)
            {
                form(4);
            }
        }
        static void form(int if1) //  form
        {
            Console.Title = "form Tools";

            switch (if1)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("| 1: Auto Lướt                    |");
                    Console.WriteLine("| 2: Auto report                  |");
                    Console.WriteLine("| 3:                              |");
                    Console.WriteLine("| 4:                              |");
                    Console.WriteLine("-----------------------------------");
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("|            Lỗi                  |");
                    Console.WriteLine("-----------------------------------");
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("\t1: Full nick\n\t2: 3 nick");
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("|     Lỗi kết nối tới database    |");
                    Console.WriteLine("-----------------------------------");
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("| 1: Giả mạo                      |");
                    Console.WriteLine("| 2: Spam Gây hại                 |");
                    Console.WriteLine("| 3: Tên Giả                      |");
                    Console.WriteLine("| 4: Đăng nội dung không phù hợp  |");
                    Console.WriteLine("-----------------------------------");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Lỗi form");

                    break;
            }
        }
    }
}
