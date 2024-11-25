using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace WorkFinderQu
{
    internal static class ManageFiles
    {
        public static string[] ReadFiles(string path)
        {
            string currentDirectory = Environment.CurrentDirectory;
            string matrixFile = System.IO.Path.Combine(currentDirectory, path);
            string filePath = Path.GetFullPath(matrixFile);
            string[] lines = Array.Empty<string>();

            if (File.Exists(filePath))
            {
                lines = File.ReadAllLines(filePath);
            }

            return lines;
        }
    }
}
