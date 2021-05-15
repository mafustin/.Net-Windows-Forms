
namespace WindowsService9v2
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
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.bt_obrada = new System.Windows.Forms.Button();
            this.bt_prekini = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(152, 177);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(436, 29);
            this.progressBar.TabIndex = 0;
            // 
            // bt_obrada
            // 
            this.bt_obrada.Location = new System.Drawing.Point(171, 80);
            this.bt_obrada.Name = "bt_obrada";
            this.bt_obrada.Size = new System.Drawing.Size(101, 33);
            this.bt_obrada.TabIndex = 1;
            this.bt_obrada.Text = "Obrađuj";
            this.bt_obrada.UseVisualStyleBackColor = true;
            this.bt_obrada.Click += new System.EventHandler(this.bt_obrada_Click);
            // 
            // bt_prekini
            // 
            this.bt_prekini.Location = new System.Drawing.Point(484, 80);
            this.bt_prekini.Name = "bt_prekini";
            this.bt_prekini.Size = new System.Drawing.Size(104, 33);
            this.bt_prekini.TabIndex = 2;
            this.bt_prekini.Text = "Dosta, prekini";
            this.bt_prekini.UseVisualStyleBackColor = true;
            this.bt_prekini.Click += new System.EventHandler(this.bt_prekini_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 243);
            this.Controls.Add(this.bt_prekini);
            this.Controls.Add(this.bt_obrada);
            this.Controls.Add(this.progressBar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button bt_obrada;
        private System.Windows.Forms.Button bt_prekini;
    }
}

