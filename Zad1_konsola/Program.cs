using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMU.Math;
using System.IO;

namespace Zad1_konsola
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder bufor = new StringBuilder("Raport z badania");
            string autor = "Mateusz Błaszczak";
            Console.WriteLine("Rozwiązanie zadania 1, autor: {0}", autor);
            bufor.AppendLine("Rozwiązanie zadania 1, autor: " + autor);

            double[,] w = new double[,] { 
                { 0, 1, 2 }, 
                { 1, 0, -1 }, 
                { 2, -1, 0 }
            };

            double[] v0 = new double[] { -1, -1, -1 };

            Matrix matrixW = new Matrix(w); //macierz wag
            Matrix matrixV0 = new Matrix(v0,true); //wektor; true - wektor kolumnowy
            Matrix matrixVT, matrixUT, matrixVTm1;

            int time = 0;//czas dyskretny

            bool warunekSTOP = false;


            Console.WriteLine("Macierz wag:\n{0}", matrixW.ToString("F1", "\t", "\n"));
            bufor.AppendLine("Macierz wag:\n{0}" + matrixW.ToString("F1", "\t", "\n"));

            Console.WriteLine("Badanie wektora V(0):\n{0}", matrixV0.ToString("F1", "\t", "\n"));
            bufor.AppendLine("Badanie wektora V(0):\n" + matrixV0.ToString("F1", "\t", "\n"));

            matrixVTm1 = new Matrix(matrixV0.ToArray(), true);

            do
            {
                time++;
                Console.WriteLine("Krok nr {0}", time);
                bufor.AppendLine("Krok nr " + time);

                matrixUT = Matrix.Multiply(matrixW, matrixVTm1); //potencjał wejściowy
                Console.WriteLine("Potencjał wejściowy U({0}):\n{1}",time,matrixUT.ToString("F1","\t","\n"));
                bufor.AppendLine("Potencjał wejściowy U(" + time + "):\n" + matrixUT.ToString("F1", "\t", "\n"));

                matrixVT = new Matrix(matrixUT.ToBiPolar().ToArray(), true);
                Console.WriteLine("Potencjał wyjściowy U({0}):\n{1}", time, matrixVT.ToString("F1", "\t", "\n"));
                bufor.AppendLine("Potencjał wyjściowy U(" + time + "):\n" + matrixVT.ToString("F1", "\t", "\n"));

                matrixVTm1 = new Matrix(matrixVT.ToArray(), true);

                Console.ReadKey();

                

                if(time == 8)
                {
                    warunekSTOP = true;
                }

            } while (!warunekSTOP);

            StreamWriter plik = new StreamWriter("plik.txt");

            plik.WriteLine(bufor);
            plik.Close();

            Console.ReadKey();
        }
    }
}
