using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Virtual_OS.MainSource
{
    public class JSCoreIO
    {
        public string ReadAllText(string file)
        {
            string retVal = "";
            try { retVal = File.ReadAllText(file); }
            catch (Exception e) { retVal = e.ToString(); }

            return retVal;
        }
        public string[] ReadAllLines(string filename)
        {
            return File.ReadAllLines(filename);
        }
        public byte[] ReadAllBytes(string filename)
        {
            return File.ReadAllBytes(filename);
        }
        [Obsolete("Use ReadAllLines[LineNumber] instead")]
        public string ReadLines(string filename, int line)
        {
            return File.ReadAllLines(filename)[line];
        }
        public string toString()
        {
            return "The System.IO implementation from the .NET Framework.";
        }
        public override string ToString()
        {
            return "The System.IO implementation from the .NET Framework.";
        }
        public StreamReader TextReader(string path)
        {
            return new StreamReader(path);
        }
        public void WriteAllLines(string path, string[] contents)
        {
            File.WriteAllLines(path, contents);
        }
        public void WriteAllBytes(string path, byte[] bytes)
        {
            File.WriteAllBytes(path, bytes);
        }
        public bool WriteAllText(string filename, string content)
        {
            bool retVal = false;
            try
            {
                File.WriteAllText(filename, content);

                retVal = true;
            }
            catch
            {
                retVal = false;
            }
            return retVal;
        }

    }
}
