namespace managementTask
{
    partial class CreateNewTaskForm
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
            this.label_Tip = new System.Windows.Forms.Label();
            this.textBox_Tip = new System.Windows.Forms.TextBox();
            this.label_Status = new System.Windows.Forms.Label();
            this.comboBox_Status = new System.Windows.Forms.ComboBox();
            this.label_Continut = new System.Windows.Forms.Label();
            this.textBox_Continut = new System.Windows.Forms.TextBox();
            this.label_Nota = new System.Windows.Forms.Label();
            this.textBox_Nota = new System.Windows.Forms.TextBox();
            this.label_Timp = new System.Windows.Forms.Label();
            this.textBox_Timp = new System.Windows.Forms.TextBox();
            this.label_TaskID = new System.Windows.Forms.Label();
            this.textBox_TaskID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_User = new System.Windows.Forms.ComboBox();
            this.button_Apply = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Tip
            // 
            this.label_Tip.AutoSize = true;
            this.label_Tip.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Tip.Location = new System.Drawing.Point(36, 127);
            this.label_Tip.Name = "label_Tip";
            this.label_Tip.Size = new System.Drawing.Size(49, 21);
            this.label_Tip.TabIndex = 2;
            this.label_Tip.Text = "Tip: ";
            // 
            // textBox_Tip
            // 
            this.textBox_Tip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Tip.Location = new System.Drawing.Point(104, 123);
            this.textBox_Tip.Name = "textBox_Tip";
            this.textBox_Tip.Size = new System.Drawing.Size(127, 26);
            this.textBox_Tip.TabIndex = 7;
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Status.Location = new System.Drawing.Point(36, 170);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(77, 21);
            this.label_Status.TabIndex = 8;
            this.label_Status.Text = "Status: ";
            // 
            // comboBox_Status
            // 
            this.comboBox_Status.AutoCompleteCustomSource.AddRange(new string[] {
            "TO DO",
            "IN PROGRESS",
            "CODE REVIEW",
            "DONE"});
            this.comboBox_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Status.FormattingEnabled = true;
            this.comboBox_Status.Items.AddRange(new object[] {
            "TO DO",
            "IN PROGRESS",
            "CODE REVIEW",
            "DONE"});
            this.comboBox_Status.Location = new System.Drawing.Point(119, 166);
            this.comboBox_Status.Name = "comboBox_Status";
            this.comboBox_Status.Size = new System.Drawing.Size(168, 28);
            this.comboBox_Status.TabIndex = 13;
            // 
            // label_Continut
            // 
            this.label_Continut.AutoSize = true;
            this.label_Continut.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Continut.Location = new System.Drawing.Point(36, 218);
            this.label_Continut.Name = "label_Continut";
            this.label_Continut.Size = new System.Drawing.Size(96, 21);
            this.label_Continut.TabIndex = 14;
            this.label_Continut.Text = "Continut: ";
            // 
            // textBox_Continut
            // 
            this.textBox_Continut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Continut.Location = new System.Drawing.Point(138, 218);
            this.textBox_Continut.Multiline = true;
            this.textBox_Continut.Name = "textBox_Continut";
            this.textBox_Continut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Continut.Size = new System.Drawing.Size(357, 81);
            this.textBox_Continut.TabIndex = 15;
            // 
            // label_Nota
            // 
            this.label_Nota.AutoSize = true;
            this.label_Nota.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nota.Location = new System.Drawing.Point(36, 324);
            this.label_Nota.Name = "label_Nota";
            this.label_Nota.Size = new System.Drawing.Size(62, 21);
            this.label_Nota.TabIndex = 16;
            this.label_Nota.Text = "Nota: ";
            // 
            // textBox_Nota
            // 
            this.textBox_Nota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Nota.Location = new System.Drawing.Point(104, 320);
            this.textBox_Nota.Name = "textBox_Nota";
            this.textBox_Nota.Size = new System.Drawing.Size(127, 26);
            this.textBox_Nota.TabIndex = 17;
            // 
            // label_Timp
            // 
            this.label_Timp.AutoSize = true;
            this.label_Timp.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Timp.Location = new System.Drawing.Point(36, 366);
            this.label_Timp.Name = "label_Timp";
            this.label_Timp.Size = new System.Drawing.Size(136, 21);
            this.label_Timp.TabIndex = 18;
            this.label_Timp.Text = "Timp estimat: ";
            // 
            // textBox_Timp
            // 
            this.textBox_Timp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Timp.Location = new System.Drawing.Point(178, 362);
            this.textBox_Timp.Name = "textBox_Timp";
            this.textBox_Timp.Size = new System.Drawing.Size(127, 26);
            this.textBox_Timp.TabIndex = 19;
            // 
            // label_TaskID
            // 
            this.label_TaskID.AutoSize = true;
            this.label_TaskID.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TaskID.Location = new System.Drawing.Point(35, 32);
            this.label_TaskID.Name = "label_TaskID";
            this.label_TaskID.Size = new System.Drawing.Size(85, 21);
            this.label_TaskID.TabIndex = 20;
            this.label_TaskID.Text = "Task ID: ";
            // 
            // textBox_TaskID
            // 
            this.textBox_TaskID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TaskID.Location = new System.Drawing.Point(119, 28);
            this.textBox_TaskID.Name = "textBox_TaskID";
            this.textBox_TaskID.Size = new System.Drawing.Size(127, 26);
            this.textBox_TaskID.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "User: ";
            // 
            // comboBox_User
            // 
            this.comboBox_User.AutoCompleteCustomSource.AddRange(new string[] {
            "TO DO",
            "IN PROGRESS",
            "CODE REVIEW",
            "DONE"});
            this.comboBox_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_User.FormattingEnabled = true;
            this.comboBox_User.Location = new System.Drawing.Point(104, 74);
            this.comboBox_User.Name = "comboBox_User";
            this.comboBox_User.Size = new System.Drawing.Size(168, 28);
            this.comboBox_User.TabIndex = 23;
            // 
            // button_Apply
            // 
            this.button_Apply.Location = new System.Drawing.Point(178, 417);
            this.button_Apply.Name = "button_Apply";
            this.button_Apply.Size = new System.Drawing.Size(109, 37);
            this.button_Apply.TabIndex = 24;
            this.button_Apply.Text = "Apply";
            this.button_Apply.UseVisualStyleBackColor = true;
            this.button_Apply.Click += new System.EventHandler(this.button_Apply_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(377, 417);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(109, 37);
            this.button_Cancel.TabIndex = 25;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // CreateNewTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 477);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Apply);
            this.Controls.Add(this.comboBox_User);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_TaskID);
            this.Controls.Add(this.label_TaskID);
            this.Controls.Add(this.textBox_Timp);
            this.Controls.Add(this.label_Timp);
            this.Controls.Add(this.textBox_Nota);
            this.Controls.Add(this.label_Nota);
            this.Controls.Add(this.textBox_Continut);
            this.Controls.Add(this.label_Continut);
            this.Controls.Add(this.comboBox_Status);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.textBox_Tip);
            this.Controls.Add(this.label_Tip);
            this.Name = "CreateNewTaskForm";
            this.Text = "CreateNewTaskForm";
            this.Load += new System.EventHandler(this.CreateNewTaskForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Tip;
        private System.Windows.Forms.TextBox textBox_Tip;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.ComboBox comboBox_Status;
        private System.Windows.Forms.Label label_Continut;
        private System.Windows.Forms.TextBox textBox_Continut;
        private System.Windows.Forms.Label label_Nota;
        private System.Windows.Forms.TextBox textBox_Nota;
        private System.Windows.Forms.Label label_Timp;
        private System.Windows.Forms.TextBox textBox_Timp;
        private System.Windows.Forms.Label label_TaskID;
        private System.Windows.Forms.TextBox textBox_TaskID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_User;
        private System.Windows.Forms.Button button_Apply;
        private System.Windows.Forms.Button button_Cancel;
    }
}