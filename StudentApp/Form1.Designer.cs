namespace StudentApp
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
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.textBoxyash = new System.Windows.Forms.TextBox();
            this.buttonElave = new System.Windows.Forms.Button();
            this.buttonDeyis = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(100, 12);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(325, 22);
            this.textBoxAd.TabIndex = 0;
            // 
            // textBoxyash
            // 
            this.textBoxyash.Location = new System.Drawing.Point(100, 60);
            this.textBoxyash.Name = "textBoxyash";
            this.textBoxyash.Size = new System.Drawing.Size(325, 22);
            this.textBoxyash.TabIndex = 1;
            // 
            // buttonElave
            // 
            this.buttonElave.Location = new System.Drawing.Point(281, 127);
            this.buttonElave.Name = "buttonElave";
            this.buttonElave.Size = new System.Drawing.Size(111, 43);
            this.buttonElave.TabIndex = 2;
            this.buttonElave.Text = "Elave Et";
            this.buttonElave.UseVisualStyleBackColor = true;
            this.buttonElave.Click += new System.EventHandler(this.buttonElave_Click);
            // 
            // buttonDeyis
            // 
            this.buttonDeyis.Location = new System.Drawing.Point(413, 127);
            this.buttonDeyis.Name = "buttonDeyis";
            this.buttonDeyis.Size = new System.Drawing.Size(111, 43);
            this.buttonDeyis.TabIndex = 3;
            this.buttonDeyis.Text = "Deyis";
            this.buttonDeyis.UseVisualStyleBackColor = true;
            this.buttonDeyis.Click += new System.EventHandler(this.buttonDeyis_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(558, 127);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(111, 43);
            this.buttonSil.TabIndex = 4;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Yash";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(792, 277);
            this.dataGridView1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 484);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonDeyis);
            this.Controls.Add(this.buttonElave);
            this.Controls.Add(this.textBoxyash);
            this.Controls.Add(this.textBoxAd);
            this.Name = "Form1";
            this.Text = "Student App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.TextBox textBoxyash;
        private System.Windows.Forms.Button buttonElave;
        private System.Windows.Forms.Button buttonDeyis;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

