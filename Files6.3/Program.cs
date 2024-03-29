using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    internal class Class1
    {
        static void Main()
        {
            try
            {
                FileStream file = new FileStream("input.txt", FileMode.Create, FileAccess.ReadWrite);
                int str = 0, stolb = 0;
                Console.WriteLine("Введите размер матрицы: \n");
                str = Console.Read();
                stolb = Console.Read();
                file.WriteByte((byte)str);
                file.WriteByte((byte)stolb);
                file.Close();
                Console.ReadLine();

                FileStream file1 = new FileStream("input.txt", FileMode.Open, FileAccess.ReadWrite);
                file1.Seek(0, SeekOrigin.Begin); // текущий указатель - на начало
                int a;
                for (int i = 0; i < 2 ; i++)
                {
                    a = file1.ReadByte();
                    Console.Write((int)a + " "); //контрольная печать считанного значения
                }

            }
            catch 
            {
            
            }
        }
    }
}
