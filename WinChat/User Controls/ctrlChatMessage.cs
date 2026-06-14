using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinChat.Properties;

namespace WinChat.User_Controls
{
    public partial class ctrlChatMessage : UserControl
    {
        public ctrlChatMessage()
        {
            InitializeComponent();
        }

        public enum ChatType { User1, User2 };

        private ChatType _CurrentUser = ChatType.User2;

        public ChatType CurrentChat
        {
            get { return _CurrentUser; }
            set 
            {
                _CurrentUser = value;

            }
        
        }

        public void SendMessage(string Message)
        {
            CalculatingMessageSize(Message);
            lblTime.Text = DateTime.Now.ToString("t");
        }

        public bool Sender = false;


        private void CalculatingMessageSize(string message)
        {
            lblMessage.MaximumSize = new Size(350, 0);

            lblMessage.Text = message;

            if (!Sender)// current user
            {
                // الصورة على اليمين
                pbIconUser.Location = new Point(this.Width - pbIconUser.Width - 10,25);
                    
                // الرسالة قبل الصورة
                lblMessage.Location = new Point(pbIconUser.Left - lblMessage.Width - 10,25);
                    
                // الوقت فوق الرسالة
                lblTime.Location = new Point(lblMessage.Left - lblTime.Width, lblMessage.Bottom + 2);


                pbIconUser.Image = Resources.user;

                lblMessage.ForeColor = SystemColors.ControlText;
                lblMessage.BackColor = SystemColors.ActiveCaption;

            }
            else //Sender
            {
                // الصورة على اليسار
                pbIconUser.Location = new Point(10, 25);

                // الرسالة بعد الصورة
                lblMessage.Location = new Point(pbIconUser.Right + 10,25);
                    
                // الوقت فوق الرسالة
                lblTime.Location = new Point(lblMessage.Right , lblMessage.Bottom + 2);

                pbIconUser.Image = Resources.user_2;

                lblMessage.ForeColor = SystemColors.Window;
                lblMessage.BackColor = SystemColors.ControlText;

            }

            // تكبير الـ UserControl حسب ارتفاع الرسالة
            this.Height = Math.Max(pbIconUser.Bottom,lblMessage.Bottom) + 20;
                
                
        }




        //private void CalculatingMessageSize(string message)
        //{
        //    lblMessage.MaximumSize = new Size(350, 0);

        //    lblMessage.Text = message;

        //    if (_CurrentUser == ChatType.User1)// current user
        //    {
        //        // الصورة على اليمين
        //        pbIconUser.Location = new Point(this.Width - pbIconUser.Width - 10, 25);

        //        // الرسالة قبل الصورة
        //        lblMessage.Location = new Point(pbIconUser.Left - lblMessage.Width - 10, 25);

        //        // الوقت فوق الرسالة
        //        lblTime.Location = new Point(lblMessage.Left, lblMessage.Bottom + 2);


        //    }
        //    else //Sender
        //    {
        //        // الصورة على اليسار
        //        pbIconUser.Location = new Point(10, 25);

        //        // الرسالة بعد الصورة
        //        lblMessage.Location = new Point(pbIconUser.Right + 10, 25);

        //        // الوقت فوق الرسالة
        //        lblTime.Location = new Point(lblMessage.Right - lblTime.Width, lblMessage.Bottom + 2);

        //    }

        //    // تكبير الـ UserControl حسب ارتفاع الرسالة
        //    this.Height = Math.Max(pbIconUser.Bottom, lblMessage.Bottom) + 20;


        //}


    }
}
