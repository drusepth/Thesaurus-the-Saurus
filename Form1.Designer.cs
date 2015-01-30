namespace Thesaurus
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnClose = new System.Windows.Forms.Button();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.lblSynonyms = new System.Windows.Forms.Label();
            this.tmrClipboardWatch = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.Location = new System.Drawing.Point(512, -2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 25);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuery.Location = new System.Drawing.Point(345, 12);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(160, 41);
            this.txtQuery.TabIndex = 1;
            this.txtQuery.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuery.WordWrap = false;
            this.txtQuery.TextChanged += new System.EventHandler(this.txtQuery_TextChanged);
            this.txtQuery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuery_KeyDown);
            // 
            // lblSynonyms
            // 
            this.lblSynonyms.BackColor = System.Drawing.Color.Transparent;
            this.lblSynonyms.Font = new System.Drawing.Font("Segoe WP Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSynonyms.ForeColor = System.Drawing.Color.Black;
            this.lblSynonyms.Location = new System.Drawing.Point(12, 69);
            this.lblSynonyms.Name = "lblSynonyms";
            this.lblSynonyms.Size = new System.Drawing.Size(529, 395);
            this.lblSynonyms.TabIndex = 2;
            this.lblSynonyms.Text = "label1";
            this.lblSynonyms.Click += new System.EventHandler(this.lblSynonyms_Click);
            // 
            // tmrClipboardWatch
            // 
            this.tmrClipboardWatch.Enabled = true;
            this.tmrClipboardWatch.Interval = 800;
            this.tmrClipboardWatch.Tick += new System.EventHandler(this.tmrClipboardWatch_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(535, 473);
            this.Controls.Add(this.lblSynonyms);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Label lblSynonyms;
        private System.Windows.Forms.Timer tmrClipboardWatch;
    }
}

