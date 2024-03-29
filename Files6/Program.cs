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
                FileStream f = new FileStream("test.txt", FileMode.Create, FileAccess.ReadWrite);
                byte[] x = new byte[10];
                for (byte i = 0; i < 10; ++i)
                {
                    x[i] = (byte)(7 + i);
                }
                f.Write(x, 0, 10); // записывается 10 элементов массива
                int a, count = 0;
                f.Seek(0, SeekOrigin.Begin); // текущий указатель - на начало
                Console.WriteLine("Файл первый:");
                for (int i = 0; i < 10; i++)
                {
                    a = f.ReadByte();
                    Console.Write(a + " "); //контрольная печать считанного значения
                }
                Console.WriteLine();
                f.Close();


                Console.WriteLine();

                FileStream g = new FileStream("test2.txt", FileMode.Create, FileAccess.ReadWrite);
                byte[] d = new byte[10];
                for (byte i = 0; i < 10; ++i)
                {
                    d[i] = (byte)(0 + i*2);
                }
                g.Write(d, 0, 10); // записывается 10 элементов массива
                int ak;
                g.Seek(0, SeekOrigin.Begin); // текущий указатель - на начало
                Console.WriteLine("Файл второй:");
                for (int i = 0; i < 10; i++)
                {
                    ak = g.ReadByte();
                    if (ak % 2 == 0)
                    {
                        count++;
                    }
                    Console.Write(ak + " "); //контрольная печать считанного значения
                }
                Console.WriteLine();
                g.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                Console.WriteLine();

                FileStream f1 = new FileStream("test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                FileStream g1 = new FileStream("test2.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                FileStream s1 = new FileStream("test3.txt", FileMode.Create, FileAccess.ReadWrite);
                f1.Seek(0, SeekOrigin.Begin);
                g1.Seek(0, SeekOrigin.Begin);
                s1.Seek(0, SeekOrigin.Begin);
                byte[] fb = new byte[10];
                byte[] gb = new byte[10];
                byte[] sb = new byte[10];
                for (int i = 0; i < 10; i++)
                {
                    fb[i] = (byte)(f1.ReadByte());
                    gb[i] = (byte)(g1.ReadByte());
                }
                for (int i = 0; i < 10; i++)
                {
                    if (fb[i] > gb[i])
                    {
                        sb[i] = fb[i];
                    }
                    else if (fb[i] < gb[i])
                    {
                        sb[i] = gb[i];
                    }
                    else
                    {
                        sb[i] = gb[i];
                    }
                }
                s1.Write(sb, 0, 10);
                s1.Close();
                Console.WriteLine("Файл третий:");
                FileStream s2 = new FileStream("test3.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                s2.Seek(0, SeekOrigin.Begin);
                int ab;
                for (int i = 0; i < 10; i++)
                {
                    ab = s2.ReadByte();
                    Console.Write(ab + " ");
                }
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
