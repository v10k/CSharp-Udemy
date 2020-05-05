using System;
using System.IO;
using System.Collections.Generic;

namespace Course {
    class Program {
        static void Main(string[] args) {

            // Aula 1:

            //string sourcePath = @"c:\temp\file1.txt";
            //string targetPath = @"c:\temp\file2.txt";

            //try {
            //    FileInfo fileinfo = new FileInfo(sourcePath);
            //    fileinfo.CopyTo(targetPath);
            //    string[] lines = File.ReadAllLines(sourcePath);
            //    foreach (string line in lines) {
            //        Console.WriteLine(line);
            //    }
            //}
            //catch (IOException e) {
            //    Console.WriteLine("An error occurred");
            //    Console.WriteLine(e.Message);
            //}


            // Aula 2:
            //string path = @"c:\temp\file1.txt";
            //StreamReader sr = null;
            //try {
            //    sr = File.OpenText(path);
            //    while (!sr.EndOfStream) {
            //        string line = sr.ReadLine();
            //        Console.WriteLine(line);
            //    }
            //}
            //catch (IOException e) {
            //    Console.WriteLine($"An error occured {e.Message}");
            //}
            //finally {
            //    if (sr != null) sr.Close();
            //}

            // Aula 3:
            //string path = @"c:\temp\file1.txt";
            //try {
            //    using (StreamReader sr = File.OpenText(path)) {
            //        while (!sr.EndOfStream) {
            //            string line = sr.ReadLine();
            //            Console.WriteLine(line);
            //        }
            //    }
            //}
            //catch (IOException e) {
            //    Console.WriteLine($"An error occurred {e.Message}");
            //}

            // Aula 4:
            //string sourcePath = @"c:\temp\file1.txt";
            //string targetPath = @"c:\temp\file2.txt";

            //try {
            //    string[] lines = File.ReadAllLines(sourcePath);
            //    using(StreamWriter sw = File.AppendText(targetPath)) {
            //        foreach (string line in lines) {
            //            sw.WriteLine(line.ToUpper());
            //        }
            //    }
            //}
            //catch(IOException e) {
            //    Console.WriteLine($"An error occurred {e.Message}");
            //}

            // Aula 5
            //string path = @"c:\temp\myfolder";

            //try {
            //    IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
            //    Console.WriteLine("FOLDERS: ");
            //    foreach (string s in folders) {
            //        Console.WriteLine(s);
            //    }

            //    var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
            //    Console.WriteLine("FILES: ");
            //    foreach (string s in files) {
            //        Console.WriteLine(s);
            //    }

            //    Directory.CreateDirectory(path + "\\newfolder");
            //}
            //catch (IOException e) {
            //    Console.WriteLine($"An error occurred {e.Message}");
            //}

            // Aula 6

            string path = @"c:\temp\myfolder\file1.txt";

            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetDirectoryName " + Path.GetDirectoryName(path));
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());
        }
    }
}
