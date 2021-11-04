﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectArbete
{
    public class Menu
    {
        private static bool loop;
        private static int choice;

        static Garage garage = new();
        static Car newCar = new("car", 4);

        public static void Run()
        {
            loop = true;

            do
            {
                PrintOutMenu();
                choice = ReadInt();

                switch (choice)
                {
                    case 1:
                        garage.AddVehicle();
                        break;

                    case 2:
                        garage.RemoveVehicle();
                        break;

                    case 3:
                        PrintSubMenu();
                        break;

                    case 4:
                        garage.ListVehicle();
                        Console.ReadKey();
                        break;

                    case 0:
                        Console.WriteLine("Thank you, now exiting the program!");
                        loop = false;
                        break;
                    default:
                        break;
                }
            } while (loop);
        }

        private static void PrintOutMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Park a new vehicle " +
                "\n2. Remove vehicle from garage." +
                "\n3. Search for vehicle " +
                "\n4. Show all vehicles in garage" +
                "\n0. Exit");
        }
        private static void PrintSubMenu()
        {
            Console.WriteLine("Find a vehicle in the garage by adding a parameter." + 
                "\n1. To find with a registration number." +
                "\n2. To find all with colour." +
                "\n3. To find all with a specified number of wheels." + 
                "\n4. To find all with a max number of passengers."+ 
                "\n5. To find all with combi" +
                "\n6. Search by type " +
                "\n0. Exit");
            
            SubMenu();
        }

        private static void SubMenu()
        {
            choice = ReadInt();

            switch (choice)
            {
                // registration number
                case 1:
                    break;
                // Color
                case 2:
                    break;
                // number of wheels
                case 3:
                    break;
                // number of passengers
                case 4:
                    break;
                // Search by feature
                case 5:
                    break;
                // search by type
                case 6:
                    garage.SearchVehicle();
                    Console.ReadKey();
                    break;

                default:
                    break;
            }
        }

        static int ReadInt()
        {
            int number;
            while (int.TryParse(Console.ReadLine(), out number) == false)
            {
                Console.WriteLine("Not a valid option, please try again!");
            }
            return number;
        }

        
    }
}