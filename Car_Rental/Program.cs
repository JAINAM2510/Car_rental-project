using System;
using System.Collections.Generic;

namespace C_Sharp_Assignment_bittu
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