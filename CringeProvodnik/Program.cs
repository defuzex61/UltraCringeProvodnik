namespace CringeProvodnik
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int CurrentLine = 1;
           
            
            while (true)
            {
                Console.WriteLine("Программа показывает только папки(");
                int DiskNum = 1;
                DriveInfo[] drives = DriveInfo.GetDrives();
                foreach (DriveInfo drive in drives)
                {
                    if (DiskNum == CurrentLine)
                    {
                        Console.WriteLine(
                            $"--> {DiskNum}. Диск {drive.Name} Свободно {drive.AvailableFreeSpace / 1073741824} " +
                            $"Гб из {drive.TotalSize / 1073741824} Гб");
                    }
                    else
                    {
                        Console.WriteLine(
                            $"    {DiskNum}. Диск {drive.Name} Свободно {drive.AvailableFreeSpace / 1073741824} " +
                            $"Гб из {drive.TotalSize / 1073741824} Гб");
                    }
                    DiskNum++;
                }
               
              
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow )
                {
                    CurrentLine--;
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.DownArrow )
                {
                    CurrentLine++;
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    MainMenu.FileMenu(drives[CurrentLine - 1].Name);

                }
                else
                {
                    Console.Clear();
                }

            }
        }
        
    }
}