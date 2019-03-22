using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UICreator.Classes
{
    public class Taskclass
    {
        public string Task { get; set; }
        public string Type { get; set; }
        public string Flow { get; set; }
        public DateTime Start { get; set; }
        public string Duration { get; set; }
        public string Result { get; set; }
        public string FilePath { get; set; }
        public string LogPath { get; set; }
        public ITasker PerformTask { get; set; }

        public Taskclass(string Task, string Type, string Flow, DateTime Start, string Duration, string result, string Filepath, string LogPath)
        {
            this.Task = Task;
            this.Type = Type;
            this.Flow = Flow;
            this.Start = Start;
            this.Duration = Duration;
            this.Result = result;
            this.FilePath = FilePath;
            this.LogPath = LogPath;
        }
    }
}