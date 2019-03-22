using System;
using System.ComponentModel;
using System.Timers;
using System.Windows.Media;
using Newtonsoft.Json.Linq;
using WebSocketSharp;

namespace UICreator
{
    public class WebSocketCheck :INotifyPropertyChanged
    {
        WebSocket _client;
        System.Timers.Timer _checkConnection;
        System.Timers.Timer _taskTimmer;
        public event PropertyChangedEventHandler PropertyChanged;

        public string StatusColor
        {
            get => _b1;
            set
            {
                _b1 = value;
                OnPropertyChanged("StatusColor");
            }
        }

        string _sStatus;
        public string StatusText
        {
            get => _sStatus;
            set
            {
                _sStatus = value;
                OnPropertyChanged("StatusText");
            }
        }

        public static string URL => "ws://127.0.0.1:9011/";

        string _b1;
      

        public WebSocketCheck()
        {
            ConnectWs(URL);
            Console.WriteLine(_client.ReadyState);

            _checkConnection = new System.Timers.Timer();
            _checkConnection.Interval = 500;
            _checkConnection.Elapsed += CheckConnection_Elapsed;
            _checkConnection.Start();

            _taskTimmer = new System.Timers.Timer();
            _taskTimmer.Interval = 5000;
            _taskTimmer.Elapsed += TaskTimmer_Elapsed; ;
            _taskTimmer.Start();

            SolidColorBrush solidColor = new SolidColorBrush();
            solidColor.Color = Color.FromRgb(255,20, 0);
            StatusColor = solidColor.ToString();

            StatusText = "Not Connected";

        }

        private void TaskTimmer_Elapsed(object sender, ElapsedEventArgs e)
        {
            _taskTimmer.Stop();
            if (_client.ReadyState == WebSocketState.Open)
            {
                _client.Send("{\"status\":\"CLIENT_READY\"}");
            }
            _taskTimmer.Start();
        }

        private void CheckConnection_Elapsed(object sender, ElapsedEventArgs e)
        {
            _checkConnection.Stop();
            Console.WriteLine(_client.ReadyState);
            if (_client.ReadyState == WebSocketState.Connecting || _client.ReadyState == WebSocketState.Closed)
            {
                SolidColorBrush solidColor = new SolidColorBrush();
                solidColor.Color = Color.FromRgb(255, 0, 0);
                StatusColor = solidColor.ToString();
                StatusText = "Not Connected";
                ConnectWs(URL);

            }
            else
            {
                StatusText = "Connected";
                SolidColorBrush solidColor = new SolidColorBrush();
                solidColor.Color = Color.FromRgb(53, 253, 92);
                StatusColor = solidColor.ToString();
            }
            _checkConnection.Start();
        }

        public  void ConnectWs(string url)
        {
            _client = new WebSocket(url);
            _client.Connect();
            _client.OnMessage += Client_OnMessage;
        }

        private void Client_OnMessage(object sender, WebSocketSharp.MessageEventArgs e)
        {

            var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<JObject>(e.Data);
            if (obj["status"].ToString() == "NEW_TASK_ASSIGNED")
            {
                Console.WriteLine("Laputa says: " + obj.ToString());

            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}