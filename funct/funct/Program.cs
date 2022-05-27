using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoloeApplication1
{
    class program
    {
        static void Main(string[] agrs)
        {
            FileStream fileStreamObj = new FileStream(@"C:\Users\ANI\OneDrive\Desktop\New folder\string.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderObj = new StreamReader(fileStreamObj);
            streamReaderObj.ReadLine();
            Console.WriteLine("StudId\tName\tMarks");
            List<string> tempData = new List<string>();
            while (streamReaderObj.Peek() > 0)
            {
                string line = streamReaderObj.ReadLine(); 
                string[] myStrs = line.Split(':');
                for (int i = 0; i < myStrs.Length; i++)
                {
                    tempData.Add(myStrs[i]);
                }
                if (myStrs.Contains("Sucess"))
                {
                    Sucess();
                }
                else if (myStrs.Contains("Failed"))
                {
                    Failed();
                }
                else if (myStrs.Contains("Missed"))
                {
                    Missed();
                }
                else if (myStrs.Contains("Dialled"))
                {
                    Dialled();
                }

                Console.WriteLine(myStrs[0] + "\t" + myStrs[1] + "\t" + myStrs[2]);   
            }
            Console.WriteLine("*********");
            static void Sucess() { }
            static void Failed() { }
            static void Missed() { }
            static void Dialled() { }

        }
    }
}

