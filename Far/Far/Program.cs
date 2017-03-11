using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Far
{
    class Program
    {
        static void ShowInfo(DirectoryInfo directory, int cursor)
        {
            int index = 0;
            foreach (FileSystemInfo fInfo in directory.GetFileSystemInfos())
            {
                if (index == cursor)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                index++;

                if (fInfo.GetType() == typeof(FileInfo))
                    Console.Write("File:");
                else
                    Console.Write("Folder:");
                Console.WriteLine(fInfo.Name);
            }
        }
        static void Main(string[] args)
        {
            int cursor = 0;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.CursorVisible = false;
            DirectoryInfo directory = new DirectoryInfo(@"D:\");
            while (true)
            {
                Console.Clear();
                ShowInfo(directory, cursor);
                ConsoleKeyInfo pressed = Console.ReadKey();
                if (pressed.Key == ConsoleKey.UpArrow)
                {
                    if (cursor > 0)
                        cursor--;
                }
                if (pressed.Key == ConsoleKey.DownArrow)
                {
                    if (cursor < directory.GetFileSystemInfos().Length - 1)
                        cursor++;
                }
                if (pressed.Key == ConsoleKey.Enter)
                {
                    FileSystemInfo fi = directory.GetFileSystemInfos()[cursor];
                    directory = new DirectoryInfo(fi.FullName);
                }
                if (pressed.Key == ConsoleKey.Escape)
                {
                    try
                    {
                        directory = Directory.GetParent(directory.FullName);
                    }
                    catch (Exception e)
                    {

                    }
                }
                
            }
        }
    }
}
