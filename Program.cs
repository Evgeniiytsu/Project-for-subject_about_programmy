﻿using System;

namespace task_1_calculator
{
    class Program
    {
        

        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            double a;
            double b;
            double total;
            char oper;
            char again;

            Console.WriteLine("Введите первое число."); //ПРОВЕСТИ КОНВЕРТИРОВАНИЕ
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите оператор.");
            oper = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите второе число.");
            b = Convert.ToDouble(Console.ReadLine());


            if (oper == '+')

            {

                total = a+b;
                Console.WriteLine("Cумма " + a + " и " + b + " равна " + total + ".");

            }

            if (oper == '-') 
            {

                total = a-b;

                Console.WriteLine("Разность" + a + " и " + b + " равна " + total + ".");
            }

            if (oper == '*') 

            {
                total = a*b;

                Console.WriteLine("Произведение" + a + "и" + b + " равна " + total + ".");

            }


            if (oper == '/') 

            {

                total = a / b;

                Console.WriteLine("Деление" + a + "и" + b + " равна " + total + ".");

            }


            else
            {


                Console.WriteLine("Неизвестный оператор.");
            }

            {

                Console.WriteLine("Вы хотите продолжить работу с калькулятором? (д/н)");
                again = Convert.ToChar(Console.ReadLine());

            }
            






        }


    }


}


         

            










            
  
   
   
        