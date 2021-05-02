using System;
using System.Collections.Generic;

namespace Car_Rental
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Description
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("|               CAR RENTAL               |");
            Console.WriteLine("------------------------------------------");
            Console.Write("This application is about renting a car\n" +
                "CAR RENTAL makes easy access to \n" +
                "check all available car that can be rented.\n" +
                "This application collects user data such as \n" +
                "i)Username\nii)Age\niii)DrivingLiscense No\n");
            Console.WriteLine("====WARNING!====\nENTER DATA IN SEQUNTIAL ORDER\nDO NOT REPEAT THE PROCESS\nIF THE DATA INPUT IS WRONGLY ENTERED PRESS 7 TO EXIT\n");

            #endregion
            Console.WriteLine("TYPE START TO BEGIN PROCESS");
            carRentals callClassCarrentals = new carRentals(Console.ReadLine());
        }
    }
}
    public class carRentals
    {

            List<String> data = new List<string>();//List
        public void callMe()
        {
            #region MenuDrivenAppln


            Console.WriteLine("..........................................");
            Console.WriteLine("              ~ MENU ~                    ");
            Console.WriteLine("..........................................");
            Console.WriteLine("Enter all data by slecting option below \n");

            Console.WriteLine(
                "1-Username\n" +
                "2-Age\n" +
                "3-Driving Liscense Id\n" +
                "4-select car to be rented\n" +
                "5-select colour for car\n" +
                "6-For many hours\n" +
                "7-EXIT");

            for (int i = 0; i <= 6; i++)
            {
                Console.WriteLine("Enter your choice in number(1 to 7):");
                string select = Console.ReadLine();
                #region switchcase(Menu)
                try
                {
                    int option = Convert.ToInt32(select);
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter UserName");
                            string username = Console.ReadLine();
                            userName(username);
                            break;

                        case 2:
                            Console.WriteLine("Enter your Age");
                            int Age = Convert.ToInt32(Console.ReadLine());
                            age(Age);
                            break;

                        case 3:
                            Console.WriteLine("Enter your driving liscense number(Input only in number)");
                           double dId =Convert.ToDouble( Console.ReadLine());
                            DrivingLis(dId);
                            break;
                        case 4:
                            Console.WriteLine("---Select your car---(type name of car)\n" +
                                "1-ACCORD\n" +
                                "2-AUDIR8\n" +
                                "3-BMWX3");
                            String carSelected = Console.ReadLine();
                            carSelect(carSelected);

                            break;
                        case 5:
                            Console.WriteLine("-----select colour----(type color of your car)\n" +
                                "1-red\n" +
                                "2-blue\n" +
                                "3-white\n" +
                                "4-black");
                            string colorSelcted = Console.ReadLine();
                            colourSelect(colorSelcted);
                            break;
                        case 6:
                            Console.WriteLine("----for how many you hours you want car rental service------\n(Enter a decimal number representing hour)");
                            String _rentTime = Console.ReadLine();
                            rentForhours(_rentTime);

                            break;
                        default:
                            System.Environment.Exit(0);
                            break;
                    }
                }
    #pragma warning disable CS0168 // Variable is declared but never used
                catch (Exception e)
    #pragma warning restore CS0168 // Variable is declared but never used
                {
                    Console.WriteLine("__________________ERROR__________________");
                    Console.WriteLine("Enter valid Number between (1 to 7)");
                }
                #endregion
            }
            #endregion
        }
        public carRentals(string a)
        {
            callMe();
        }//constructor
        //Six properties
        public void userName(string _username)
        {
            data.Add("USERNAME:" + _username);
            Console.WriteLine("username saved");
        }
        public void age(int _age)
        {
            if (_age < 18)
            {
                Console.WriteLine("You are underage to drive a car");
                Console.WriteLine("You cannot rent a car\n ---Exiting---");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
            else
            {
                data.Add(Convert.ToString("AGE:" + _age));
                Console.WriteLine("Age saved");
            }
        }
        public void DrivingLis(double _dl)
        {
            data.Add(Convert.ToString("DRIVING LISCENSE NO:" + _dl));
            Console.WriteLine("Driving Liscense Number saved");
        }
        public void carSelect(string _carS)
        {
            string temp1 = _carS;
            string temp = temp1;
            if (temp == "accord" || temp == "ACCORD")
            {
                data.Add("CAR MODEL" + _carS);
                Console.WriteLine("car selected!");
            }
            else if (temp == "AUDIR8" || temp == "audir8")
            {
                data.Add("CAR MODEL" + _carS);
                Console.WriteLine("car selected!");

            }
            else if (temp == "BMWX3" || temp == "bmwx3")
            {
                data.Add("CAR MODEL" + _carS);
                Console.WriteLine("car selected!");
            }
            else
            {
                Console.WriteLine("Enter a valid car name");
                Console.WriteLine("------exiting------");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
        }
        public void colourSelect(String _colS)
        {
            switch (_colS)
            {
                case "white": { data.Add("COLOR:" + _colS); Console.WriteLine("Colour selected"); } break;
                case "Blue": { data.Add("COLOR:" + _colS); Console.WriteLine("Colour selected"); } break;
                case "black": { data.Add("COLOR:" + _colS); Console.WriteLine("Colour selected"); } break;
                case "red": { data.Add("COLOR:" + _colS); Console.WriteLine("Colour selected"); } break;
                default: { Console.WriteLine("Enter a vaild color\n" + "------exiting-----"); System.Environment.Exit(0); } break;

            }
        }
        public void rentForhours(String _rentHour)
    {
        data.Add("HOURS:" + _rentHour);
        Console.WriteLine(_rentHour);
        Console.WriteLine("for time to be rented:SAVED!!\n\n" +
            "Order has been placed");
        data.ForEach(Console.WriteLine);
    }

    }


