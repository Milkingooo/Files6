using System;
using System.IO;

namespace ConsoleApplication1
{
    class Class1
    {
        static void Main()
        {
            try
            {
                // работа с потоком байтов символы
                FileStream fchar = new FileStream("test1.txt", FileMode.Create, FileAccess.ReadWrite);
                char[] x = new char[10];
                Console.WriteLine("Введите 10 символов и * в любом месте");
                for (int i = 0; i < 10; ++i)
                {
                    x[i] = (char)Console.Read();
                    fchar.WriteByte((byte)x[i]); // записывается элемент массива
                }
                Console.ReadLine();
                int a, count = 0;
                fchar.Seek(0, SeekOrigin.Begin); // текущий указатель - на начало
                while ((a = fchar.ReadByte()) != '*')
                {
                    count++;
                }

                Console.WriteLine();
                Console.WriteLine("Текущая позиция в потоке " + fchar.Position);
                fchar.Close();
                Console.WriteLine();
                Console.WriteLine("количество символов до символа '*'");
                FileStream fchar1 = new FileStream("test1.txt", FileMode.Open, FileAccess.ReadWrite);
                fchar1.Seek(0, SeekOrigin.Begin);
                Console.WriteLine(count);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка работы с файлом: " + e.Message);
            }
        }
    }
}