using System.Collections.Generic;
using System.Linq;

namespace FileParserNetStandard {
    public class DataParser {
        

        /// <summary>
        /// Strips any whitespace before and after a data value.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public List<List<string>> StripWhiteSpace(List<List<string>> data) {
            for (int i = 0; i < data.Count; i++)
            {
                for (int i2=0; i2<data[i].Count; i2++)
                {
                    data[i][i2] = data[i][i2].Trim();
                }
            }
            return data;
        }

        /// <summary>
        /// Strips quotes from beginning and end of each data value
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public List<List<string>> StripQuotes(List<List<string>> data) {

            for (int i = 0; i < data.Count; i++)
            {
                for (int i2 = 0; i2 < data[i].Count; i2++)
                {
                    data[i][i2] = data[i][i2].Trim('"');
                }
            }
            return data;
        }

    }
}