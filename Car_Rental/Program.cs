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
    public void DrivingLis(char _dl)
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


