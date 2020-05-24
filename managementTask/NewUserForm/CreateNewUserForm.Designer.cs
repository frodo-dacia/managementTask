namespace managementTask
{
    partial class CreateNewUserForm
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
            this.label_Name = new System.Windows.Forms.Label();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.label_ID = new System.Windows.Forms.Label();
            this.textBox_UserID = new System.Windows.Forms.TextBox();
            this.label_Pass = new System.Windows.Forms.Label();
            this.textBox_Pass = new System.Windows.Forms.TextBox();
            this.label_Access = new System.Windows.Forms.Label();
            this.comboBox_AccessLevel = new System.Windows.Forms.ComboBox();
            this.button_Apply = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(37, 94);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(154, 21);
            this.label_Name.TabIndex = 2;
            this.label_Name.Text = "Nume utilizator: ";
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_UserName.Location = new System.Drawing.Point(197, 90);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(148, 26);
            this.textBox_UserName.TabIndex = 7;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID.Location = new System.Drawing.Point(37, 36);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(120, 21);
            this.label_ID.TabIndex = 8;
            this.label_ID.Text = "ID utilizator: ";
            // 
            // textBox_UserID
            // 
            this.textBox_UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_UserID.Location = new System.Drawing.Point(163, 32);
            this.textBox_UserID.Name = "textBox_UserID";
            this.textBox_UserID.Size = new System.Drawing.Size(148, 26);
            this.textBox_UserID.TabIndex = 9;
            this.textBox_UserID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_UserID_KeyPress);
            // 
            // label_Pass
            // 
            this.label_Pass.AutoSize = true;
            this.label_Pass.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Pass.Location = new System.Drawing.Point(37, 151);
            this.label_Pass.Name = "label_Pass";
            this.label_Pass.Size = new System.Drawing.Size(77, 21);
            this.label_Pass.TabIndex = 10;
            this.label_Pass.Text = "Parola: ";
            // 
            // textBox_Pass
            // 
            this.textBox_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Pass.Location = new System.Drawing.Point(120, 147);
            this.textBox_Pass.Name = "textBox_Pass";
            this.textBox_Pass.Size = new System.Drawing.Size(148, 26);
            this.textBox_Pass.TabIndex = 11;
            // 
            // label_Access
            // 
            this.label_Access.AutoSize = true;
            this.label_Access.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Access.Location = new System.Drawing.Point(37, 205);
            this.label_Access.Name = "label_Access";
            this.label_Access.Size = new System.Drawing.Size(150, 21);
            this.label_Access.TabIndex = 12;
            this.label_Access.Text = "Nivel de acces: ";
            // 
            // comboBox_AccessLevel
            // 
            this.comboBox_AccessLevel.AutoCompleteCustomSource.AddRange(new string[] {
            "TO DO",
            "IN PROGRESS",
            "CODE REVIEW",
            "DONE"});
            this.comboBox_AccessLevel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBox_AccessLevel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_AccessLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_AccessLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_AccessLevel.FormattingEnabled = true;
            this.comboBox_AccessLevel.Items.AddRange(new object[] {
            "ADMIN",
            "USER"});
            this.comboBox_AccessLevel.Location = new System.Drawing.Point(197, 201);
            this.comboBox_AccessLevel.Name = "comboBox_AccessLevel";
            this.comboBox_AccessLevel.Size = new System.Drawing.Size(168, 28);
            this.comboBox_AccessLevel.TabIndex = 13;
            // 
            // button_Apply
            // 
            this.button_Apply.Location = new System.Drawing.Point(98, 258);
            this.button_Apply.Name = "button_Apply";
            this.button_Apply.Size = new System.Drawing.Size(109, 37);
            this.button_Apply.TabIndex = 14;
            this.button_Apply.Text = "Apply";
            this.button_Apply.UseVisualStyleBackColor = true;
            this.button_Apply.Click += new System.EventHandler(this.button_Apply_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(353, 258);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(109, 37);
            this.button_Cancel.TabIndex = 15;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // CreateNewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 316);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Apply);
            this.Controls.Add(this.comboBox_AccessLevel);
            this.Controls.Add(this.label_Access);
            this.Controls.Add(this.textBox_Pass);
            this.Controls.Add(this.label_Pass);
            this.Controls.Add(this.textBox_UserID);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.textBox_UserName);
            this.Controls.Add(this.label_Name);
            this.Name = "CreateNewUserForm";
            this.Text = "CreateNewUserForm";
            this.Load += new System.EventHandler(this.CreateNewUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.TextBox textBox_UserID;
        private System.Windows.Forms.Label label_Pass;
        private System.Windows.Forms.TextBox textBox_Pass;
        private System.Windows.Forms.Label label_Access;
        private System.Windows.Forms.ComboBox comboBox_AccessLevel;
        private System.Windows.Forms.Button button_Apply;
        private System.Windows.Forms.Button button_Cancel;
    }
}