namespace managementTask
{
    partial class EditTaskForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_Tip = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.label_Continut = new System.Windows.Forms.Label();
            this.label_Nota = new System.Windows.Forms.Label();
            this.label_Timp = new System.Windows.Forms.Label();
            this.textBox_Tip = new System.Windows.Forms.TextBox();
            this.textBox_Continut = new System.Windows.Forms.TextBox();
            this.textBox_Nota = new System.Windows.Forms.TextBox();
            this.textBox_Timp = new System.Windows.Forms.TextBox();
            this.button_Apply = new System.Windows.Forms.Button();
            this.comboBox_Status = new System.Windows.Forms.ComboBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // label_Tip
            // 
            this.label_Tip.AutoSize = true;
            this.label_Tip.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Tip.Location = new System.Drawing.Point(33, 27);
            this.label_Tip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Tip.Name = "label_Tip";
            this.label_Tip.Size = new System.Drawing.Size(58, 26);
            this.label_Tip.TabIndex = 1;
            this.label_Tip.Text = "Tip: ";
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Status.Location = new System.Drawing.Point(33, 87);
            this.label_Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(91, 26);
            this.label_Status.TabIndex = 2;
            this.label_Status.Text = "Status: ";
            // 
            // label_Continut
            // 
            this.label_Continut.AutoSize = true;
            this.label_Continut.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Continut.Location = new System.Drawing.Point(33, 146);
            this.label_Continut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Continut.Name = "label_Continut";
            this.label_Continut.Size = new System.Drawing.Size(112, 26);
            this.label_Continut.TabIndex = 3;
            this.label_Continut.Text = "Continut: ";
            // 
            // label_Nota
            // 
            this.label_Nota.AutoSize = true;
            this.label_Nota.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nota.Location = new System.Drawing.Point(33, 254);
            this.label_Nota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Nota.Name = "label_Nota";
            this.label_Nota.Size = new System.Drawing.Size(73, 26);
            this.label_Nota.TabIndex = 4;
            this.label_Nota.Text = "Nota: ";
            // 
            // label_Timp
            // 
            this.label_Timp.AutoSize = true;
            this.label_Timp.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Timp.Location = new System.Drawing.Point(33, 310);
            this.label_Timp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Timp.Name = "label_Timp";
            this.label_Timp.Size = new System.Drawing.Size(157, 26);
            this.label_Timp.TabIndex = 5;
            this.label_Timp.Text = "Timp estimat: ";
            // 
            // textBox_Tip
            // 
            this.textBox_Tip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Tip.Location = new System.Drawing.Point(107, 27);
            this.textBox_Tip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Tip.Name = "textBox_Tip";
            this.textBox_Tip.Size = new System.Drawing.Size(168, 30);
            this.textBox_Tip.TabIndex = 6;
            // 
            // textBox_Continut
            // 
            this.textBox_Continut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Continut.Location = new System.Drawing.Point(169, 146);
            this.textBox_Continut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Continut.Multiline = true;
            this.textBox_Continut.Name = "textBox_Continut";
            this.textBox_Continut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Continut.Size = new System.Drawing.Size(475, 99);
            this.textBox_Continut.TabIndex = 8;
            this.textBox_Continut.TextChanged += new System.EventHandler(this.textBox_Continut_TextChanged);
            // 
            // textBox_Nota
            // 
            this.textBox_Nota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Nota.Location = new System.Drawing.Point(124, 254);
            this.textBox_Nota.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Nota.Name = "textBox_Nota";
            this.textBox_Nota.Size = new System.Drawing.Size(168, 30);
            this.textBox_Nota.TabIndex = 9;
            this.textBox_Nota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Nota_KeyPress);
            // 
            // textBox_Timp
            // 
            this.textBox_Timp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Timp.Location = new System.Drawing.Point(223, 304);
            this.textBox_Timp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Timp.Name = "textBox_Timp";
            this.textBox_Timp.Size = new System.Drawing.Size(168, 30);
            this.textBox_Timp.TabIndex = 10;
            this.textBox_Timp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Timp_KeyPress);
            // 
            // button_Apply
            // 
            this.button_Apply.Location = new System.Drawing.Point(208, 368);
            this.button_Apply.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Apply.Name = "button_Apply";
            this.button_Apply.Size = new System.Drawing.Size(145, 46);
            this.button_Apply.TabIndex = 11;
            this.button_Apply.Text = "Apply";
            this.button_Apply.UseVisualStyleBackColor = true;
            this.button_Apply.Click += new System.EventHandler(this.button_Apply_Click);
            // 
            // comboBox_Status
            // 
            this.comboBox_Status.AutoCompleteCustomSource.AddRange(new string[] {
            "TO DO",
            "IN PROGRESS",
            "CODE REVIEW",
            "DONE"});
            this.comboBox_Status.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBox_Status.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Status.FormattingEnabled = true;
            this.comboBox_Status.Items.AddRange(new object[] {
            "TO DO",
            "IN PROGRESS",
            "CODE REVIEW",
            "DONE"});
            this.comboBox_Status.Location = new System.Drawing.Point(144, 87);
            this.comboBox_Status.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_Status.Name = "comboBox_Status";
            this.comboBox_Status.Size = new System.Drawing.Size(223, 33);
            this.comboBox_Status.TabIndex = 12;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(485, 368);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(145, 46);
            this.button_Cancel.TabIndex = 13;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // EditTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 439);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.comboBox_Status);
            this.Controls.Add(this.button_Apply);
            this.Controls.Add(this.textBox_Timp);
            this.Controls.Add(this.textBox_Nota);
            this.Controls.Add(this.textBox_Continut);
            this.Controls.Add(this.textBox_Tip);
            this.Controls.Add(this.label_Timp);
            this.Controls.Add(this.label_Nota);
            this.Controls.Add(this.label_Continut);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.label_Tip);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditTaskForm";
            this.Text = "EditTaskForm";
            this.Load += new System.EventHandler(this.EditTaskForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Tip;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.Label label_Continut;
        private System.Windows.Forms.Label label_Nota;
        private System.Windows.Forms.Label label_Timp;
        private System.Windows.Forms.TextBox textBox_Tip;
        private System.Windows.Forms.TextBox textBox_Continut;
        private System.Windows.Forms.TextBox textBox_Nota;
        private System.Windows.Forms.TextBox textBox_Timp;
        private System.Windows.Forms.Button button_Apply;
        private System.Windows.Forms.ComboBox comboBox_Status;
        private System.Windows.Forms.Button button_Cancel;
    }
}