using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;


namespace Interface
{
   public class @pub 
    {
        public void readFile(string path)
        {
            try
            {
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None);
                StreamReader sr = new StreamReader(fs);
                while (true)
                {
                    string line = sr.ReadLine();
                }
                fs.Close();
                //sw.Close();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}