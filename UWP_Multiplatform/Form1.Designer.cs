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
            this.RobloxInstancesListBox = new System.Windows.Forms.ListBox();
            this.CreateInstanceButton = new System.Windows.Forms.Button();
            this.RemoveSelectedInstance = new System.Windows.Forms.Button();
            this.CreditsLabel = new System.Windows.Forms.Label();
            this.BackgroundWorkanator = new System.ComponentModel.BackgroundWorker();
            this.BackgroundWorkanator2 = new System.ComponentModel.BackgroundWorker();
            this.InstanceNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LaunchSelectedInstance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RobloxInstancesListBox
            // 
            this.RobloxInstancesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RobloxInstancesListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RobloxInstancesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RobloxInstancesListBox.FormattingEnabled = true;
            this.RobloxInstancesListBox.IntegralHeight = false;
            this.RobloxInstancesListBox.ItemHeight = 20;
            this.RobloxInstancesListBox.Location = new System.Drawing.Point(13, 27);
            this.RobloxInstancesListBox.Margin = new System.Windows.Forms.Padding(4);
            this.RobloxInstancesListBox.Name = "RobloxInstancesListBox";
            this.RobloxInstancesListBox.Size = new System.Drawing.Size(576, 160);
            this.RobloxInstancesListBox.Sorted = true;
            this.RobloxInstancesListBox.TabIndex = 0;
            // 
            // CreateInstanceButton
            // 
            this.CreateInstanceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateInstanceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateInstanceButton.Location = new System.Drawing.Point(13, 235);
            this.CreateInstanceButton.Margin = new System.Windows.Forms.Padding(4);
            this.CreateInstanceButton.Name = "CreateInstanceButton";
            this.CreateInstanceButton.Size = new System.Drawing.Size(276, 33);
            this.CreateInstanceButton.TabIndex = 1;
            this.CreateInstanceButton.Text = "Create a new Multi-Roblox instance";
            this.CreateInstanceButton.UseVisualStyleBackColor = true;
            this.CreateInstanceButton.Click += new System.EventHandler(this.CreateInstance_Click);
            // 
            // RemoveSelectedInstance
            // 
            this.RemoveSelectedInstance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveSelectedInstance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveSelectedInstance.Location = new System.Drawing.Point(298, 199);
            this.RemoveSelectedInstance.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveSelectedInstance.Name = "RemoveSelectedInstance";
            this.RemoveSelectedInstance.Size = new System.Drawing.Size(143, 52);
            this.RemoveSelectedInstance.TabIndex = 2;
            this.RemoveSelectedInstance.Text = "Remove selected instance";
            this.RemoveSelectedInstance.UseVisualStyleBackColor = true;
            this.RemoveSelectedInstance.Click += new System.EventHandler(this.RemoveInstance_Click);
            // 
            // CreditsLabel
            // 
            this.CreditsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreditsLabel.AutoSize = true;
            this.CreditsLabel.ForeColor = System.Drawing.Color.White;
            this.CreditsLabel.Location = new System.Drawing.Point(457, 256);
            this.CreditsLabel.Name = "CreditsLabel";
            this.CreditsLabel.Size = new System.Drawing.Size(135, 16);
            this.CreditsLabel.TabIndex = 3;
            this.CreditsLabel.Text = "HamstaGang (V3RM)";
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
            // InstanceNameTextBox
            // 
            this.InstanceNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InstanceNameTextBox.Location = new System.Drawing.Point(13, 210);
            this.InstanceNameTextBox.Name = "InstanceNameTextBox";
            this.InstanceNameTextBox.Size = new System.Drawing.Size(276, 22);
            this.InstanceNameTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(10, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Instance Name (Leave Blank For Random)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(12, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Roblox Instances";
            // 
            // LaunchSelectedInstance
            // 
            this.LaunchSelectedInstance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LaunchSelectedInstance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaunchSelectedInstance.Location = new System.Drawing.Point(449, 199);
            this.LaunchSelectedInstance.Margin = new System.Windows.Forms.Padding(4);
            this.LaunchSelectedInstance.Name = "LaunchSelectedInstance";
            this.LaunchSelectedInstance.Size = new System.Drawing.Size(143, 52);
            this.LaunchSelectedInstance.TabIndex = 8;
            this.LaunchSelectedInstance.Text = "Launch selected instance";
            this.LaunchSelectedInstance.UseVisualStyleBackColor = true;
            this.LaunchSelectedInstance.Click += new System.EventHandler(this.LaunchSelectedInstance_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(604, 281);
            this.Controls.Add(this.LaunchSelectedInstance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InstanceNameTextBox);
            this.Controls.Add(this.CreditsLabel);
            this.Controls.Add(this.RemoveSelectedInstance);
            this.Controls.Add(this.CreateInstanceButton);
            this.Controls.Add(this.RobloxInstancesListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(620, 320);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UWP Multiplatform";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox RobloxInstancesListBox;
        private System.Windows.Forms.Button CreateInstanceButton;
        private System.Windows.Forms.Button RemoveSelectedInstance;
        private System.Windows.Forms.Label CreditsLabel;
        private System.ComponentModel.BackgroundWorker BackgroundWorkanator;
        private System.ComponentModel.BackgroundWorker BackgroundWorkanator2;
        private System.Windows.Forms.TextBox InstanceNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LaunchSelectedInstance;
    }
}

