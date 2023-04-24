using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace IO01
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "This is a sentence";
            // Crea fichero en el directorio del proyecto
            File.WriteAllText("file1.txt", text);

            string[] lines = { "this is the first line", "This is the second line"};
            // guarda lineas de texto
            File.WriteAllLines("file2.txt", lines);

            // obtengo los bytes
            string text2 = "Thi is a string";
            byte[] bytes = Encoding.UTF8.GetBytes(text2);
            File.WriteAllBytes("file3.txt", bytes);

            // 
            string text3 = File.ReadAllText("file1.txt");
            Console.WriteLine(text3);


            string[] lines2 = File.ReadAllLines("file2.txt");

            foreach (var line in lines2)
            {
                Console.WriteLine(line); 

            }

            byte[] data1 = File.ReadAllBytes("file3.txt");
            Console.WriteLine(Encoding.UTF8.GetString(data1));


            // writer
            StreamWriter writer = new StreamWriter("file5.txt");
            writer.WriteLine("Other lines");
            writer.WriteLine("some text");
            writer.Close();

            // reader
            StreamReader reader = new StreamReader("file5.txt");
            Console.WriteLine(reader.ReadToEnd());

            // 
            StreamReader reader2 = new StreamReader("file5.txt");
            string line6;
            while ((line6 = reader2.ReadLine()) != null)
            {
                Console.WriteLine(line6);
            }










            Console.ReadKey();
        }
    }
}
