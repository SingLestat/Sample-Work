using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skills2
{
    //Used to hold all data
    class Data
    {
        public static string FirstName;
        public static string LastName;
        public static string Address;
        public static int PhoneNum;
        public static bool Delivery = false;
        public static int LocNum;
        public static double Total;

        public static Form1 Form1 = new Form1();
        public static Screen2 screen2 = new Screen2();
        public static TotalScreen TotalScreen = new TotalScreen();

        public static List<string> FoodLoc = new List<string> { "KFC North", "KFC South", "KFC East" };
        public static List<string> FoodIteams = new List<string>();

    }
}
