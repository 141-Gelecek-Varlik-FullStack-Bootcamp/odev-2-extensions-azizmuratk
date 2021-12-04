using System;

namespace ConsoleExtension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Today's value created
            DateTime today = DateTime.Now;

            // String elements has been assigned with 'TimeExtension'
            String sydney = Extension.TimeExtension.ToAustralianTimeZone(today);
            String newYork = Extension.TimeExtension.ToNewYorkTimeZone(today);

            // String elements has been assigned with 'UserTypeExtensions'
            String type1 = Extension.UserTypeExtensions.GetEnumDisplayName(UserType.Type1);
            String type2 = Extension.UserTypeExtensions.GetEnumDisplayName(UserType.Type2);
            String type3 = Extension.UserTypeExtensions.GetEnumDisplayName(UserType.Type3);

            // Command that allows us to see on 'command prompt' screen
            Console.WriteLine("************************");
            Console.WriteLine("Sydney Time = " + sydney);
            Console.WriteLine("Istanbul Time = " + today.ToLongTimeString());
            Console.WriteLine("New York Time = " + newYork);
            Console.WriteLine("************************");
            Console.WriteLine("Type1 Value = " + type1);
            Console.WriteLine("Type2 Value = " + type2);
            Console.WriteLine("Type3 Value = " + type3);
            Console.WriteLine("************************");
        }
    }
}
