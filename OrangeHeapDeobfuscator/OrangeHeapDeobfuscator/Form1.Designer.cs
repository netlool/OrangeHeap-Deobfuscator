namespace OrangeHeapDeobfuscator
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbin = new System.Windows.Forms.TextBox();
            this.btnofd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsfd = new System.Windows.Forms.Button();
            this.tbout = new System.Windows.Forms.TextBox();
            this.btnDeobf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbin
            // 
            this.tbin.Location = new System.Drawing.Point(12, 37);
            this.tbin.Multiline = true;
            this.tbin.Name = "tbin";
            this.tbin.Size = new System.Drawing.Size(541, 30);
            this.tbin.TabIndex = 0;
            // 
            // btnofd
            // 
            this.btnofd.Location = new System.Drawing.Point(560, 37);
            this.btnofd.Name = "btnofd";
            this.btnofd.Size = new System.Drawing.Size(75, 30);
            this.btnofd.TabIndex = 1;
            this.btnofd.Text = "...";
            this.btnofd.UseVisualStyleBackColor = true;
            this.btnofd.Click += new System.EventHandler(this.btnofd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Output";
            // 
            // btnsfd
            // 
            this.btnsfd.Location = new System.Drawing.Point(560, 100);
            this.btnsfd.Name = "btnsfd";
            this.btnsfd.Size = new System.Drawing.Size(75, 30);
            this.btnsfd.TabIndex = 4;
            this.btnsfd.Text = "...";
            this.btnsfd.UseVisualStyleBackColor = true;
            this.btnsfd.Click += new System.EventHandler(this.btnsfd_Click);
            // 
            // tbout
            // 
            this.tbout.Location = new System.Drawing.Point(12, 100);
            this.tbout.Multiline = true;
            this.tbout.Name = "tbout";
            this.tbout.Size = new System.Drawing.Size(541, 30);
            this.tbout.TabIndex = 3;
            // 
            // btnDeobf
            // 
            this.btnDeobf.Location = new System.Drawing.Point(12, 164);
            this.btnDeobf.Name = "btnDeobf";
            this.btnDeobf.Size = new System.Drawing.Size(623, 76);
            this.btnDeobf.TabIndex = 6;
            this.btnDeobf.Text = "Deobfuscate Assembly";
            this.btnDeobf.UseVisualStyleBackColor = true;
            this.btnDeobf.Click += new System.EventHandler(this.btnDeobf_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 262);
            this.Controls.Add(this.btnDeobf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsfd);
            this.Controls.Add(this.tbout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnofd);
            this.Controls.Add(this.tbin);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "OrangeHeap Deobfuscator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbin;
        private System.Windows.Forms.Button btnofd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsfd;
        private System.Windows.Forms.TextBox tbout;
        private System.Windows.Forms.Button btnDeobf;
    }
}

