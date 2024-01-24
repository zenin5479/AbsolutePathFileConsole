using System;
using System.Diagnostics;
using System.IO;

namespace AbsolutePathFileConsole
{
   internal class Program
   {
      static void Main(string[] args)
      {
         // Абсолютный путь к файлу
         Console.WriteLine("Абсолютный путь к файлу в console application");
         // 1 вариант 
         string path1 = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
         Console.WriteLine(path1);
         // 2 вариант 
         string path2 = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
         Console.WriteLine(path2);
         // 3 вариант 
         ProcessModule path3 = Process.GetCurrentProcess().MainModule;
         if (path3 != null)
         {
            string path30 = Path.GetDirectoryName(path3.FileName);
            Console.WriteLine(path30);
         }
         // 4 вариант 
         string path4 = Directory.GetCurrentDirectory();
         Console.WriteLine(path4);
         // 5 вариант 
         string path5 = AppContext.BaseDirectory;
         Console.WriteLine(path5);
         // 6 вариант 
         string path6 = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory);
         Console.WriteLine(path6);
         // 7 вариант 
         if (AppDomain.CurrentDomain.BaseDirectory != null)
         {
            string path7 = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory);
            Console.WriteLine(path7);
         }

         // Задержка
         Console.ReadKey();
      }
   }
}