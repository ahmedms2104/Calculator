// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        // إدخال الأرقام من المستخدم
        Console.Write("أدخل الرقم الأول: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("أدخل الرقم الثاني: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // إدخال العملية
        Console.Write("اختر العملية (+, -, *, /): ");
        string operation = Console.ReadLine();

        double result;

        // تنفيذ العملية الحسابية
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
            case "/":
                if (num2 != 0)
                    result = num1 / num2;
                else
                {
                    Console.WriteLine("خطأ: لا يمكن القسمة على الصفر");
                    return;
                }
                break;
            default:
                Console.WriteLine("عملية غير صالحة");
                return;
        }

        // عرض النتيجة
        Console.WriteLine($"النتيجة: {num1} {operation} {num2} = {result}");
    }
}

