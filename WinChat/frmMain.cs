using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinChat.User_Controls;
using static WinChat.User_Controls.ctrlChatMessage;

namespace WinChat
{
    public partial class frmMain : Form
    {
        public ChatType CurrentUser;

        private FileSystemWatcher _watcher;

        List<clsMessage> Messages = new List<clsMessage>();

        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(ChatType CurrentUser)
        {
            InitializeComponent();
            this.CurrentUser = CurrentUser;
            this.Text = CurrentUser.ToString();
            watcher();
        }

        private void LoadControl(UserControl control)
        {
            flowLayoutPanel1.Controls.Clear();
            control.Dock = DockStyle.Fill;
            flowLayoutPanel1.Controls.Add(control);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (rtxtMessage.Text == string.Empty)
                return;

            

            ctrlChatMessage ctrlChatMessage = new ctrlChatMessage();

            ctrlChatMessage.CurrentChat = CurrentUser;

            ctrlChatMessage.SendMessage(rtxtMessage.Text);

            Messages.Add(new clsMessage(CurrentUser.ToString(), rtxtMessage.Text));

            SaveMessages(Messages);

            flowLayoutPanel1.Controls.Add(ctrlChatMessage);
            flowLayoutPanel1.ScrollControlIntoView(ctrlChatMessage);

            rtxtMessage.Clear();
        }

       
        private void rtxtMessage_TextChanged(object sender, EventArgs e)
        {

            int lineCount = rtxtMessage.GetLineFromCharIndex(rtxtMessage.TextLength) + 1;

            int lineHeight = TextRenderer.MeasureText("A", rtxtMessage.Font).Height;

            int newHeight = Math.Min(200, lineCount * lineHeight + 10);

            if (rtxtMessage.Height != newHeight)
            {
                int diff = newHeight - rtxtMessage.Height;

                rtxtMessage.Height = newHeight;
                rtxtMessage.Top -= diff;

                flowLayoutPanel1.Height -= diff;
            }

        }

        private void rtxtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Shift)
            {
                return;
            }

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                btnSend.PerformClick();
            }
        }

        private void watcher()
        {
            string directoryPath = AppDomain.CurrentDomain.BaseDirectory;

            _watcher = new FileSystemWatcher(directoryPath);
            _watcher.Filter = "Messages.json";
            _watcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.Size;
            _watcher.Changed += OnFileChanged;

            _watcher.EnableRaisingEvents = true;

        }

        private DateTime _lastRead = DateTime.MinValue;

        private void OnFileChanged(object sender, FileSystemEventArgs e)
        {
            // 1. منع التكرار: تجاهل التغييرات المتتالية في أقل من 500 مللي ثانية
            if (DateTime.Now - _lastRead < TimeSpan.FromMilliseconds(500)) return;
            _lastRead = DateTime.Now;

            // 2. تجنب قفل الملف: انتظر قليلاً حتى ينتهي النظام من الكتابة تماماً
            System.Threading.Thread.Sleep(100);

            // تحميل الرسائل
            Messages = LoadMessages();

            // التحقق من وجود رسائل لتجنب خطأ الكود المتجاوز للحدود (IndexOutOfRangeException)
            if (Messages == null || Messages.Count == 0) return;

            var lastMessage = Messages[Messages.Count - 1];

            if (lastMessage.Sender != CurrentUser.ToString())
            {
                ctrlChatMessage ctrlChatMessage = new ctrlChatMessage();

                // تحديد نوع المحادثة
                ctrlChatMessage.CurrentChat = (lastMessage.Sender == ChatType.User2.ToString())
                    ? ChatType.User2
                    : ChatType.User1;

                //لازم احكيلو اني استقبلت الرسالة
                ctrlChatMessage.Sender = true;

                ctrlChatMessage.SendMessage(lastMessage.Message);

                // إضافة العنصر للواجهة بأمان من خيط آخر
                flowLayoutPanel1.Invoke(new Action(() =>
                {
                    flowLayoutPanel1.Controls.Add(ctrlChatMessage);
                    // اختياري: النزول التلقائي لآخر رسالة
                    flowLayoutPanel1.ScrollControlIntoView(ctrlChatMessage);
                }));
            }




        }

       

        private List<clsMessage> LoadMessages(string path = "Messages.json")
        {
            if (!File.Exists(path))
                return new List<clsMessage>();

            string json = File.ReadAllText(path);

            if (string.IsNullOrWhiteSpace(json))
                return new List<clsMessage>();

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<clsMessage>));

            using (MemoryStream stream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(json)))
            {
                return (List<clsMessage>)serializer.ReadObject(stream);
            }
        }


        private void SaveMessages(List<clsMessage> messages, string path = "Messages.json")
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<clsMessage>));

            using (MemoryStream stream = new MemoryStream())
            {
                serializer.WriteObject(stream, messages);
                string json = System.Text.Encoding.UTF8.GetString(stream.ToArray());

                File.WriteAllText(path, json);
            }
        }



    }
}
