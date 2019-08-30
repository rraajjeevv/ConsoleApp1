using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        #region
        private const string strFoleder = @"D:\Promote\";

        #endregion
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            try
            {
                string strFileName = strFoleder + "3GB_Test.txt";

                using (StreamWriter sW=File.CreateText(strFileName))
                {
                    for (int i=0; i<=2100000000; i++)
                    {
                        if (i>0 && i%50==0)
                        {
                            sW.WriteLine();
                        }
                        else
                        {
                            if (i>0 &&i % 5 == 0)
                            {
                                sW.Write(" ");
                            }
                        }


                        //sW.Write(i.ToString());

                        sW.Write(getRandomChar());
                    }
                }


                Console.WriteLine("File Created!");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message + "File Not Created!");
            }            
        }

        static char getRandomChar()
        {
            Random rnd = new Random();

            char randomChar = (char)rnd.Next('a', 'z');

            return randomChar;
        }

    }
}
