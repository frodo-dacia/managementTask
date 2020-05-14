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
            this.textBox_Timp = new System.Windows.Forms.TextBox();
            this.button_Apply = new System.Windows.Forms.Button();
            this.comboBox_Status = new System.Windows.Forms.ComboBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.comboBox_Nota = new System.Windows.Forms.ComboBox();
            this.label_PontareOre = new System.Windows.Forms.Label();
            this.textBox_PontareOre = new System.Windows.Forms.TextBox();
            this.label_TotalOreLogate = new System.Windows.Forms.Label();
            this.textBox_TotalOrePontate = new System.Windows.Forms.TextBox();
            this.label_Comentarii = new System.Windows.Forms.Label();
            this.textBox_Comentarii = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label_Tip
            // 
            this.label_Tip.AutoSize = true;
            this.label_Tip.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Tip.Location = new System.Drawing.Point(25, 22);
            this.label_Tip.Name = "label_Tip";
            this.label_Tip.Size = new System.Drawing.Size(49, 21);
            this.label_Tip.TabIndex = 1;
            this.label_Tip.Text = "Tip: ";
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Status.Location = new System.Drawing.Point(25, 71);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(77, 21);
            this.label_Status.TabIndex = 2;
            this.label_Status.Text = "Status: ";
            // 
            // label_Continut
            // 
            this.label_Continut.AutoSize = true;
            this.label_Continut.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Continut.Location = new System.Drawing.Point(25, 119);
            this.label_Continut.Name = "label_Continut";
            this.label_Continut.Size = new System.Drawing.Size(107, 21);
            this.label_Continut.TabIndex = 3;
            this.label_Continut.Text = "Descriere: ";
            // 
            // label_Nota
            // 
            this.label_Nota.AutoSize = true;
            this.label_Nota.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nota.Location = new System.Drawing.Point(25, 206);
            this.label_Nota.Name = "label_Nota";
            this.label_Nota.Size = new System.Drawing.Size(62, 21);
            this.label_Nota.TabIndex = 4;
            this.label_Nota.Text = "Nota: ";
            // 
            // label_Timp
            // 
            this.label_Timp.AutoSize = true;
            this.label_Timp.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Timp.Location = new System.Drawing.Point(25, 252);
            this.label_Timp.Name = "label_Timp";
            this.label_Timp.Size = new System.Drawing.Size(136, 21);
            this.label_Timp.TabIndex = 5;
            this.label_Timp.Text = "Timp estimat: ";
            // 
            // textBox_Tip
            // 
            this.textBox_Tip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Tip.Location = new System.Drawing.Point(80, 22);
            this.textBox_Tip.Name = "textBox_Tip";
            this.textBox_Tip.Size = new System.Drawing.Size(127, 26);
            this.textBox_Tip.TabIndex = 6;
            // 
            // textBox_Continut
            // 
            this.textBox_Continut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Continut.Location = new System.Drawing.Point(127, 119);
            this.textBox_Continut.Multiline = true;
            this.textBox_Continut.Name = "textBox_Continut";
            this.textBox_Continut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Continut.Size = new System.Drawing.Size(357, 81);
            this.textBox_Continut.TabIndex = 8;
            this.textBox_Continut.TextChanged += new System.EventHandler(this.textBox_Continut_TextChanged);
            // 
            // textBox_Timp
            // 
            this.textBox_Timp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Timp.Location = new System.Drawing.Point(167, 247);
            this.textBox_Timp.Name = "textBox_Timp";
            this.textBox_Timp.Size = new System.Drawing.Size(127, 26);
            this.textBox_Timp.TabIndex = 10;
            this.textBox_Timp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Timp_KeyPress);
            // 
            // button_Apply
            // 
            this.button_Apply.Location = new System.Drawing.Point(149, 486);
            this.button_Apply.Name = "button_Apply";
            this.button_Apply.Size = new System.Drawing.Size(109, 37);
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
            this.comboBox_Status.Location = new System.Drawing.Point(108, 71);
            this.comboBox_Status.Name = "comboBox_Status";
            this.comboBox_Status.Size = new System.Drawing.Size(168, 28);
            this.comboBox_Status.TabIndex = 12;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(318, 486);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(109, 37);
            this.button_Cancel.TabIndex = 13;
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
            this.comboBox_Nota.Location = new System.Drawing.Point(80, 206);
            this.comboBox_Nota.Name = "comboBox_Nota";
            this.comboBox_Nota.Size = new System.Drawing.Size(168, 28);
            this.comboBox_Nota.TabIndex = 27;
            // 
            // label_PontareOre
            // 
            this.label_PontareOre.AutoSize = true;
            this.label_PontareOre.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PontareOre.Location = new System.Drawing.Point(25, 339);
            this.label_PontareOre.Name = "label_PontareOre";
            this.label_PontareOre.Size = new System.Drawing.Size(129, 21);
            this.label_PontareOre.TabIndex = 28;
            this.label_PontareOre.Text = "Pontare ore : ";
            // 
            // textBox_PontareOre
            // 
            this.textBox_PontareOre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PontareOre.Location = new System.Drawing.Point(149, 335);
            this.textBox_PontareOre.Name = "textBox_PontareOre";
            this.textBox_PontareOre.Size = new System.Drawing.Size(127, 26);
            this.textBox_PontareOre.TabIndex = 29;
            this.textBox_PontareOre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_PontareOre_KeyPress);
            // 
            // label_TotalOreLogate
            // 
            this.label_TotalOreLogate.AutoSize = true;
            this.label_TotalOreLogate.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotalOreLogate.Location = new System.Drawing.Point(25, 297);
            this.label_TotalOreLogate.Name = "label_TotalOreLogate";
            this.label_TotalOreLogate.Size = new System.Drawing.Size(169, 21);
            this.label_TotalOreLogate.TabIndex = 30;
            this.label_TotalOreLogate.Text = "Total ore pontate: ";
            // 
            // textBox_TotalOrePontate
            // 
            this.textBox_TotalOrePontate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TotalOrePontate.Location = new System.Drawing.Point(200, 293);
            this.textBox_TotalOrePontate.Name = "textBox_TotalOrePontate";
            this.textBox_TotalOrePontate.ReadOnly = true;
            this.textBox_TotalOrePontate.Size = new System.Drawing.Size(127, 26);
            this.textBox_TotalOrePontate.TabIndex = 31;
            // 
            // label_Comentarii
            // 
            this.label_Comentarii.AutoSize = true;
            this.label_Comentarii.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Comentarii.Location = new System.Drawing.Point(25, 385);
            this.label_Comentarii.Name = "label_Comentarii";
            this.label_Comentarii.Size = new System.Drawing.Size(123, 21);
            this.label_Comentarii.TabIndex = 32;
            this.label_Comentarii.Text = "Comentarii:  ";
            // 
            // textBox_Comentarii
            // 
            this.textBox_Comentarii.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Comentarii.Location = new System.Drawing.Point(149, 381);
            this.textBox_Comentarii.Multiline = true;
            this.textBox_Comentarii.Name = "textBox_Comentarii";
            this.textBox_Comentarii.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Comentarii.Size = new System.Drawing.Size(357, 81);
            this.textBox_Comentarii.TabIndex = 33;
            // 
            // EditTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 552);
            this.Controls.Add(this.textBox_Comentarii);
            this.Controls.Add(this.label_Comentarii);
            this.Controls.Add(this.textBox_TotalOrePontate);
            this.Controls.Add(this.label_TotalOreLogate);
            this.Controls.Add(this.textBox_PontareOre);
            this.Controls.Add(this.label_PontareOre);
            this.Controls.Add(this.comboBox_Nota);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.comboBox_Status);
            this.Controls.Add(this.button_Apply);
            this.Controls.Add(this.textBox_Timp);
            this.Controls.Add(this.textBox_Continut);
            this.Controls.Add(this.textBox_Tip);
            this.Controls.Add(this.label_Timp);
            this.Controls.Add(this.label_Nota);
            this.Controls.Add(this.label_Continut);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.label_Tip);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.TextBox textBox_Timp;
        private System.Windows.Forms.Button button_Apply;
        private System.Windows.Forms.ComboBox comboBox_Status;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.ComboBox comboBox_Nota;
        private System.Windows.Forms.Label label_PontareOre;
        private System.Windows.Forms.TextBox textBox_PontareOre;
        private System.Windows.Forms.Label label_TotalOreLogate;
        private System.Windows.Forms.TextBox textBox_TotalOrePontate;
        private System.Windows.Forms.Label label_Comentarii;
        private System.Windows.Forms.TextBox textBox_Comentarii;
    }
}