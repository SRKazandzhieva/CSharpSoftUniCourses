using System;

namespace _06.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double result = 0;

            // „+“, „-“, „*“, „/“, „%“
            // If is „+“, „-“, „*“  result and is it odd or even --> „%“
            if (operation == "+" || operation == "-" || operation == "*")
            {
                string type = "";
                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;

                    case "-":
                        result = num1 - num2;
                        break;

                    case "*":
                        result = num1 * num2;
                        break;

                }
                if (result % 2 == 0)
                {
                    type = "even";
                }
                else
                {
                    type = "odd";
                }
                Console.WriteLine($"{num1} {operation} {num2} = {result} - {type}");
            }
           
            else if (operation == "/" && num2 != 0)
            {
                result = (double) num1 / num2;
                Console.WriteLine($"{num1} {operation} {num2} = {result:f2}");
                
            }
            else if (operation == "%" && num2 != 0)
            {
                // if is  „%“ --> rest
                result = num1 % num2;
                Console.WriteLine($"{num1} {operation} {num2} = {result}");

            }
            else
            {
                // if num2 is = 0 special case
                Console.WriteLine($"Cannot divide {num1} by zero");
            }
            
        }
    }
}

