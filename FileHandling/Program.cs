//using System;
//using System.IO;

//namespace FileHandling
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string filepath= @"C:\Users\somesh\OneDrive\Desktop\D1.txt";

//            //Creating a path
//            using (StreamWriter sw = new StreamWriter(filepath))
//            {
//                // writing a content in a file
//                sw.WriteLine("Hello, this is written to the file!");
//                sw.WriteLine("This is Somesh");
//                sw.WriteLine("From Kurnool");


//            }
//            System.Console.WriteLine("File created and written to: " + filepath);

//            //Reading a content from file

//            using (StreamReader sr = new StreamReader(filepath))
//            {
//                string content= sr.ReadToEnd();
//                Console.WriteLine("Content in the file\n "+ content);
//            }

//            //Checking a file exists or not

//            if(File.Exists(filepath))
//            {
//                Console.WriteLine("File exists at path "+ filepath);
//            }
//            else
//            {
//                Console.WriteLine("File doesn't exist");
//            }

//            //Deleting a File if it is Exist

//            //if (File.Exists(filepath))
//            //{
//            //    File.Delete(filepath);
//            //    Console.WriteLine("File is Deleted at path " + filepath);
//            //}
//            //else
//            //{
//            //    Console.WriteLine("File doesn't exist at path " + filepath);
//            //}
            
//        }
//    }
//}