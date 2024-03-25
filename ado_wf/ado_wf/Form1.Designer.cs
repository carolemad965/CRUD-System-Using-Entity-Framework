namespace ado_wf
{
    partial class V
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
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_F = new System.Windows.Forms.TextBox();
            this.textBox_L = new System.Windows.Forms.TextBox();
            this.textBox_SS = new System.Windows.Forms.TextBox();
            this.textBox_A = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox_S = new System.Windows.Forms.TextBox();
            this.btn_I = new System.Windows.Forms.Button();
            this.btn_U = new System.Windows.Forms.Button();
            this.btn_D = new System.Windows.Forms.Button();
            this.textBox_B = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDept
            // 
            this.cmbDept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(114)))), ((int)(((byte)(123)))));
            this.cmbDept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Location = new System.Drawing.Point(59, 82);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(213, 33);
            this.cmbDept.TabIndex = 0;
            this.cmbDept.SelectedIndexChanged += new System.EventHandler(this.cmbDept_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(114)))), ((int)(((byte)(123)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(59, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(213, 169);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(425, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(426, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(427, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "SSN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(427, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(427, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Birth Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(426, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Department Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(426, 410);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Salary";
            // 
            // textBox_F
            // 
            this.textBox_F.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(114)))), ((int)(((byte)(123)))));
            this.textBox_F.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_F.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_F.Location = new System.Drawing.Point(617, 81);
            this.textBox_F.Name = "textBox_F";
            this.textBox_F.Size = new System.Drawing.Size(150, 22);
            this.textBox_F.TabIndex = 10;
            // 
            // textBox_L
            // 
            this.textBox_L.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(114)))), ((int)(((byte)(123)))));
            this.textBox_L.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_L.Location = new System.Drawing.Point(617, 140);
            this.textBox_L.Name = "textBox_L";
            this.textBox_L.Size = new System.Drawing.Size(150, 22);
            this.textBox_L.TabIndex = 11;
            // 
            // textBox_SS
            // 
            this.textBox_SS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(114)))), ((int)(((byte)(123)))));
            this.textBox_SS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_SS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SS.Location = new System.Drawing.Point(617, 195);
            this.textBox_SS.Name = "textBox_SS";
            this.textBox_SS.Size = new System.Drawing.Size(150, 22);
            this.textBox_SS.TabIndex = 12;
            // 
            // textBox_A
            // 
            this.textBox_A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(114)))), ((int)(((byte)(123)))));
            this.textBox_A.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_A.Location = new System.Drawing.Point(617, 246);
            this.textBox_A.Name = "textBox_A";
            this.textBox_A.Size = new System.Drawing.Size(150, 22);
            this.textBox_A.TabIndex = 13;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(114)))), ((int)(((byte)(123)))));
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(617, 354);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(150, 25);
            this.numericUpDown1.TabIndex = 15;
            // 
            // textBox_S
            // 
            this.textBox_S.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(114)))), ((int)(((byte)(123)))));
            this.textBox_S.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_S.Location = new System.Drawing.Point(617, 412);
            this.textBox_S.Name = "textBox_S";
            this.textBox_S.Size = new System.Drawing.Size(150, 22);
            this.textBox_S.TabIndex = 16;
            // 
            // btn_I
            // 
            this.btn_I.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(114)))), ((int)(((byte)(123)))));
            this.btn_I.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_I.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_I.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_I.Location = new System.Drawing.Point(886, 156);
            this.btn_I.Name = "btn_I";
            this.btn_I.Size = new System.Drawing.Size(90, 34);
            this.btn_I.TabIndex = 17;
            this.btn_I.Text = "Insert";
            this.btn_I.UseVisualStyleBackColor = false;
            this.btn_I.Click += new System.EventHandler(this.btn_I_Click);
            // 
            // btn_U
            // 
            this.btn_U.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(114)))), ((int)(((byte)(123)))));
            this.btn_U.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_U.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_U.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_U.Location = new System.Drawing.Point(886, 221);
            this.btn_U.Name = "btn_U";
            this.btn_U.Size = new System.Drawing.Size(90, 34);
            this.btn_U.TabIndex = 18;
            this.btn_U.Text = "Update";
            this.btn_U.UseVisualStyleBackColor = false;
            this.btn_U.Click += new System.EventHandler(this.btn_U_Click);
            // 
            // btn_D
            // 
            this.btn_D.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(114)))), ((int)(((byte)(123)))));
            this.btn_D.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_D.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_D.Location = new System.Drawing.Point(886, 284);
            this.btn_D.Name = "btn_D";
            this.btn_D.Size = new System.Drawing.Size(90, 34);
            this.btn_D.TabIndex = 19;
            this.btn_D.Text = "Delete";
            this.btn_D.UseVisualStyleBackColor = false;
            this.btn_D.Click += new System.EventHandler(this.btn_D_Click);
            // 
            // textBox_B
            // 
            this.textBox_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(114)))), ((int)(((byte)(123)))));
            this.textBox_B.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_B.Location = new System.Drawing.Point(617, 301);
            this.textBox_B.Name = "textBox_B";
            this.textBox_B.Size = new System.Drawing.Size(150, 22);
            this.textBox_B.TabIndex = 20;
            // 
            // V
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(160)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(1035, 554);
            this.ControlBox = false;
            this.Controls.Add(this.textBox_B);
            this.Controls.Add(this.btn_D);
            this.Controls.Add(this.btn_U);
            this.Controls.Add(this.btn_I);
            this.Controls.Add(this.textBox_S);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox_A);
            this.Controls.Add(this.textBox_SS);
            this.Controls.Add(this.textBox_L);
            this.Controls.Add(this.textBox_F);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbDept);
            this.Name = "V";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_F;
        private System.Windows.Forms.TextBox textBox_L;
        private System.Windows.Forms.TextBox textBox_SS;
        private System.Windows.Forms.TextBox textBox_A;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox_S;
        private System.Windows.Forms.Button btn_I;
        private System.Windows.Forms.Button btn_U;
        private System.Windows.Forms.Button btn_D;
        private System.Windows.Forms.TextBox textBox_B;
    }
}

