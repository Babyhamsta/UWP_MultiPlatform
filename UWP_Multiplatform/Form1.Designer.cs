namespace UWP_Multiplatform
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.CreateInstance = new System.Windows.Forms.Button();
            this.RemoveInstance = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BackgroundWorkanator = new System.ComponentModel.BackgroundWorker();
            this.BackgroundWorkanator2 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(14, 15);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(666, 252);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 0;
            // 
            // CreateInstance
            // 
            this.CreateInstance.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateInstance.Location = new System.Drawing.Point(14, 275);
            this.CreateInstance.Margin = new System.Windows.Forms.Padding(4);
            this.CreateInstance.Name = "CreateInstance";
            this.CreateInstance.Size = new System.Drawing.Size(666, 47);
            this.CreateInstance.TabIndex = 1;
            this.CreateInstance.Text = "Create a new Multi-Roblox instance";
            this.CreateInstance.UseVisualStyleBackColor = true;
            this.CreateInstance.Click += new System.EventHandler(this.CreateInstance_Click);
            // 
            // RemoveInstance
            // 
            this.RemoveInstance.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveInstance.Location = new System.Drawing.Point(14, 330);
            this.RemoveInstance.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveInstance.Name = "RemoveInstance";
            this.RemoveInstance.Size = new System.Drawing.Size(666, 47);
            this.RemoveInstance.TabIndex = 2;
            this.RemoveInstance.Text = "Remove selected instance";
            this.RemoveInstance.UseVisualStyleBackColor = true;
            this.RemoveInstance.Click += new System.EventHandler(this.RemoveInstance_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "HamstaGang (V3RM)";
            // 
            // BackgroundWorkanator
            // 
            this.BackgroundWorkanator.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkanator_DoWork);
            this.BackgroundWorkanator.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorkanator_RunWorkerCompleted);
            // 
            // BackgroundWorkanator2
            // 
            this.BackgroundWorkanator2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkanator2_DoWork);
            this.BackgroundWorkanator2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorkanator2_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(694, 410);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemoveInstance);
            this.Controls.Add(this.CreateInstance);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Ubuntu Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UWP Multiplatform";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button CreateInstance;
        private System.Windows.Forms.Button RemoveInstance;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker BackgroundWorkanator;
        private System.ComponentModel.BackgroundWorker BackgroundWorkanator2;
    }
}

