namespace QuickComputerOptions
{
    partial class frmComputerUtilitiesMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComputerUtilitiesMenu));
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnForceShutdown = new System.Windows.Forms.Button();
            this.btnLock = new System.Windows.Forms.Button();
            this.btnSleep = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSignOut
            // 
            this.btnSignOut.Location = new System.Drawing.Point(138, 144);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(110, 34);
            this.btnSignOut.TabIndex = 13;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnForceShutdown
            // 
            this.btnForceShutdown.Location = new System.Drawing.Point(138, 53);
            this.btnForceShutdown.Name = "btnForceShutdown";
            this.btnForceShutdown.Size = new System.Drawing.Size(110, 34);
            this.btnForceShutdown.TabIndex = 12;
            this.btnForceShutdown.Text = "Force Shut Down";
            this.btnForceShutdown.UseVisualStyleBackColor = true;
            // 
            // btnLock
            // 
            this.btnLock.Location = new System.Drawing.Point(17, 144);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(110, 34);
            this.btnLock.TabIndex = 11;
            this.btnLock.Text = "Lock PC";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // btnSleep
            // 
            this.btnSleep.Location = new System.Drawing.Point(138, 98);
            this.btnSleep.Name = "btnSleep";
            this.btnSleep.Size = new System.Drawing.Size(110, 34);
            this.btnSleep.TabIndex = 10;
            this.btnSleep.Text = "Make PC Sleep";
            this.btnSleep.UseVisualStyleBackColor = true;
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(17, 98);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(110, 34);
            this.btnRestart.TabIndex = 9;
            this.btnRestart.Text = "Restart PC";
            this.btnRestart.UseVisualStyleBackColor = true;
            // 
            // btnShutdown
            // 
            this.btnShutdown.Location = new System.Drawing.Point(16, 53);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(110, 34);
            this.btnShutdown.TabIndex = 8;
            this.btnShutdown.Text = "Shut Down PC";
            this.btnShutdown.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "What would you like to do?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmComputerUtilitiesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 193);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnForceShutdown);
            this.Controls.Add(this.btnLock);
            this.Controls.Add(this.btnSleep);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnShutdown);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmComputerUtilitiesMenu";
            this.Text = "Computer Utilities Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnForceShutdown;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Button btnSleep;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Label label1;
    }
}

