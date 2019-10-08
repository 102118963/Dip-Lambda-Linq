using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using FileParserNetStandard;

public delegate List<List<string>> Parser(List<List<string>> data);

namespace Delegate_Exercise {

    
    internal class Delegate_Exercise {
        private static Func<List<List<string>>, List<List<string>>> dataHandler;

        public static void Main(string[] args) {
            CsvHandler ch = new CsvHandler();
             
            

            ch.ProcessCsv("F:/YEAR 2/Dip-Seminar-Delegates-Lambda-Linq_Exercises/Files/Files/data.csv", "F:/YEAR 2/Dip-Seminar-Delegates-Lambda-Linq_Exercises/Files/Files/processed_data.csv", dataHandler);


            Console.ReadLine();
        }
    }
}