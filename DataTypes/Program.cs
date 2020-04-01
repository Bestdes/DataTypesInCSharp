using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 13;
            int num2 = 27;
            int num3, num4, num5;

            int sum = num1 + num2;

            double d1 = 3.555;
            double d2 = 4.5;

            double dSum = d1 + d2;
            double dDiv = d1 / d2;

            float f1 = 3.555f;
            float f2 = 2.777f;


            Console.WriteLine("The sum of " + d1 + " + " + d2 + " = " + dSum);

            Console.WriteLine("The division of " + d1 + " / " + d2 + " = " + dDiv);

            Console.WriteLine("The sum of " + num1 + " + " + num2 + " = " + sum);

            String myName = "DeShawn";
            String myMessage = "My name is " + myName;

            String capsMessage = myMessage.ToUpper();
            String lowerMessage = myMessage.ToLower();

            Console.WriteLine(myMessage);
            Console.WriteLine("My name is " + myName);
            Console.WriteLine(capsMessage);
            Console.WriteLine(lowerMessage);

            //camelCase = Variables
            //PascalCase = Methods
            //Nouns = classes

            //-----------------------

            // Explicit Conversion
            double myDouble = 27.72;
            int myInt;

            myInt = (int)myDouble;

            Console.WriteLine("-----------------");
            Console.WriteLine(myInt);

            //Implicit Conversion
            int toLongNum = 123007060;
            long bigNum = toLongNum;

            float myFloat = 12.27f;
            double toFloatDouble = myFloat;

            //Type Conversion
            String myString = myDouble.ToString();
            String floatToString = toLongNum.ToString();

            Console.WriteLine(floatToString);

            //Boolean
            bool sunIsShining = false;
            String myBool = sunIsShining.ToString();

            Console.WriteLine(myBool);

            //Parsing

            String myNewString = "15";
            String mySecondString = "27";
            String result = myNewString + mySecondString;

            Console.WriteLine(result);

            int parseInt1 = Int32.Parse(myNewString);
            int parseInt2 = Int32.Parse(mySecondString);

            int parseSum = parseInt1 + parseInt2;

            Console.WriteLine(parseSum);

            //Course Challenge #1
            byte data01 = 15;
            sbyte data1 = 1;
            short data2 = 2;
            ushort data02 = 45;
            int data3 = 3;
            uint data03 = 3030;
            long data4 = 2005;
            ulong data04 = 30005;
            float data5 = 237798.785f;
            double data6 = 4.3356;
            decimal data7 = 2.777227M;

            char data8 = 'R';
            bool isTrue = false;

            String stringChallenge1 = "I control text";
            String stringChallenge2 = "7";

            int challengeParse = Int32.Parse(stringChallenge2);

            //Constants
            const double pie = 3.14159265359;
            const int weeks = 52;
            const int months = 12;

            const String birthday = "August 19, 1990";
            const String birtdayInNumerals = "08.19.1990";

            Console.WriteLine("My birthday is always: " + birthday);




        }
    }
}
