using System.ComponentModel;
using System.ComponentModel.Design;

namespace ALBRIGHT_ASSINGMENT_2_1_2_AND_2_1_3
{
    internal class Program
    { 
    /* MSSA CCAD 16 - CHRISTOHPER ALBRIGHT
      * WEEK 2 - 11NOV2024
      * ASSIGNMENT 2-1
      * 
      * 
      * 2-1-2:
      * Design a class hierarchy of your choice. (Need only class files )
      * 
      * CLASS - TELEVISION
      * SUBCLASS - MOVIES
      * SUB2CLASS - ACTION, COMEDY, THRILLER, ETC...
      * SUBCLASS_THRILLER - SLOW BURN, HORROR, SURVIVAL, ETC...
      * SUBCLASS_COMEDY - ROMANTIC COMEDY, SLAPSTICK, WORKPLACE, ETC...
      * SUBCLASS_ACTION - WAR, WESTERN, SCIFI, ETC...
      * 
      * ============================================================================================================================================================================
      * 
      * 2-1-3:
      * Overloading: Write a simple Maths class ( don’t use the keyword Math, it will be a conflict with standard class from system). 
      * Write overloaded methods with logic and give choice to user to call different methods :
        a. Add(int num1, int num2)
        b. Add(decimal num1, decimal num2, decimal num3)
        c. Multiply(float num1, float num2)
        d. Multiply( float num1, float num2, float num3)
        Declare these methods as public and static.
      */
    
        static void Main(string[] args)
        {
            do
            {

                Console.WriteLine("\nHow many numbers would you like to analyze? (2 OR 3) ");
                int n_Int = Convert.ToInt32(Console.ReadLine());

                double[] array = new double[n_Int];

                for (int i = 0; i < n_Int; i++)
                {
                    Console.WriteLine("\nEnter value " + (i + 1) + ":");
                    array[i] = double.Parse(Console.ReadLine());
                }

                Console.WriteLine("\nThe elements stored in the array are:");
                foreach (double item in array)
                {
                    Console.Write(item + " ");
                }

                if (n_Int == 2)
                {
                    Console.WriteLine("\nMultiplication or Addition?");
                    if (Console.ReadLine() == "m" || Console.ReadLine() == "M")
                    {
                        Console.WriteLine("\n The product is: " + Maths.Multiply(array[0], array[1]));
                    }
                    else
                    {
                        if (Console.ReadLine() == "a" || Console.ReadLine() == "A")
                        {
                            Console.WriteLine("\n The sum is: " + Maths.Add(array[0], array[1]));
                        }

                        else
                        {
                            Console.WriteLine("Incorrect entry");
                        }
                    }
                }
                else if (n_Int == 3)
                {
                    Console.WriteLine("\nMultiplication or Addition?");
                    if (Console.ReadLine() == "m" || Console.ReadLine() == "M")
                    {
                        Console.WriteLine("\n The product is: " + Maths.Multiply(array[0], array[1], array[2]));
                    }
                    else
                    {
                        if (Console.ReadLine() == "a" || Console.ReadLine() == "A")
                        {
                            Console.WriteLine("\n The sum is: " + Maths.Add(array[0], array[1], array[2]));
                        }

                        else
                        {
                            Console.WriteLine("Incorrect entry");
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Incorrect entry");
                }

                Console.WriteLine("Type any key to continue or exit to leave the program");
            }
            
            while (Console.ReadLine() != "exit" || Console.ReadLine() != "EXIT");
        }
    }

     class Maths
     {
        public static double Add(double num1, double num2)
        {
        return num1 + num2;
        }

        public static double Add(double num1, double num2, double num3)
        { 
        return num1 + num2 + num3;
        }
        public static double Multiply(double num1, double num2)
        {
        return num1 * num2;
        }
        public static double Multiply(double num1, double num2, double num3)
        {
        return num1 * num2 * num3;
        }
    }
}

/*
 * 
 * 
 * BELOW CLASS SOLUTION FOR DEFINING OVERLOADED METHODS
 * 
 * 
 * 
 * static void Main(string[] args)
        {

        }

        public static int AddTwoInts(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal AddThreeDecimal(decimal num1, decimal num2, decimal num3)
        {
            return num1 + num2 + num3;
        }

        public static float MultiplyTwoFloat(float num1, float num2) 
        { 
            return num1 * num2; 
        }
        public static float MultiplyThreeFloat(float num1, float num2, float num3)
        {
            return num1 * num2 * num3;
        }

        public static int AddArrayForEach(int[] inputs)
        {
            int result = 0;
            foreach (int input in inputs)
            {
                result += input;
            }

            return result;
        }

        public static int AddArrayFor(int[] inputs)
        {
            int result = 0;

            for (int i=0; i<inputs.Length; i++)
            {
                result += inputs[i];
            }

            return result;
        }
*/
