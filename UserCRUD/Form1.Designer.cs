
namespace UserCRUD
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonTorles = new System.Windows.Forms.Button();
            this.buttonModositas = new System.Windows.Forms.Button();
            this.buttonKuldes = new System.Windows.Forms.Button();
            this.numericUpDownFizetes = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFizetes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonTorles);
            this.groupBox1.Controls.Add(this.buttonModositas);
            this.groupBox1.Controls.Add(this.buttonKuldes);
            this.groupBox1.Controls.Add(this.numericUpDownFizetes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxNev);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // buttonTorles
            // 
            this.buttonTorles.Location = new System.Drawing.Point(387, 67);
            this.buttonTorles.Name = "buttonTorles";
            this.buttonTorles.Size = new System.Drawing.Size(120, 23);
            this.buttonTorles.TabIndex = 6;
            this.buttonTorles.Text = "Törlés";
            this.buttonTorles.UseVisualStyleBackColor = true;
            // 
            // buttonModositas
            // 
            this.buttonModositas.Location = new System.Drawing.Point(205, 67);
            this.buttonModositas.Name = "buttonModositas";
            this.buttonModositas.Size = new System.Drawing.Size(120, 23);
            this.buttonModositas.TabIndex = 5;
            this.buttonModositas.Text = "Módosítás";
            this.buttonModositas.UseVisualStyleBackColor = true;
            // 
            // buttonKuldes
            // 
            this.buttonKuldes.Location = new System.Drawing.Point(44, 67);
            this.buttonKuldes.Name = "buttonKuldes";
            this.buttonKuldes.Size = new System.Drawing.Size(100, 23);
            this.buttonKuldes.TabIndex = 4;
            this.buttonKuldes.Text = "Küldés";
            this.buttonKuldes.UseVisualStyleBackColor = true;
            // 
            // numericUpDownFizetes
            // 
            this.numericUpDownFizetes.Location = new System.Drawing.Point(257, 21);
            this.numericUpDownFizetes.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownFizetes.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownFizetes.Name = "numericUpDownFizetes";
            this.numericUpDownFizetes.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownFizetes.TabIndex = 3;
            this.numericUpDownFizetes.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "fizetes";
            // 
            // textBoxNev
            // 
            this.textBoxNev.Location = new System.Drawing.Point(44, 24);
            this.textBoxNev.Name = "textBoxNev";
            this.textBoxNev.Size = new System.Drawing.Size(100, 22);
            this.textBoxNev.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "nev";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 246);
            this.dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Felhasználói nyilvántartás";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFizetes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonModositas;
        private System.Windows.Forms.Button buttonKuldes;
        private System.Windows.Forms.NumericUpDown numericUpDownFizetes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTorles;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

