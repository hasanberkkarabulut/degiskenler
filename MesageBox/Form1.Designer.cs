namespace MesageBox
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
            this.btnmesajgöster = new System.Windows.Forms.Button();
            this.btnsorusor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnmesajgöster
            // 
            this.btnmesajgöster.Location = new System.Drawing.Point(72, 62);
            this.btnmesajgöster.Name = "btnmesajgöster";
            this.btnmesajgöster.Size = new System.Drawing.Size(139, 23);
            this.btnmesajgöster.TabIndex = 0;
            this.btnmesajgöster.Text = "mesaj gönder";
            this.btnmesajgöster.UseVisualStyleBackColor = true;
            this.btnmesajgöster.Click += new System.EventHandler(this.btnmesajgöster_Click);
            // 
            // btnsorusor
            // 
            this.btnsorusor.Location = new System.Drawing.Point(267, 62);
            this.btnsorusor.Name = "btnsorusor";
            this.btnsorusor.Size = new System.Drawing.Size(195, 23);
            this.btnsorusor.TabIndex = 1;
            this.btnsorusor.Text = "Soru Sor";
            this.btnsorusor.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsorusor);
            this.Controls.Add(this.btnmesajgöster);
            this.Name = "Form1";
            this.Text = "Message box inceleme";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnmesajgöster;
        private System.Windows.Forms.Button btnsorusor;
    }
}

