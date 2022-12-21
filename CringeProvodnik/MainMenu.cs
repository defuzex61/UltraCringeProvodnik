using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CringeProvodnik
{
    internal class MainMenu
    {
        public static void FileMenu(string DirPath)
        {
            int CurrentLine = 0;
            while (true)
            {


                string[] allDirectories = Directory.GetDirectories(DirPath);
                string[] allFiles = Directory.GetFiles(DirPath);
                Console.WriteLine("Навигация - стрелки / вход - enter  / выход - escape ");
                Console.WriteLine(DirPath);
                Console.WriteLine("");

                foreach (string Dir in allDirectories)
                {
                    if (CurrentLine == Array.IndexOf(allDirectories, Dir))
                    {
                        Console.WriteLine($"--> {Dir}");
                    }
                    else
                    {
                        Console.WriteLine($"     {Dir}");
                    }
                }

                foreach (string file in allFiles)
                {
                    if (CurrentLine == (Array.IndexOf(allFiles, file) + allDirectories.Length))
                    {
                        Console.WriteLine($"--> {file}");
                    }
                    else
                    {
                        Console.WriteLine($"     {file}");
                    }
                }

                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow & CurrentLine > 0)
                {
                    CurrentLine--;
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.DownArrow & CurrentLine < (allDirectories.Length + allFiles.Length - 1))
                {
                    CurrentLine++;
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    Console.Clear();

                    if (CurrentLine <= allDirectories.Length)
                    {
                        MainMenu.FileMenu(allDirectories[CurrentLine]);
                       
                    }

                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    break;

                }

               

                else
                {
                    Console.Clear();
                }
              
            }


        }

       
        
    }
    
}
