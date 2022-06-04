using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace palindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //путь
            string inputpath = "D:\\solutionsForSpaceApp\\2041\\input.txt";
            string outputpath = "D:\\solutionsForSpaceApp\\2041\\output.txt";

            //создание файлов
            FileStream fs = new FileStream(inputpath, FileMode.OpenOrCreate);
            fs.Close();
            FileStream fsout = new FileStream(outputpath, FileMode.OpenOrCreate);
            fsout.Close();
            
            //запись в строку содержимогостроки файла
            string secondLine;
            using (var readersecond = new StreamReader(inputpath))
            {
                secondLine = readersecond.ReadLine();  // записываем в переменную
            }

            

            List<string> A = new List<string>();
            List<string> B = new List<string>();

            foreach (var line in secondLine)
            {
                A.Add(Convert.ToString(line));
                B.Add(Convert.ToString(line));
            }

            B.Reverse();



            double middle = A.Count/2;

            if(A.Count /2 !=0)
            {
                middle = Math.Floor(middle);
            }
            List<int> output = new List<int>();
            for (int i = 0; i <= middle; i++)
            {
                if (A[i] == B[i])
                {
                    output.Add(1);
                }
                else
                {
                    output.Add(0);
                }
            }
            string yeah = "Yes";
            string nope = "No";
            if(output.Contains(0))
            {
                File.WriteAllText(outputpath,nope);
            }
            else 
            {
                File.WriteAllText(outputpath, yeah);
            }
            
        }
    }
}