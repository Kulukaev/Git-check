using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace lesson7
{
    interface ILogger
    {
        public void LogInfo(string message)
        {
        }
        public void LogWarning(string message)
        {
        }
        public void LogError(string message, Exception ex)
        {
        }
    }

    class LocalFileLogger<T> : ILogger
    {
        string FileWay;
        public LocalFileLogger(string fileway)
        {
            FileWay = fileway;
        }

        public void LogInfo(string message)
        {
            using StreamWriter fs = new StreamWriter(FileWay, true); ;
            fs.WriteLine($"[Info]: [{typeof(T).Name}] : {message}");
        }

        public void LogWarning(string message)
        {
            using StreamWriter fs = new StreamWriter(FileWay, true);
            fs.WriteLine($"[Warning]: [{typeof(T).Name}] : {message}");
        }

        public void LogError(string message, Exception ex)
        {
            using StreamWriter fs = new StreamWriter(FileWay, true);
            fs.WriteLine($"[Error] : [{typeof(T).Name}] : {message}. {ex.Message}");
        }
    }
}
