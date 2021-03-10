using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace Polus.Task1
{
    public class FileRepository : IRepository
    {
        private string _path;
        private int _lengthWord;
        private Dictionary<string, string[]> _data;

        public FileRepository()
        {
            _data = new Dictionary<string, string[]>();
        }

        public Dictionary<string, string[]> GetData(string pathDir, int length)
        {
            if (string.IsNullOrWhiteSpace(pathDir))
                return null;
            if (!Directory.Exists(pathDir))
                return null;
            _path = pathDir;
            _lengthWord = length;

            StartReadDataFormFile();

            return _data;
        }

        private string[] GetFilesName() => Directory.GetFiles(_path, "*.txt");

        private void StartReadDataFormFile()
        {
            string[] filesName = GetFilesName();
            if (filesName == null || filesName.Length == 0)
                return;
            
            foreach (var item in filesName)
            {
                ParameterizedThreadStart threadStart = new ParameterizedThreadStart(ReadDataFormFile);
                Thread thread = new Thread(threadStart);
                thread.Start(item);
            }
        }

        private void ReadDataFormFile(object path)
        {
            if(path is string currentPath)
            {
                using(StreamReader sr = new StreamReader(currentPath, Encoding.UTF8))
                {
                    string[] data = null;

                    var readResult = sr.ReadToEnd();
                    data = readResult.Split(new char[]  
                         {' ', '\u000A', ',', '.', ';', ':', '-', '?', '/', '(', ')', '\r' }, 
                         StringSplitOptions.RemoveEmptyEntries);
                    data = data.Where(l => l.Length > _lengthWord).ToArray();
                    string filename = new FileInfo(currentPath).Name;
                    _data.Add(filename, data);
                }

            }
        }

        
    }
}
