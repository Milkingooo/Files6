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
                string[] lines = File.ReadAllLines("input.txt");

                string[] razmer = lines[0].Split(' ');
                int rows = int.Parse(razmer[0]);
                int cols = int.Parse(razmer[1]);

                int[,] matrix = new int[rows, cols];

                // Заполнение матрицы
                for (int i = 0; i < rows; i++)
                {
                    string[] row = lines[i + 1].Split(' ');
                    for (int j = 0; j < cols; j++)
                    {
                        matrix[i, j] = int.Parse(row[j]);
                    }
                }
                int count = 0; 

                //Нахождние удвоенных чисел
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (matrix[i, j] % 2 != 0)
                        {
                            matrix[i, j] = matrix[i, j] * 2;
                            count++;
                        }
                    }
                }
                using (StreamWriter writer = new StreamWriter("output.txt"))
                {
                    writer.WriteLine(count);
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            writer.Write(matrix[i, j] + " ");
                        }
                        writer.WriteLine();
                    }
                }

            }
            catch 
            {
            
            }
        }
    }
}
