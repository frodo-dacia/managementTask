namespace managementTask
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label_UserName = new System.Windows.Forms.Label();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.button_Login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_serverIP = new System.Windows.Forms.TextBox();
            this.label_serverIP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.BackColor = System.Drawing.Color.Transparent;
            this.label_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UserName.ForeColor = System.Drawing.Color.White;
            this.label_UserName.Location = new System.Drawing.Point(72, 326);
            this.label_UserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(216, 39);
            this.label_UserName.TabIndex = 0;
            this.label_UserName.Text = "User Name : ";
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_UserName.Location = new System.Drawing.Point(275, 325);
            this.textBox_UserName.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(297, 38);
            this.textBox_UserName.TabIndex = 1;
            this.textBox_UserName.TextChanged += new System.EventHandler(this.textBox_UserName_TextChanged);
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.BackColor = System.Drawing.Color.Transparent;
            this.label_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.ForeColor = System.Drawing.Color.White;
            this.label_Password.Location = new System.Drawing.Point(72, 401);
            this.label_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(185, 39);
            this.label_Password.TabIndex = 2;
            this.label_Password.Text = "Password :";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Password.Location = new System.Drawing.Point(275, 401);
            this.textBox_Password.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(297, 38);
            this.textBox_Password.TabIndex = 3;
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.Color.Transparent;
            this.button_Login.BackgroundImage = global::managementTask.Properties.Resources.Webp_net_resizeimage;
            this.button_Login.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Login.Location = new System.Drawing.Point(175, 578);
            this.button_Login.Margin = new System.Windows.Forms.Padding(4);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(251, 44);
            this.button_Login.TabIndex = 4;
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(153, 78);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 185);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_serverIP
            // 
            this.textBox_serverIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_serverIP.Location = new System.Drawing.Point(275, 477);
            this.textBox_serverIP.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_serverIP.Name = "textBox_serverIP";
            this.textBox_serverIP.Size = new System.Drawing.Size(297, 38);
            this.textBox_serverIP.TabIndex = 7;
            // 
            // label_serverIP
            // 
            this.label_serverIP.AutoSize = true;
            this.label_serverIP.BackColor = System.Drawing.Color.Transparent;
            this.label_serverIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_serverIP.ForeColor = System.Drawing.Color.White;
            this.label_serverIP.Location = new System.Drawing.Point(72, 477);
            this.label_serverIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_serverIP.Name = "label_serverIP";
            this.label_serverIP.Size = new System.Drawing.Size(168, 39);
            this.label_serverIP.TabIndex = 6;
            this.label_serverIP.Text = "Server IP:";
            this.label_serverIP.Click += new System.EventHandler(this.label1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.textBox_serverIP);
            this.Controls.Add(this.label_serverIP);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.textBox_UserName);
            this.Controls.Add(this.label_UserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_UserName;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_serverIP;
        private System.Windows.Forms.Label label_serverIP;
    }
}

