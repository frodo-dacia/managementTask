﻿namespace managementTask
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
            this.label_Timp = new System.Windows.Forms.Label();
            this.textBox_Timp = new System.Windows.Forms.TextBox();
            this.label_TaskID = new System.Windows.Forms.Label();
            this.textBox_TaskID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_User = new System.Windows.Forms.ComboBox();
            this.button_Apply = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.comboBox_Nota = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_Tip
            // 
            this.label_Tip.AutoSize = true;
            this.label_Tip.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Tip.Location = new System.Drawing.Point(48, 156);
            this.label_Tip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Tip.Name = "label_Tip";
            this.label_Tip.Size = new System.Drawing.Size(58, 26);
            this.label_Tip.TabIndex = 2;
            this.label_Tip.Text = "Tip: ";
            // 
            // textBox_Tip
            // 
            this.textBox_Tip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Tip.Location = new System.Drawing.Point(139, 151);
            this.textBox_Tip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Tip.Name = "textBox_Tip";
            this.textBox_Tip.Size = new System.Drawing.Size(168, 30);
            this.textBox_Tip.TabIndex = 7;
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Status.Location = new System.Drawing.Point(48, 209);
            this.label_Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(91, 26);
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
            this.comboBox_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Status.FormattingEnabled = true;
            this.comboBox_Status.Items.AddRange(new object[] {
            "TO DO",
            "IN PROGRESS",
            "CODE REVIEW",
            "DONE"});
            this.comboBox_Status.Location = new System.Drawing.Point(159, 204);
            this.comboBox_Status.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_Status.Name = "comboBox_Status";
            this.comboBox_Status.Size = new System.Drawing.Size(223, 33);
            this.comboBox_Status.TabIndex = 13;
            // 
            // label_Continut
            // 
            this.label_Continut.AutoSize = true;
            this.label_Continut.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Continut.Location = new System.Drawing.Point(48, 268);
            this.label_Continut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Continut.Name = "label_Continut";
            this.label_Continut.Size = new System.Drawing.Size(122, 26);
            this.label_Continut.TabIndex = 14;
            this.label_Continut.Text = "Descriere: ";
            // 
            // textBox_Continut
            // 
            this.textBox_Continut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Continut.Location = new System.Drawing.Point(184, 268);
            this.textBox_Continut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Continut.Multiline = true;
            this.textBox_Continut.Name = "textBox_Continut";
            this.textBox_Continut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Continut.Size = new System.Drawing.Size(475, 99);
            this.textBox_Continut.TabIndex = 15;
            this.textBox_Continut.TextChanged += new System.EventHandler(this.textBox_Continut_TextChanged);
            // 
            // label_Nota
            // 
            this.label_Nota.AutoSize = true;
            this.label_Nota.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nota.Location = new System.Drawing.Point(48, 399);
            this.label_Nota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Nota.Name = "label_Nota";
            this.label_Nota.Size = new System.Drawing.Size(73, 26);
            this.label_Nota.TabIndex = 16;
            this.label_Nota.Text = "Nota: ";
            // 
            // label_Timp
            // 
            this.label_Timp.AutoSize = true;
            this.label_Timp.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Timp.Location = new System.Drawing.Point(48, 450);
            this.label_Timp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Timp.Name = "label_Timp";
            this.label_Timp.Size = new System.Drawing.Size(157, 26);
            this.label_Timp.TabIndex = 18;
            this.label_Timp.Text = "Timp estimat: ";
            // 
            // textBox_Timp
            // 
            this.textBox_Timp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Timp.Location = new System.Drawing.Point(237, 446);
            this.textBox_Timp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Timp.Name = "textBox_Timp";
            this.textBox_Timp.Size = new System.Drawing.Size(168, 30);
            this.textBox_Timp.TabIndex = 19;
            this.textBox_Timp.TextChanged += new System.EventHandler(this.textBox_Timp_TextChanged);
            this.textBox_Timp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Timp_KeyPress);
            // 
            // label_TaskID
            // 
            this.label_TaskID.AutoSize = true;
            this.label_TaskID.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TaskID.Location = new System.Drawing.Point(47, 39);
            this.label_TaskID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TaskID.Name = "label_TaskID";
            this.label_TaskID.Size = new System.Drawing.Size(101, 26);
            this.label_TaskID.TabIndex = 20;
            this.label_TaskID.Text = "Task ID: ";
            // 
            // textBox_TaskID
            // 
            this.textBox_TaskID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TaskID.Location = new System.Drawing.Point(159, 34);
            this.textBox_TaskID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_TaskID.Name = "textBox_TaskID";
            this.textBox_TaskID.Size = new System.Drawing.Size(168, 30);
            this.textBox_TaskID.TabIndex = 21;
            this.textBox_TaskID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_TaskID_KeyPress);
            this.textBox_TaskID.Leave += new System.EventHandler(this.textBox_TaskID_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 26);
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
            this.comboBox_User.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBox_User.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_User.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_User.FormattingEnabled = true;
            this.comboBox_User.Location = new System.Drawing.Point(139, 91);
            this.comboBox_User.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_User.Name = "comboBox_User";
            this.comboBox_User.Size = new System.Drawing.Size(223, 33);
            this.comboBox_User.TabIndex = 23;
            // 
            // button_Apply
            // 
            this.button_Apply.Location = new System.Drawing.Point(237, 513);
            this.button_Apply.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Apply.Name = "button_Apply";
            this.button_Apply.Size = new System.Drawing.Size(145, 46);
            this.button_Apply.TabIndex = 24;
            this.button_Apply.Text = "Apply";
            this.button_Apply.UseVisualStyleBackColor = true;
            this.button_Apply.Click += new System.EventHandler(this.button_Apply_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(503, 513);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(145, 46);
            this.button_Cancel.TabIndex = 25;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // comboBox_Nota
            // 
            this.comboBox_Nota.AutoCompleteCustomSource.AddRange(new string[] {
            "TO DO",
            "IN PROGRESS",
            "CODE REVIEW",
            "DONE"});
            this.comboBox_Nota.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBox_Nota.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Nota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Nota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Nota.FormattingEnabled = true;
            this.comboBox_Nota.Items.AddRange(new object[] {
            "2IZI",
            "Not great not terrible",
            "Prety hard",
            "Hard as fuck"});
            this.comboBox_Nota.Location = new System.Drawing.Point(139, 394);
            this.comboBox_Nota.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_Nota.Name = "comboBox_Nota";
            this.comboBox_Nota.Size = new System.Drawing.Size(223, 33);
            this.comboBox_Nota.TabIndex = 26;
            // 
            // CreateNewTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 587);
            this.Controls.Add(this.comboBox_Nota);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Apply);
            this.Controls.Add(this.comboBox_User);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_TaskID);
            this.Controls.Add(this.label_TaskID);
            this.Controls.Add(this.textBox_Timp);
            this.Controls.Add(this.label_Timp);
            this.Controls.Add(this.label_Nota);
            this.Controls.Add(this.textBox_Continut);
            this.Controls.Add(this.label_Continut);
            this.Controls.Add(this.comboBox_Status);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.textBox_Tip);
            this.Controls.Add(this.label_Tip);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label label_Timp;
        private System.Windows.Forms.TextBox textBox_Timp;
        private System.Windows.Forms.Label label_TaskID;
        private System.Windows.Forms.TextBox textBox_TaskID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_User;
        private System.Windows.Forms.Button button_Apply;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.ComboBox comboBox_Nota;
    }
}