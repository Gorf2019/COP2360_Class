using System;
public class Class
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");
        Console.WriteLine("Pls write two numbers");
        string userInput = Console.ReadLine();
        string userInput1 = Console.ReadLine();
        bool allSet;
        try
        {

            var T = Integral(userInput);
            var result = 0 / T;
            T = Integral(userInput1);
            result /= T;
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("In other words: Not an intenger");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("In other words: You cant divide by 0");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("In other words: An unexpeted error occur");
        }
        allSet = false;
        while (!allSet)
        {
            allSet = true;

            Console.WriteLine("To exit you must tell me what X is in: 1+X=2");
            try
            {
                var X = Integral(Console.ReadLine());
                if (X != 1) { throw new InvalidOperationException("Try again"); }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex);
                allSet = false;
            }

        }

    }

    static int Integral(string arg)
    {
        int conterArg = Convert.ToInt32(arg);
        return conterArg;
    }
}
