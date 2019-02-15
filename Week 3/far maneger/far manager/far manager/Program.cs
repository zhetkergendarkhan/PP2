using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.IO;



namespace Far_Manager

{

    class FarManager

    {

        public bool ok = true;

        public int cursor;

        int sz = 0;

        public FarManager()

        {

            cursor = 0;

        }

        public void Color(FileSystemInfo fs, int index)

        {

            if (index == cursor)

            {

                Console.BackgroundColor = ConsoleColor.White;

                Console.ForegroundColor = ConsoleColor.Black;

            }

            else if (fs.GetType() == typeof(DirectoryInfo))

            {

                Console.BackgroundColor = ConsoleColor.Black;

                Console.ForegroundColor = ConsoleColor.Green;

            }

            else

            {

                Console.BackgroundColor = ConsoleColor.Black;

                Console.ForegroundColor = ConsoleColor.Yellow;

            }

        }

        public void Up()

        {

            cursor--;

            if (cursor < 0)

            {

                cursor = sz - 1;



            }

        }

        public void Down()

        {

            cursor++;

            if (cursor == sz)

            {

                cursor = 0;



            }

        }

        public void Show(string path)

        {

            DirectoryInfo directory = new DirectoryInfo(path);

            DirectoryInfo[] dir = directory.GetDirectories();

            FileInfo[] fil = directory.GetFiles();

            List<FileSystemInfo> FileSystemInfos = new List<FileSystemInfo>();

            //FileSystemInfo[] FileSystemInfos = directory.GetFileSystemInfos();

            int index = 0;

            foreach (DirectoryInfo di in dir)

            {

                FileSystemInfos.Add(di);

            }

            foreach (FileSystemInfo fi in fil)

            {

                FileSystemInfos.Add(fi);

            }

            sz = FileSystemInfos.Count;





            foreach (FileSystemInfo fs in FileSystemInfos)

            {

                if (ok && fs.Name.StartsWith("."))

                {

                    sz--;

                    continue;

                }

                this.Color(fs, index);

                Console.WriteLine((index + 1) + ". " + fs.Name);

                index++;

            }

        }

        public void Start(string path)

        {

            ConsoleKeyInfo consoleKey = Console.ReadKey();

            FileSystemInfo fs = null;



            while (true)

            {

                DirectoryInfo directory = new DirectoryInfo(path);

                DirectoryInfo[] dir = directory.GetDirectories();

                FileInfo[] fil = directory.GetFiles();

                List<FileSystemInfo> FileSystemInfos = new List<FileSystemInfo>();

                //FileSystemInfo[] FileSystemInfos = directory.GetFileSystemInfos();

                int index = 0;

                foreach (DirectoryInfo di in dir)

                {

                    FileSystemInfos.Add(di);

                }

                foreach (FileSystemInfo fi in fil)

                {

                    FileSystemInfos.Add(fi);

                }



                Console.BackgroundColor = ConsoleColor.Black;

                Console.Clear();

                Show(path);

                consoleKey = Console.ReadKey();

                if (consoleKey.Key == ConsoleKey.Escape)

                {

                    try

                    {

                        cursor = 0;

                        directory = directory.Parent;

                        path = directory.FullName;

                    }

                    catch

                    {

                        continue;

                    }

                }

                if (consoleKey.Key == ConsoleKey.UpArrow)

                    Up();

                if (consoleKey.Key == ConsoleKey.DownArrow)

                    Down();

                if (consoleKey.Key == ConsoleKey.RightArrow)

                    ok = false;

                if (consoleKey.Key == ConsoleKey.LeftArrow)

                    ok = true;

                if (consoleKey.Key == ConsoleKey.Enter)

                {

                    int k = 0;

                    for (int i = 0; i < FileSystemInfos.Count; i++)

                    {

                        if (ok && FileSystemInfos[i].Name.StartsWith("."))

                            continue;

                        if (cursor == k)

                        {

                            fs = FileSystemInfos[i];

                            break;

                        }

                        k++;

                    }

                    if (fs.GetType() == typeof(DirectoryInfo))

                    {

                        cursor = 0;

                        directory = new DirectoryInfo(fs.FullName);

                        path = fs.FullName;

                    }

                    else if (fs.GetType() == typeof(FileInfo))

                    {

                        StreamReader sr = new StreamReader(fs.FullName);

                        string s = sr.ReadToEnd();

                        Console.Clear();

                        Console.BackgroundColor = ConsoleColor.Black;

                        Console.ForegroundColor = ConsoleColor.White;

                        Console.WriteLine(s);

                        Console.ReadKey();



                    }

                }

                if (consoleKey.Key == ConsoleKey.Delete)

                {

                    //Console.Clear();

                    //Console.WriteLine("Check");

                    int kk = 0;

                    for (int i = 0; i < FileSystemInfos.Count; i++)

                    {

                        if (ok && FileSystemInfos[i].Name.StartsWith("."))

                            continue;

                        if (cursor == kk)

                        {

                            fs = FileSystemInfos[i];

                            break;

                        }

                        kk++;

                    }

                    //Console.Clear();

                    //Console.WriteLine(fs.FullName);



                    if (fs.GetType() == typeof(DirectoryInfo))

                    {

                        (fs as DirectoryInfo).Delete(true);

                    }

                    else if (fs.GetType() == typeof(FileInfo))

                    {

                        (fs as FileInfo).Delete();

                    }

                }

                if (consoleKey.Key == ConsoleKey.F4)

                {

                    int kk = 0;

                    for (int i = 0; i < FileSystemInfos.Count; i++)

                    {

                        if (ok && FileSystemInfos[i].Name.StartsWith("."))

                            continue;

                        if (cursor == kk)

                        {

                            fs = FileSystemInfos[i];

                            break;

                        }

                        kk++;

                    }

                    Console.Clear();



                    Console.BackgroundColor = ConsoleColor.White;

                    Console.ForegroundColor = ConsoleColor.Black;

                    string s = Console.ReadLine();

                    if (fs.GetType() == typeof(DirectoryInfo))

                    {

                        string full = fs.FullName;

                        full = full.Remove(full.Length - fs.Name.Length);

                        new DirectoryInfo(fs.FullName).MoveTo(full + s);

                    }

                    else

                    {

                        string full = fs.FullName;

                        full = full.Remove(full.Length - fs.Name.Length);

                        new FileInfo(fs.FullName).MoveTo(full + s);

                    }

                }

            }

        }

    }





    class Program

    {

        static void Main(string[] args)

        {

            FarManager far = new FarManager();

            far.Start(@"C:\Users\Darkhan\Desktop\Discrete math");



        }

    }

}