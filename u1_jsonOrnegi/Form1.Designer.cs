namespace u1_jsonOrnegi
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
            this.btnJsonOlustur = new System.Windows.Forms.Button();
            this.btnJSONOku = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnJsonOlustur
            // 
            this.btnJsonOlustur.Location = new System.Drawing.Point(42, 24);
            this.btnJsonOlustur.Name = "btnJsonOlustur";
            this.btnJsonOlustur.Size = new System.Drawing.Size(131, 30);
            this.btnJsonOlustur.TabIndex = 0;
            this.btnJsonOlustur.Text = "JSON OLUSTUR";
            this.btnJsonOlustur.UseVisualStyleBackColor = true;
            this.btnJsonOlustur.Click += new System.EventHandler(this.btnJsonOlustur_Click);
            // 
            // btnJSONOku
            // 
            this.btnJSONOku.Location = new System.Drawing.Point(409, 24);
            this.btnJSONOku.Name = "btnJSONOku";
            this.btnJSONOku.Size = new System.Drawing.Size(136, 30);
            this.btnJSONOku.TabIndex = 1;
            this.btnJSONOku.Text = "JSON OKU";
            this.btnJSONOku.UseVisualStyleBackColor = true;
            this.btnJSONOku.Click += new System.EventHandler(this.btnJSONOku_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 67);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(328, 251);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(409, 67);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(328, 255);
            this.textBox2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 346);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnJSONOku);
            this.Controls.Add(this.btnJsonOlustur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJsonOlustur;
        private System.Windows.Forms.Button btnJSONOku;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

