using System;
using System.Collections.Generic;
using System.Diagnostics;
using FileParserNetStandard;

namespace Delegate_Exercise {
    
    
    public class CsvHandler {

        FileHandler fh = new FileHandler();
        DataParser dp = new DataParser();
        /// <summary>
        /// Reads a csv file (readfile) and applies datahandling via dataHandler delegate and writes result as csv to writeFile.
        /// </summary>
        /// <param name="readFile"></param>
        /// <param name="writeFile"></param>
        /// <param name="dataHandler"></param>
        public void ProcessCsv(string readFile, string writeFile, Func<List<List<string>>, List<List<string>>> dataHandler) {


            //This looks like a mess but I swear it makes sense
            //fh.WriteFile(writeFile, ',', 
            //    dataHandler(
            //        StripHash(
            //            dp.StripWhiteSpace(
            //                dp.StripQuotes(
            //                    fh.ParseData( 
            //                        fh.ReadFile(readFile), ',')))))); //the comma is part of ParseData func

            //Wait thats all wrong

            
            
            dataHandler += dp.StripQuotes;
            dataHandler += dp.StripWhiteSpace;
            dataHandler += StripHash;
            //its just this
            fh.WriteFile(writeFile, ',', dataHandler(fh.ParseData(fh.ReadFile(readFile), ',')));
            // WriteFile taking patth as writeFile followed by datahandler delegate, followed by read file and parse data
        }

        public List<List<string>> StripHash(List<List<string>> data)
        {
            char[] toTrim = { '#' };
            for (int i = 0; i < data.Count; i++)
            {
                for (int i2 = 0; i2 < data[i].Count; i2++)
                {
                    data[i][i2] = data[i][i2].Trim(toTrim);
                }
            }
            return data;
        }

    }
}