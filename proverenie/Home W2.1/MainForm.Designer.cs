namespace ProgressBarSample
{
    partial class MainForm
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
            this.groupBoxText = new System.Windows.Forms.GroupBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.groupBoxProgress = new System.Windows.Forms.GroupBox();
            this.progressBarText = new System.Windows.Forms.ProgressBar();
            this.button = new System.Windows.Forms.Button();
            this.groupBoxText.SuspendLayout();
            this.groupBoxProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxText
            // 
            this.groupBoxText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxText.Controls.Add(this.listBox);
            this.groupBoxText.Location = new System.Drawing.Point(20, 19);
            this.groupBoxText.Name = "groupBoxText";
            this.groupBoxText.Size = new System.Drawing.Size(571, 504);
            this.groupBoxText.TabIndex = 0;
            this.groupBoxText.TabStop = false;
            this.groupBoxText.Text = "Text From File";
            // 
            // listBox
            // 
            this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(17, 19);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(538, 459);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            this.listBox.SelectedValueChanged += new System.EventHandler(this.listBox_SelectedValueChanged);
            // 
            // groupBoxProgress
            // 
            this.groupBoxProgress.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBoxProgress.Controls.Add(this.progressBarText);
            this.groupBoxProgress.Location = new System.Drawing.Point(244, 545);
            this.groupBoxProgress.Name = "groupBoxProgress";
            this.groupBoxProgress.Size = new System.Drawing.Size(303, 73);
            this.groupBoxProgress.TabIndex = 0;
            this.groupBoxProgress.TabStop = false;
            this.groupBoxProgress.Text = "Прогресс:";
            // 
            // progressBarText
            // 
            this.progressBarText.Location = new System.Drawing.Point(24, 28);
            this.progressBarText.Name = "progressBarText";
            this.progressBarText.Size = new System.Drawing.Size(250, 23);
            this.progressBarText.Step = 1;
            this.progressBarText.TabIndex = 0;
            // 
            // button
            // 
            this.button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button.Location = new System.Drawing.Point(20, 560);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(134, 36);
            this.button.TabIndex = 1;
            this.button.Text = "Start Download ";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 633);
            this.Controls.Add(this.button);
            this.Controls.Add(this.groupBoxProgress);
            this.Controls.Add(this.groupBoxText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgressBar Sample";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxText.ResumeLayout(false);
            this.groupBoxProgress.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxText;
        private System.Windows.Forms.GroupBox groupBoxProgress;
        private System.Windows.Forms.ProgressBar progressBarText;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button button;
    }
}

