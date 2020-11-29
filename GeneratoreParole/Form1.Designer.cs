namespace GeneratoreParole
{
    partial class frmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grpBox1 = new System.Windows.Forms.GroupBox();
            this.grpBox2 = new System.Windows.Forms.GroupBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.pgrsBar1 = new System.Windows.Forms.ProgressBar();
            this.pgrsBar2 = new System.Windows.Forms.ProgressBar();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.bgw1 = new System.ComponentModel.BackgroundWorker();
            this.bgw2 = new System.ComponentModel.BackgroundWorker();
            this.bgw3 = new System.ComponentModel.BackgroundWorker();
            this.btn3 = new System.Windows.Forms.Button();
            this.bgw4 = new System.ComponentModel.BackgroundWorker();
            this.grpBox1.SuspendLayout();
            this.grpBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox1
            // 
            this.grpBox1.Controls.Add(this.txtBox1);
            this.grpBox1.Controls.Add(this.lbl1);
            this.grpBox1.Controls.Add(this.pgrsBar1);
            this.grpBox1.Controls.Add(this.btn1);
            this.grpBox1.Location = new System.Drawing.Point(12, 12);
            this.grpBox1.Name = "grpBox1";
            this.grpBox1.Size = new System.Drawing.Size(296, 96);
            this.grpBox1.TabIndex = 0;
            this.grpBox1.TabStop = false;
            this.grpBox1.Text = "Thread Singolo";
            // 
            // grpBox2
            // 
            this.grpBox2.Controls.Add(this.txtBox2);
            this.grpBox2.Controls.Add(this.lbl2);
            this.grpBox2.Controls.Add(this.pgrsBar2);
            this.grpBox2.Controls.Add(this.btn2);
            this.grpBox2.Location = new System.Drawing.Point(12, 114);
            this.grpBox2.Name = "grpBox2";
            this.grpBox2.Size = new System.Drawing.Size(296, 96);
            this.grpBox2.TabIndex = 1;
            this.grpBox2.TabStop = false;
            this.grpBox2.Text = "Tre Thread";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(13, 26);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 25);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Start";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(13, 19);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 25);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "Start";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // pgrsBar1
            // 
            this.pgrsBar1.Location = new System.Drawing.Point(104, 26);
            this.pgrsBar1.Name = "pgrsBar1";
            this.pgrsBar1.Size = new System.Drawing.Size(172, 24);
            this.pgrsBar1.TabIndex = 1;
            // 
            // pgrsBar2
            // 
            this.pgrsBar2.Location = new System.Drawing.Point(104, 19);
            this.pgrsBar2.Name = "pgrsBar2";
            this.pgrsBar2.Size = new System.Drawing.Size(172, 24);
            this.pgrsBar2.TabIndex = 2;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(31, 66);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(40, 13);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Tempo";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(31, 61);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(40, 13);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Tempo";
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(104, 58);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(172, 20);
            this.txtBox2.TabIndex = 4;
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(104, 63);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(172, 20);
            this.txtBox1.TabIndex = 5;
            // 
            // bgw1
            // 
            this.bgw1.WorkerReportsProgress = true;
            this.bgw1.WorkerSupportsCancellation = true;
            this.bgw1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw1_DoWork);
            this.bgw1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw1_ProgressChanged);
            this.bgw1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw1_RunWorkerCompleted);
            // 
            // bgw2
            // 
            this.bgw2.WorkerReportsProgress = true;
            this.bgw2.WorkerSupportsCancellation = true;
            this.bgw2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw2_DoWork);
            this.bgw2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw2_ProgressChanged);
            this.bgw2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw2_RunWorkerCompleted);
            // 
            // bgw3
            // 
            this.bgw3.WorkerReportsProgress = true;
            this.bgw3.WorkerSupportsCancellation = true;
            this.bgw3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw3_DoWork);
            this.bgw3.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw3_ProgressChanged);
            this.bgw3.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw3_RunWorkerCompleted);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(12, 216);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(296, 29);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "Gara!";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // bgw4
            // 
            this.bgw4.WorkerReportsProgress = true;
            this.bgw4.WorkerSupportsCancellation = true;
            this.bgw4.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw4_DoWork);
            this.bgw4.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw4_ProgressChanged);
            this.bgw4.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw4_RunWorkerCompleted);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 251);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.grpBox2);
            this.Controls.Add(this.grpBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Generatore Di Parole";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpBox1.ResumeLayout(false);
            this.grpBox1.PerformLayout();
            this.grpBox2.ResumeLayout(false);
            this.grpBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox1;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.ProgressBar pgrsBar1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.GroupBox grpBox2;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.ProgressBar pgrsBar2;
        private System.Windows.Forms.Button btn2;
        private System.ComponentModel.BackgroundWorker bgw1;
        private System.ComponentModel.BackgroundWorker bgw2;
        private System.ComponentModel.BackgroundWorker bgw3;
        private System.Windows.Forms.Button btn3;
        private System.ComponentModel.BackgroundWorker bgw4;
    }
}

