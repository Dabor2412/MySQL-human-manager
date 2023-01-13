namespace HumanManager
{
    partial class InsertionForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textbox_first_name = new System.Windows.Forms.TextBox();
            this.textbox_last_name = new System.Windows.Forms.TextBox();
            this.textbox_birthdate = new System.Windows.Forms.TextBox();
            this.button_hinzufuegen = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textbox_first_name
            // 
            this.textbox_first_name.Location = new System.Drawing.Point(3, 31);
            this.textbox_first_name.Name = "textbox_first_name";
            this.textbox_first_name.Size = new System.Drawing.Size(125, 27);
            this.textbox_first_name.TabIndex = 0;
            // 
            // textbox_last_name
            // 
            this.textbox_last_name.Location = new System.Drawing.Point(139, 31);
            this.textbox_last_name.Name = "textbox_last_name";
            this.textbox_last_name.Size = new System.Drawing.Size(125, 27);
            this.textbox_last_name.TabIndex = 1;
            // 
            // textbox_birthdate
            // 
            this.textbox_birthdate.Location = new System.Drawing.Point(275, 31);
            this.textbox_birthdate.Name = "textbox_birthdate";
            this.textbox_birthdate.Size = new System.Drawing.Size(125, 27);
            this.textbox_birthdate.TabIndex = 2;
            // 
            // button_hinzufuegen
            // 
            this.button_hinzufuegen.Location = new System.Drawing.Point(3, 71);
            this.button_hinzufuegen.Name = "button_hinzufuegen";
            this.button_hinzufuegen.Size = new System.Drawing.Size(94, 29);
            this.button_hinzufuegen.TabIndex = 3;
            this.button_hinzufuegen.Text = "Hinzufügen";
            this.button_hinzufuegen.UseVisualStyleBackColor = true;
            this.button_hinzufuegen.Click += new System.EventHandler(this.insertMensch);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel1.Controls.Add(this.textbox_first_name, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_hinzufuegen, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textbox_birthdate, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textbox_last_name, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(28, 32);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.30435F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.69565F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(407, 110);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vorname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nachname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Geburtstag";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(31, 185);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(404, 29);
            this.progressBar1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AccessibleName = "textbox_first_name";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TextBox textbox_first_name;
        private TextBox textbox_last_name;
        private TextBox textbox_birthdate;
        private Button button_hinzufuegen;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ProgressBar progressBar1;
    }
}