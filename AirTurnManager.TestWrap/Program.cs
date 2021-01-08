using CppSharp;
using CppSharp.AST;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTurnManager.TestWrap
{
    class Program
    {
        static void Main(string[] args)
        {


            var path = @"C:\Users\s.gavrilenko\Desktop\airturn-airturn-shared-components-b092f6eaa16c\src";

            var dirs = Directory.GetDirectories(path);
            foreach (var dir in dirs)
            {
                //Console.WriteLine(dir);
                var di = new DirectoryInfo(dir);
                var files = di.GetFiles("*.h");
                foreach (var file in files)
                {
                    //Console.WriteLine(file.DirectoryName.Substring(file.DirectoryName.LastIndexOf(@"\")+1));
                    //Console.WriteLine(file);
                    var tw = new TestWrapper();
                    tw.HFileInfo = file;
                    tw.IncDirs = dirs;
                    ConsoleDriver.Run(tw);
                }


            }
            Console.WriteLine("done.");
            Console.ReadLine();
        }

        public class TestWrapper : ILibrary
        {
            public void Postprocess(Driver driver, ASTContext ctx)
            {

            }

            public void Preprocess(Driver driver, ASTContext ctx)
            {

            }

            public void SetupPasses(Driver driver)
            {

            }

            public void Setup(Driver driver)
            {
                var options = driver.Options;
                var catalog = HFileInfo.DirectoryName.Substring(HFileInfo.DirectoryName.LastIndexOf(@"\") + 1);
                var module = options.AddModule("AirTurnManager.Net.Api." + catalog);
                foreach (var dir in this.IncDirs)
                {
                    module.IncludeDirs.Add(dir);
                }
                module.Headers.Add(HFileInfo.FullName);
            }

            public FileInfo HFileInfo { get; set; }
            public string[] IncDirs { get; set; }

            // TODO testing file for correct wrapping
            //public Driver Config(FileInfo fileInfo)
            //{


            //}
        }
    }
}
