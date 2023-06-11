using System;

namespace ConsoleCalculator
{
    // تعریف کلاس ماشین حساب
    class Calculator
    {
        // تعریف متغیر خصوصی برای نگهداری نتیجه‌ی عملیات‌ها
        private double _result;

        // تعریف پراپرتی برای دسترسی به متغیر _result
        public double Result
        {
            get { return _result; }
            set { _result = value; }
        }

        // پیاده‌سازی متد جمع
        public void Add(double number)
        {
            _result += number;
        }

        // پیاده‌سازی متد تفریق
        public void Subtract(double number)
        {
            _result -= number;
        }

        // پیاده‌سازی متد ضرب
        public void Multiply(double number)
        {
            _result *= number;
        }

        // پیاده‌سازی متد تقسیم
        public void Divide(double number)
        {
            // بررسی خطای تقسیم بر صفر
            if (number == 0)
            {
                Console.WriteLine("Error: Division by zero.");
            }
            else
            {
                _result /= number;
            }
        }

        // پیاده‌سازی متد پاک کردن نتیجه‌ی قبلی
        public void Clear()
        {
            _result = 0;
        }
    }

    // تعریف کلاس برنامه اصلی
    class Program
    {
        static void Main(string[] args)
        {
            // ساخت یک شی از کلاس ماشین حساب
            Calculator calculator = new Calculator();

            // چاپ پیام خوش‌آمدگویی
            Console.WriteLine("Welcome to Console Calculator!");
            Console.WriteLine("Enter 'exit' to quit the program.\n");

            // حلقه‌ی اصلی برنامه
            while (true)
            {
                // درخواست ورود عملگر
                Console.Write("Enter an operator (+, -, *, /): ");
                string op = Console.ReadLine();

                // بررسی خروج از برنامه
                if (op == "exit")
                {
                    break;
                }

                // درخواست ورود عدد
                Console.Write("Enter a number: ");
                double number = double.Parse(Console.ReadLine());

                // اعمال عملیات مربوطه با استفاده از switch-case
                switch (op)
                {
                    case "+":
                        calculator.Add(number);
                        break;
                    case "-":
                        calculator.Subtract(number);
                        break;
                    case "*":
                        calculator.Multiply(number);
                        break;
                    case "/":
                        calculator.Divide(number);
                        break;
                    default:
                        Console.WriteLine("Error: Invalid operator.");
                        break;
                }

                // چاپ نتیجه‌ی فعلی
                Console.WriteLine("Result: " + calculator.Result + "\n");
            }
        }
    }
}