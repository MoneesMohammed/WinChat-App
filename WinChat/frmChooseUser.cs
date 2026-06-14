using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WinChat.User_Controls.ctrlChatMessage;

namespace WinChat
{
    public partial class frmChooseUser : Form
    {
        public ChatType CurrentUser = ChatType.User1;

        public frmChooseUser()
        {
            InitializeComponent();
            cbChooseUser.SelectedIndex = 0;
        }

        private void btnConfirmation_Click(object sender, EventArgs e)
        {
            if (cbChooseUser.Text == "User1")
            {
                CurrentUser = ChatType.User1;
            }
            else
            {
                CurrentUser = ChatType.User2;
            }

            frmMain main = new frmMain(CurrentUser);
            main.ShowDialog();

        }
    }
}
