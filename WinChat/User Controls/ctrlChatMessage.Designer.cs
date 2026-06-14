namespace WinChat.User_Controls
{
    partial class ctrlChatMessage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTime = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pbIconUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblTime.Location = new System.Drawing.Point(499, 46);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(68, 20);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "4:36 AM";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.SystemColors.Window;
            this.lblMessage.Location = new System.Drawing.Point(513, 22);
            this.lblMessage.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(61, 25);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "Hello\r\n";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbIconUser
            // 
            this.pbIconUser.Image = global::WinChat.Properties.Resources.user_2;
            this.pbIconUser.Location = new System.Drawing.Point(573, 22);
            this.pbIconUser.Name = "pbIconUser";
            this.pbIconUser.Size = new System.Drawing.Size(66, 43);
            this.pbIconUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIconUser.TabIndex = 2;
            this.pbIconUser.TabStop = false;
            // 
            // ctrlChatMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.pbIconUser);
            this.Controls.Add(this.lblTime);
            this.Name = "ctrlChatMessage";
            this.Size = new System.Drawing.Size(639, 93);
            ((System.ComponentModel.ISupportInitialize)(this.pbIconUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox pbIconUser;
        private System.Windows.Forms.Label lblMessage;
    }
}
