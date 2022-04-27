namespace Employee_Data
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
            this.displayButton = new System.Windows.Forms.Button();
            this.closebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(133, 116);
            this.displayButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(187, 46);
            this.displayButton.TabIndex = 0;
            this.displayButton.Text = "Display Employee Data";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // closebtn
            // 
            this.closebtn.Location = new System.Drawing.Point(133, 204);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(187, 44);
            this.closebtn.TabIndex = 1;
            this.closebtn.Text = "Close";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 428);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.displayButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Employee Data";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button closebtn;
    }
}

