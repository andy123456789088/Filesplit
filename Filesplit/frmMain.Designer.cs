namespace Filesplit
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.prgFinal = new System.Windows.Forms.ProgressBar();
            this.prgCurrent = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSplt = new System.Windows.Forms.Button();
            this.numFileSize = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.grpSplit = new System.Windows.Forms.GroupBox();
            this.grp2 = new System.Windows.Forms.GroupBox();
            this.btnPutFileTogether = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numFileSize)).BeginInit();
            this.grpSplit.SuspendLayout();
            this.grp2.SuspendLayout();
            this.SuspendLayout();
            // 
            // prgFinal
            // 
            this.prgFinal.Location = new System.Drawing.Point(15, 79);
            this.prgFinal.Name = "prgFinal";
            this.prgFinal.Size = new System.Drawing.Size(565, 23);
            this.prgFinal.TabIndex = 0;
            // 
            // prgCurrent
            // 
            this.prgCurrent.Location = new System.Drawing.Point(15, 130);
            this.prgCurrent.Name = "prgCurrent";
            this.prgCurrent.Size = new System.Drawing.Size(565, 23);
            this.prgCurrent.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Progress:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Current Progress:";
            // 
            // btnSplt
            // 
            this.btnSplt.Location = new System.Drawing.Point(6, 66);
            this.btnSplt.Name = "btnSplt";
            this.btnSplt.Size = new System.Drawing.Size(120, 23);
            this.btnSplt.TabIndex = 5;
            this.btnSplt.Text = "Okay";
            this.btnSplt.UseVisualStyleBackColor = true;
            this.btnSplt.Click += new System.EventHandler(this.btnSplt_Click);
            // 
            // numFileSize
            // 
            this.numFileSize.Location = new System.Drawing.Point(6, 37);
            this.numFileSize.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.numFileSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFileSize.Name = "numFileSize";
            this.numFileSize.Size = new System.Drawing.Size(120, 23);
            this.numFileSize.TabIndex = 6;
            this.numFileSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Size in MB:";
            // 
            // grpSplit
            // 
            this.grpSplit.Controls.Add(this.numFileSize);
            this.grpSplit.Controls.Add(this.btnSplt);
            this.grpSplit.Controls.Add(this.label4);
            this.grpSplit.Location = new System.Drawing.Point(15, 161);
            this.grpSplit.Name = "grpSplit";
            this.grpSplit.Size = new System.Drawing.Size(135, 100);
            this.grpSplit.TabIndex = 8;
            this.grpSplit.TabStop = false;
            this.grpSplit.Text = "Split the file";
            // 
            // grp2
            // 
            this.grp2.Controls.Add(this.btnPutFileTogether);
            this.grp2.Location = new System.Drawing.Point(156, 161);
            this.grp2.Name = "grp2";
            this.grp2.Size = new System.Drawing.Size(424, 100);
            this.grp2.TabIndex = 9;
            this.grp2.TabStop = false;
            this.grp2.Text = "Put the file together";
            // 
            // btnPutFileTogether
            // 
            this.btnPutFileTogether.Location = new System.Drawing.Point(6, 19);
            this.btnPutFileTogether.Name = "btnPutFileTogether";
            this.btnPutFileTogether.Size = new System.Drawing.Size(412, 70);
            this.btnPutFileTogether.TabIndex = 5;
            this.btnPutFileTogether.Text = "Okay";
            this.btnPutFileTogether.UseVisualStyleBackColor = true;
            this.btnPutFileTogether.Click += new System.EventHandler(this.btnPutFileTogether_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 273);
            this.Controls.Add(this.grp2);
            this.Controls.Add(this.grpSplit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prgCurrent);
            this.Controls.Add(this.prgFinal);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Filesplit";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numFileSize)).EndInit();
            this.grpSplit.ResumeLayout(false);
            this.grpSplit.PerformLayout();
            this.grp2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar prgFinal;
        private System.Windows.Forms.ProgressBar prgCurrent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSplt;
        private System.Windows.Forms.NumericUpDown numFileSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpSplit;
        private System.Windows.Forms.GroupBox grp2;
        private System.Windows.Forms.Button btnPutFileTogether;
    }
}

