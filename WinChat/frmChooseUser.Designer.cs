namespace WinChat
{
    partial class frmChooseUser
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbChooseUser = new System.Windows.Forms.ComboBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnConfirmation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbChooseUser
            // 
            this.cbChooseUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChooseUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChooseUser.FormattingEnabled = true;
            this.cbChooseUser.Items.AddRange(new object[] {
            "User1",
            "User2"});
            this.cbChooseUser.Location = new System.Drawing.Point(163, 58);
            this.cbChooseUser.Name = "cbChooseUser";
            this.cbChooseUser.Size = new System.Drawing.Size(155, 33);
            this.cbChooseUser.TabIndex = 0;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblTime.Location = new System.Drawing.Point(159, 35);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(102, 20);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Choose User";
            // 
            // btnConfirmation
            // 
            this.btnConfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmation.Location = new System.Drawing.Point(163, 136);
            this.btnConfirmation.Name = "btnConfirmation";
            this.btnConfirmation.Size = new System.Drawing.Size(155, 45);
            this.btnConfirmation.TabIndex = 3;
            this.btnConfirmation.Text = "Confirmation";
            this.btnConfirmation.UseVisualStyleBackColor = true;
            this.btnConfirmation.Click += new System.EventHandler(this.btnConfirmation_Click);
            // 
            // frmChooseUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 275);
            this.Controls.Add(this.btnConfirmation);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.cbChooseUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmChooseUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbChooseUser;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnConfirmation;
    }
}