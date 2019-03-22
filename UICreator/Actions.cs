using System;
using System.Collections.Generic;
using System.Security.RightsManagement;
using System.Windows.Documents;
using DevExpress.Office;
using DevExpress.XtraPrinting.Native;
using UICreator;
using UICreator.Classes;

namespace UICreator
{


    public class MouseMove : ITasker, ICloneable
    {
        public void Initi()
        {
            throw new System.NotImplementedException();
        }

        public void Run()
        {
            throw new System.NotImplementedException();
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public class MouseDrag : ITasker, ICloneable
    {
        public void Initi()
        {
            throw new System.NotImplementedException();
        }

        public void Run()
        {
            throw new System.NotImplementedException();
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public class MouseClick : ITasker, ICloneable
    {
        public void Initi()
        {
            throw new System.NotImplementedException();
        }

        public void Run()
        {
            throw new System.NotImplementedException();
        }

        public object Clone()
        {
            return this.MemberwiseClone(); 
        }
    }

    public class TaskPair
    {
        public string Name { get; set; }
        public ITasker Task { get; set; }

        public TaskPair(string name,ITasker tasker)
        {
            Name = name;
            Task = tasker;
        }
        public ITasker ReturnTask()
        {
            return Task;
        }

        public ITasker this[string name]
        {
            get { return Task; }
            set
            {

            }

        }
    }

    public class ApplicationEntryPoint
    {
        public List<TaskPair> pairs;


        public  void Start()
        {

            pairs = new List<TaskPair>();
            pairs.Add(new TaskPair("MouseMove",new MouseMove()));
            pairs.Add(new TaskPair("MouseClick",new MouseClick()));
            pairs.Add(new TaskPair("MouseDrag",new MouseDrag()));


            
            




        }


        public void StartTask(string taskname)
        {
             pairs.Find(x => x.Name.Equals(taskname)).ReturnTask().Run();
            
        }







    }








    public class Actions
    {
        public void RunTask(TaskTypes Types)
        {
            switch (Types)
            {
                case TaskTypes.AckTask:
                    break;
                case TaskTypes.ApplicationRunning:
                    break;
                case TaskTypes.CreateFolder:
                    break;
                case TaskTypes.DeleteFile:
                    break;
                case TaskTypes.ExecuteKey:
                    break;
                case TaskTypes.FileExist:
                    break;
                case TaskTypes.FileTransfer:
                    break;
                case TaskTypes.FindIntent:
                    break;
                case TaskTypes.GetTask:
                    break;
                case TaskTypes.ImgDetect:
                    break;
                case TaskTypes.LaunchTask:
                    break;
                case TaskTypes.MouseClick:
                    break;
                case TaskTypes.MouseDrag:
                    break;
                case TaskTypes.MouseMove:
                    break;
                case TaskTypes.MoveFile:
                    break;
                case TaskTypes.OpenApplication:
                    break;
                case TaskTypes.PastValue:
                    break;
                case TaskTypes.RenameFile:
                    break;
                case TaskTypes.RequiredFile:
                    break;
                case TaskTypes.ScreenShot:
                    break;
                case TaskTypes.SelectApplication:
                    break;
                case TaskTypes.TaskComplete:
                    break;
                case TaskTypes.TaskDone:
                    break;
                case TaskTypes.UpdateTaskAttr:
                    break;

            }

        }
    }
}