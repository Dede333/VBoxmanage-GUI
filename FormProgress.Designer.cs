namespace VBoxManage_Gui
{
    partial class FormProgress
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
            this.components = new System.ComponentModel.Container();
            this.Lbl_VBoxManagePatienter = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // Lbl_VBoxManagePatienter
            // 
            this.Lbl_VBoxManagePatienter.AutoSize = true;
            this.Lbl_VBoxManagePatienter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_VBoxManagePatienter.Location = new System.Drawing.Point(50, 23);
            this.Lbl_VBoxManagePatienter.Name = "Lbl_VBoxManagePatienter";
            this.Lbl_VBoxManagePatienter.Size = new System.Drawing.Size(369, 24);
            this.Lbl_VBoxManagePatienter.TabIndex = 0;
            this.Lbl_VBoxManagePatienter.Text = "VBoxManage en cours, veuillez patienter...";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(54, 57);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(365, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 1;
            // 
            // FormProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 104);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Lbl_VBoxManagePatienter);
            this.Name = "FormProgress";
            this.Text = "VBoxManage commande en cours...";
            this.Load += new System.EventHandler(this.FormProgress_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_VBoxManagePatienter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}