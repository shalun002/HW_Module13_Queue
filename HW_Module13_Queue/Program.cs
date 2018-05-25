using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Module13_Queue
{
    class Program
    {
        public static string path = @"test.txt";

        #region Queue

        /*1.	Дан текстовый файл. За один просмотр файла напечатать элементы файла в следующем порядке: сначала все символы, отличные от цифр, а затем все цифры, сохраняя исходный порядок в каждой группе символов.*/

        static void Metod1()
        {
            Queue Q = new Queue();

            System.IO.StreamReader f = new System.IO.StreamReader(path, Encoding.Default);
            string[] split = f.ReadToEnd().Split();
            Console.WriteLine("=== Исходный файл ===\n");
            foreach (string s in split)
            {
                Console.Write(s + " ");
                Q.Enqueue(s);
            }
            Console.WriteLine("\n\n=== Все слова, начинающиеся с прописной буквы ===\n");
            foreach (string str in Q)
            {
                if (str != "" && str != " ")
                {
                    if (str.Substring(0, 1).ToUpper() == str.Substring(0, 1))


                        if (!System.Text.RegularExpressions.Regex.IsMatch(str.Substring(0, 1), "^\\d{1}"))
                        {
                            Console.Write(str + " ");
                        }

                }
            }

            Console.WriteLine("\n\n=== Все слова, начинающиеся со строчной буквы ===\n");
            foreach (string str in Q)
            {
                if (str != "" && str != " ")
                {
                    if (str.Substring(0, 1).ToLower() == str.Substring(0, 1))


                        if (!System.Text.RegularExpressions.Regex.IsMatch(str.Substring(0, 1), "^\\d{1}"))
                        {
                            Console.Write(str + " ");
                        }

                }
            }
            Console.ReadLine();

        }

        #endregion

        static void Main(string[] args)
        {
            Metod1();
        }
    }
}
