namespace WinFormsApp2
{
    partial class Form1
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
            this.datGrdViewIn = new System.Windows.Forms.DataGridView();
            this.datGrdViewRes = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datGrdViewIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datGrdViewRes)).BeginInit();
            this.SuspendLayout();
            // 
            // datGrdViewIn
            // 
            this.datGrdViewIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datGrdViewIn.Location = new System.Drawing.Point(297, 114);
            this.datGrdViewIn.Name = "datGrdViewIn";
            this.datGrdViewIn.RowTemplate.Height = 25;
            this.datGrdViewIn.Size = new System.Drawing.Size(240, 150);
            this.datGrdViewIn.TabIndex = 0;
            this.datGrdViewIn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datGrdViewIn_CellContentClick);
            // 
            // datGrdViewRes
            // 
            this.datGrdViewRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datGrdViewRes.Location = new System.Drawing.Point(297, 270);
            this.datGrdViewRes.Name = "datGrdViewRes";
            this.datGrdViewRes.RowTemplate.Height = 25;
            this.datGrdViewRes.Size = new System.Drawing.Size(240, 150);
            this.datGrdViewRes.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(360, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(630, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 75);
            this.button1.TabIndex = 3;
            this.button1.Text = "PUSH ME";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.datGrdViewRes);
            this.Controls.Add(this.datGrdViewIn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datGrdViewIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datGrdViewRes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private DataGridView datGrdViewIn;
        private DataGridView datGrdViewRes;
        private TextBox textBox1;
        private Button button1;
    }
}