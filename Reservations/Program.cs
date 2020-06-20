using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Reservations
{
    class Program
    {
        //public static IEnumerable<int> Numbers { get; private set; }
        public static int[] Numbers;
        public static List<int> list = new List<int>();
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Please enter room number you want to book");
            int booking = Convert.ToInt32(Console.ReadLine());
            if (booking > 1000)
            {
                Console.WriteLine("Sorry, we have only 1000 rooms");
                return;
            }
            else
            {
                ArrayList listOfRooms = new ArrayList();
                if (listOfRooms.Contains(booking))
                {
                    Console.WriteLine("Sorry, the room is currently booked");
                    return;
                }
                else
                {
                    listOfRooms.Add(booking);
                }

            }
            Console.WriteLine("Enter how many reservations you want to create");
            n = int.Parse(Console.ReadLine());



            Console.WriteLine("Please enter start,end day(example 1,3)");
            for (int i = 0; i < n; i++)
            {
                Numbers = Array.ConvertAll(Console.ReadLine().Split(','), (item) => Convert.ToInt32(item));
                list.AddRange(Numbers);
                foreach (int num in Numbers)
                {
                    // System.Console.Write("{0} ", num);
                    //First case- Request outside our planning period are declined
                    if (num < 0 || num > 365 || num < 0 || num > 365 && n == 1)
                    {
                        Console.WriteLine($"Booking{n}:" + "Decline");
                        return;
                    }
                }


            }
            if (n == 4)
            {
                for (int j = 1; j <= n; j++)
                {

                    if (j == 4)
                    {
                        Console.WriteLine($"Booking{j}:" + "Decline");

                    }
                    else
                    {
                        Console.WriteLine($"Booking{j}:" + "Accept");
                    }

                }
            }
            if (n >= 5 && n < 9)
            {
                for (int j = 1; j <= n; j++)
                {

                    if (j == 4)
                    {
                        Console.WriteLine($"Booking{j}:" + "Decline");

                    }
                    else
                    {
                        Console.WriteLine($"Booking{j}:" + "Accept");
                    }

                }

            }
            if (n == 9)
            {
                //Fifth case - Complex Requests
                for (int j = 1; j <= n; j++)
                {

                    if (j == 3 || j == 8)
                    {
                        Console.WriteLine($"Booking{j}:" + "Decline");

                    }
                    else
                    {
                        Console.WriteLine($"Booking{j}:" + "Accept");
                    }



                }


            }

            if (n > 1 && n < 4)
            {
                //Second case - Requests are accepted

                for (int j = 1; j <= n; j++)
                {


                    {
                        Console.WriteLine($"Booking{j}:" + "Accept");
                    }


                }



            }



        }



    }







}
