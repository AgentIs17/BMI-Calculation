using System;

namespace BMI_Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            InterFace(1);
            Choice();
        }
        public static void Choice()
        {
            int choice;
            do
            {
                Console.WriteLine("Pick your way of measurement 1 for Imperial 2 for Metric");
                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    ImperialCalc();
                }
                if (choice == 2)
                {
                    MetricCalc();
                }
                else
                    Console.WriteLine("\nPick 1 Or 2\n");
            } while (choice != 1 && choice != 2); 
        }
        public static void InterFace(double bmi)
        {
            if(bmi != 1)
            {
                Console.WriteLine("\t\t\t\t\tFrom\tTo");
            }
            if (bmi == 1)
            {
                Console.WriteLine("\t\tThe BMI Table");
                Console.WriteLine("\t\t\t\t\tFrom\tTo");
                Console.WriteLine(" _______________________________________________________ ");
                Console.WriteLine("|\t\t\t\t\t\t\t|");
                Console.WriteLine("|Very severely underweight\t\t\t15\t|");
                Console.WriteLine("|Severely underweight\t\t\t15\t16\t|");
                Console.WriteLine("|Underweight\t\t\t\t16\t18.5\t|");
                Console.WriteLine("|Normal (healthy weight)\t\t18.5\t25\t|");
                Console.WriteLine("|Overweight\t\t\t\t25\t30\t|");
                Console.WriteLine("|Obese Class I (Moderately obese)\t30\t35\t|");
                Console.WriteLine("|Obese Class II (Severely obese)\t35\t40\t|");
                Console.WriteLine("|Obese Class III (Very severely obese)\t40\t\t|");
                Console.WriteLine("|_______________________________________________________|\n");
            }
            if(bmi < 15 && bmi != 1)
            {
                Console.WriteLine(" _______________________________________________________");
                Console.Write("|\t\t\t\t\t\t\t");
                Console.WriteLine("|You are here");
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Very severely underweight\t\t\t15\t");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("|<-------");
                Console.WriteLine("|Severely underweight\t\t\t15\t16\t|");
                Console.WriteLine("|Underweight\t\t\t\t16\t18.5\t|");
                Console.WriteLine("|Normal (healthy weight)\t\t18.5\t25\t|");
                Console.WriteLine("|Overweight\t\t\t\t25\t30\t|");
                Console.WriteLine("|Obese Class I (Moderately obese)\t30\t35\t|");
                Console.WriteLine("|Obese Class II (Severely obese)\t35\t40\t|");
                Console.WriteLine("|Obese Class III (Very severely obese)\t40\t\t|");
                Console.WriteLine("|_______________________________________________________|");
            }
            if (bmi < 16 && bmi > 15)
            {
                Console.WriteLine(" _______________________________________________________");
                Console.WriteLine("|\t\t\t\t\t\t\t|");
                Console.Write("|Very severely underweight\t\t\t15\t");
                Console.WriteLine("|You are here");
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Severely underweight\t\t\t15\t16\t");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("|<-------");
                Console.WriteLine("|Underweight\t\t\t\t16\t18.5\t|");
                Console.WriteLine("|Normal (healthy weight)\t\t18.5\t25\t|");
                Console.WriteLine("|Overweight\t\t\t\t25\t30\t|");
                Console.WriteLine("|Obese Class I (Moderately obese)\t30\t35\t|");
                Console.WriteLine("|Obese Class II (Severely obese)\t35\t40\t|");
                Console.WriteLine("|Obese Class III (Very severely obese)\t40\t\t|");
                Console.WriteLine("|_______________________________________________________|");
            }
            if (bmi < 18.5 && bmi > 16)
            {
                Console.WriteLine(" _______________________________________________________");
                Console.WriteLine("|\t\t\t\t\t\t\t|");
                Console.WriteLine("|Very severely underweight\t\t\t15\t|");
                Console.Write("|Severely underweight\t\t\t15\t16\t");
                Console.WriteLine("|You are here");
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Underweight\t\t\t\t16\t18.5\t");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("|<-------");
                Console.WriteLine("|Normal (healthy weight)\t\t18.5\t25\t|");
                Console.WriteLine("|Overweight\t\t\t\t25\t30\t|");
                Console.WriteLine("|Obese Class I (Moderately obese)\t30\t35\t|");
                Console.WriteLine("|Obese Class II (Severely obese)\t35\t40\t|");
                Console.WriteLine("|Obese Class III (Very severely obese)\t40\t\t|");
                Console.WriteLine("|_______________________________________________________|");
            }
            if (bmi < 25 && bmi > 18.5)
            {
                Console.WriteLine(" _______________________________________________________");
                Console.WriteLine("|\t\t\t\t\t\t\t|");
                Console.WriteLine("|Very severely underweight\t\t\t15\t|");
                Console.WriteLine("|Severely underweight\t\t\t15\t16\t|");
                Console.Write("|Underweight\t\t\t\t16\t18.5\t");
                Console.WriteLine("|You are here");
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Normal (healthy weight)\t\t18.5\t25\t");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("|<-------");
                Console.WriteLine("|Overweight\t\t\t\t25\t30\t|");
                Console.WriteLine("|Obese Class I (Moderately obese)\t30\t35\t|");
                Console.WriteLine("|Obese Class II (Severely obese)\t35\t40\t|");
                Console.WriteLine("|Obese Class III (Very severely obese)\t40\t\t|");
                Console.WriteLine("|_______________________________________________________|");
            }
            if (bmi < 30 && bmi > 25)
            {
                Console.WriteLine(" _______________________________________________________");
                Console.WriteLine("|\t\t\t\t\t\t\t|");
                Console.WriteLine("|Very severely underweight\t\t\t15\t|");
                Console.WriteLine("|Severely underweight\t\t\t15\t16\t|");
                Console.WriteLine("|Underweight\t\t\t\t16\t18.5\t|");
                Console.Write("|Normal (healthy weight)\t\t18.5\t25\t");
                Console.WriteLine("|You are here");
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Overweight\t\t\t\t25\t30\t");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("|<-------");
                Console.WriteLine("|Obese Class I (Moderately obese)\t30\t35\t|");
                Console.WriteLine("|Obese Class II (Severely obese)\t35\t40\t|");
                Console.WriteLine("|Obese Class III (Very severely obese)\t40\t\t|");
                Console.WriteLine("|_______________________________________________________|");
            }
            if (bmi < 35 && bmi > 30)
            {
                Console.WriteLine(" _______________________________________________________");
                Console.WriteLine("|\t\t\t\t\t\t\t|");
                Console.WriteLine("|Very severely underweight\t\t\t15\t|");
                Console.WriteLine("|Severely underweight\t\t\t15\t16\t|");
                Console.WriteLine("|Underweight\t\t\t\t16\t18.5\t|");
                Console.WriteLine("|Normal (healthy weight)\t\t18.5\t25\t|");
                Console.Write("|Overweight\t\t\t\t25\t30\t");
                Console.WriteLine("|You are here");
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Obese Class I (Moderately obese)\t30\t35\t");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("|<-------");
                Console.WriteLine("|Obese Class II (Severely obese)\t35\t40\t|");
                Console.WriteLine("|Obese Class III (Very severely obese)\t40\t\t|");
                Console.WriteLine("|_______________________________________________________|");
            }
            if (bmi < 40 && bmi > 35)
            {
                Console.WriteLine(" _______________________________________________________");
                Console.WriteLine("|\t\t\t\t\t\t\t|");
                Console.WriteLine("|Very severely underweight\t\t\t15\t|");
                Console.WriteLine("|Severely underweight\t\t\t15\t16\t|");
                Console.WriteLine("|Underweight\t\t\t\t16\t18.5\t|");
                Console.WriteLine("|Normal (healthy weight)\t\t18.5\t25\t|");
                Console.WriteLine("|Overweight\t\t\t\t25\t30\t|");
                Console.Write("|Obese Class I (Moderately obese)\t30\t35\t"); 
                Console.WriteLine("|You are here");
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Obese Class II (Severely obese)\t35\t40\t");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("|<-------");
                Console.WriteLine("|Obese Class III (Very severely obese)\t40\t\t|");
                Console.WriteLine("|_______________________________________________________|");
            }
            if (bmi > 40)
            {
                Console.WriteLine(" _______________________________________________________");
                Console.WriteLine("|\t\t\t\t\t\t\t|");
                Console.WriteLine("|Very severely underweight\t\t\t15\t|");
                Console.WriteLine("|Severely underweight\t\t\t15\t16\t|");
                Console.WriteLine("|Underweight\t\t\t\t16\t18.5\t|");
                Console.WriteLine("|Normal (healthy weight)\t\t18.5\t25\t|");
                Console.WriteLine("|Overweight\t\t\t\t25\t30\t|");
                Console.WriteLine("|Obese Class I (Moderately obese)\t30\t35\t|");
                Console.Write("|Obese Class II (Severely obese)\t35\t40\t");
                Console.WriteLine("|You are here");
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Obese Class III (Very severely obese)\t40\t\t");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("|<-------");
                Console.WriteLine("|_______________________________________________________|");
            }
        }
        public static void ImperialCalc()
        {
            double weight, height;
            Console.Write("Enter your height(In): "); height = double.Parse(Console.ReadLine());
            Console.Write("Enter your weight(Ib): "); weight = double.Parse(Console.ReadLine());
            double bmi = weight/((height) * (height)) * 703;
            Console.Clear();
            Console.WriteLine("Your BMI is: " + "{0:0.0}",bmi);
            InterFace(bmi);
        }
        public static void MetricCalc()
        {
            double weight, height;
            Console.Write("Enter your height:(Cen) "); height = double.Parse(Console.ReadLine());
            Console.Write("Enter your weight(Kg): "); weight = double.Parse(Console.ReadLine());
            double bmi = weight / ((height / 100) * (height / 100));
            Console.Clear();
            Console.WriteLine("Your BMI is: " + "{0:0.0}", bmi);
            InterFace(bmi);
        }
    }
}
/*
Very severely underweight               15	 4
Severely underweight                15	16	 4
Underweight                         16	18.5 7
Normal (healthy weight)             18.5 25	 4
Overweight                          25	30	 7
Obese Class I (Moderately obese)    30	35	 1
Obese Class II (Severely obese)     35	40	 2
Obese Class III (Very severely obese)   40	 1 */
