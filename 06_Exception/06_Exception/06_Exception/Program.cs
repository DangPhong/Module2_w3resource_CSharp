using System;
using System.IO;
namespace _06_Exception_IO
{
    //input 
    // 5  --> n
    //5 9 4 8 10  --> arrA sx tăng dần --> output 
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream
    ($"D:\\Module2_Clone\\Module2_w3resource_CSharp\\06_Exception\\06_Exception\\" +
    $"Log_{DateTime.Now.ToString("dd_MM_yyyy")}.txt", FileMode.Append);
            Console.WriteLine("Nhap a: ");
            try
            {
                Console.WriteLine("input a: ");
                var a = int.Parse(Console.ReadLine());
                Console.WriteLine("input b: ");
                var b = int.Parse(Console.ReadLine());
                Console.WriteLine("{0}/{1} ={2}", a, b, a / b);
            }
            catch (DivideByZeroException d)
            {
                using (StreamWriter writer = new StreamWriter(file))
                {
                    writer.WriteLine($"[Error]: {DateTime.Now.ToString("dd//MM//yyyy")}:{d.Message}");
                }
                Console.WriteLine(d.Message);
            }
            catch (Exception e)
            {
                using (StreamWriter writer = new StreamWriter(file))
                {
                    writer.WriteLine($"[Error]: {DateTime.Now.ToString("dd//MM//yyyy hh:mm:ss tt")}:{e.Message}");
                }
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("finally");
            }
            file.Close();

            FileStream file1 = new FileStream
   ($"D:\\Module2_Clone\\Module2_w3resource_CSharp\\06_Exception\\06_Exception\\" +
   $"Log_{DateTime.Now.ToString("dd_MM_yyyy")}.txt", FileMode.Open, FileAccess.Read);
            using (StreamReader reader = new StreamReader(file1))
            {
                var content = reader.ReadLine();
                Console.Write(content);
            }
        }
    }
}
