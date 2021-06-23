using System;
using System.Text;
using System.Threading;

namespace Lesson_GitLab
{
    class Program
    {
        static int counter;
        static string letters = "谢谢您的关注";
     
        static char GetChar()
        {
           return letters.ToCharArray()[new Random().Next(1, 6)]; // [new Random().Next(1, 6)] обращение по индексу
        }
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.UTF8;
            //Console.OutputEncoding = Encoding.ASCII;
            Console.OutputEncoding = Encoding.Unicode;
            //Console.OutputEncoding = Encoding.UTF7;
     


            counter = new Random().Next(1, 38);
            //Console.BackgroundColor = ConsoleColor.Black;
            //Console.ForegroundColor = ConsoleColor.Gray;
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGreen;


            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine($"counter = {counter}");
            if (counter <= 21)
            {
                counter = 22;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"counter = {counter}");
            }
            for (int i = 0; i < counter; i++)
            {
            
            if (counter > 21)
            {
                    for (int a = 0; a < 21; a++)
                    {
                     
                        Thread.Sleep(3);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(" 你好!\b ");
                        Thread.Sleep(3);
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write(GetChar());
                       
                    }
            }

            if (counter > 165)
            {
                    for (int b = 0; b < 165; b++)
                    {
                        Console.Write(GetChar());
                        Console.Write("\a  谢谢您的关注 "); //Благодарю за внимание!
                    } 
            }
            if (counter > 498)
            {
                    for (int c = 0; c < 498; c++)
                    {
                        Console.Write(" 您明天晚上干什么?\a  ");
                        Console.Write(GetChar());
                    }
            }
            }

            //Delay
            Console.ReadKey();
        }
    }
}
