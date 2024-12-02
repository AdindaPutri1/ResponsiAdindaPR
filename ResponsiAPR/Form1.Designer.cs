namespace ResponsiAPR
{
    partial class Form1
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
            this.tbNama = new System.Windows.Forms.TextBox();
            this.lblNamaKaryawan = new System.Windows.Forms.Label();
            this.lbldepartemen = new System.Windows.Forms.Label();
            this.rbHR = new System.Windows.Forms.RadioButton();
            this.rbENG = new System.Windows.Forms.RadioButton();
            this.rbDEV = new System.Windows.Forms.RadioButton();
            this.rbPM = new System.Windows.Forms.RadioButton();
            this.rbFIN = new System.Windows.Forms.RadioButton();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvKaryawan = new System.Windows.Forms.DataGridView();
            this.LbSelected = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKaryawan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(190, 222);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(473, 26);
            this.tbNama.TabIndex = 1;
            this.tbNama.TextChanged += new System.EventHandler(this.tbNama_TextChanged);
            // 
            // lblNamaKaryawan
            // 
            this.lblNamaKaryawan.AutoSize = true;
            this.lblNamaKaryawan.Location = new System.Drawing.Point(30, 222);
            this.lblNamaKaryawan.Name = "lblNamaKaryawan";
            this.lblNamaKaryawan.Size = new System.Drawing.Size(132, 20);
            this.lblNamaKaryawan.TabIndex = 2;
            this.lblNamaKaryawan.Text = "Nama Karyawan :";
            this.lblNamaKaryawan.Click += new System.EventHandler(this.lblNamaKaryawan_Click);
            // 
            // lbldepartemen
            // 
            this.lbldepartemen.AutoSize = true;
            this.lbldepartemen.Location = new System.Drawing.Point(30, 268);
            this.lbldepartemen.Name = "lbldepartemen";
            this.lbldepartemen.Size = new System.Drawing.Size(106, 20);
            this.lbldepartemen.TabIndex = 3;
            this.lbldepartemen.Text = "Departemen :";
            this.lbldepartemen.Click += new System.EventHandler(this.label1_Click);
            // 
            // rbHR
            // 
            this.rbHR.AutoSize = true;
            this.rbHR.Location = new System.Drawing.Point(189, 266);
            this.rbHR.Name = "rbHR";
            this.rbHR.Size = new System.Drawing.Size(58, 24);
            this.rbHR.TabIndex = 4;
            this.rbHR.TabStop = true;
            this.rbHR.Text = "HR";
            this.rbHR.UseVisualStyleBackColor = true;
            // 
            // rbENG
            // 
            this.rbENG.AutoSize = true;
            this.rbENG.Location = new System.Drawing.Point(253, 266);
            this.rbENG.Name = "rbENG";
            this.rbENG.Size = new System.Drawing.Size(69, 24);
            this.rbENG.TabIndex = 5;
            this.rbENG.TabStop = true;
            this.rbENG.Text = "ENG";
            this.rbENG.UseVisualStyleBackColor = true;
            // 
            // rbDEV
            // 
            this.rbDEV.AutoSize = true;
            this.rbDEV.Location = new System.Drawing.Point(328, 266);
            this.rbDEV.Name = "rbDEV";
            this.rbDEV.Size = new System.Drawing.Size(68, 24);
            this.rbDEV.TabIndex = 6;
            this.rbDEV.TabStop = true;
            this.rbDEV.Text = "DEV";
            this.rbDEV.UseVisualStyleBackColor = true;
            // 
            // rbPM
            // 
            this.rbPM.AutoSize = true;
            this.rbPM.Location = new System.Drawing.Point(402, 266);
            this.rbPM.Name = "rbPM";
            this.rbPM.Size = new System.Drawing.Size(57, 24);
            this.rbPM.TabIndex = 7;
            this.rbPM.TabStop = true;
            this.rbPM.Text = "PM";
            this.rbPM.UseVisualStyleBackColor = true;
            this.rbPM.CheckedChanged += new System.EventHandler(this.rbPM_CheckedChanged);
            // 
            // rbFIN
            // 
            this.rbFIN.AutoSize = true;
            this.rbFIN.Location = new System.Drawing.Point(465, 266);
            this.rbFIN.Name = "rbFIN";
            this.rbFIN.Size = new System.Drawing.Size(60, 24);
            this.rbFIN.TabIndex = 8;
            this.rbFIN.TabStop = true;
            this.rbFIN.Text = "FIN";
            this.rbFIN.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInsert.Location = new System.Drawing.Point(133, 318);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(128, 53);
            this.btnInsert.TabIndex = 9;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Info;
            this.btnEdit.Location = new System.Drawing.Point(289, 318);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(128, 53);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Salmon;
            this.btnDelete.Location = new System.Drawing.Point(446, 318);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 53);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(778, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID Dep:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(778, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "DEV: Developer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(778, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "ENG: Engineer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(778, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "HR: HR";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(778, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "PM: Product Manager";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(778, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "FIN: Finance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Karyawan terpilih:";
            // 
            // dgvKaryawan
            // 
            this.dgvKaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKaryawan.Location = new System.Drawing.Point(34, 433);
            this.dgvKaryawan.Name = "dgvKaryawan";
            this.dgvKaryawan.RowHeadersWidth = 62;
            this.dgvKaryawan.RowTemplate.Height = 28;
            this.dgvKaryawan.Size = new System.Drawing.Size(886, 216);
            this.dgvKaryawan.TabIndex = 19;
            this.dgvKaryawan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKaryawan_CellContentClick);
            // 
            // LbSelected
            // 
            this.LbSelected.AutoSize = true;
            this.LbSelected.Location = new System.Drawing.Point(189, 398);
            this.LbSelected.Name = "LbSelected";
            this.LbSelected.Size = new System.Drawing.Size(0, 20);
            this.LbSelected.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ResponsiAPR.Properties.Resources.logo3;
            this.pictureBox1.Location = new System.Drawing.Point(217, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 189);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 661);
            this.Controls.Add(this.LbSelected);
            this.Controls.Add(this.dgvKaryawan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.rbFIN);
            this.Controls.Add(this.rbPM);
            this.Controls.Add(this.rbDEV);
            this.Controls.Add(this.rbENG);
            this.Controls.Add(this.rbHR);
            this.Controls.Add(this.lbldepartemen);
            this.Controls.Add(this.lblNamaKaryawan);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKaryawan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label lblNamaKaryawan;
        private System.Windows.Forms.Label lbldepartemen;
        private System.Windows.Forms.RadioButton rbHR;
        private System.Windows.Forms.RadioButton rbENG;
        private System.Windows.Forms.RadioButton rbDEV;
        private System.Windows.Forms.RadioButton rbPM;
        private System.Windows.Forms.RadioButton rbFIN;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvKaryawan;
        private System.Windows.Forms.Label LbSelected;
    }
}

