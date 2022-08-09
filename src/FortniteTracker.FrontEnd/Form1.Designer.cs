namespace FortniteTracker.FrontEnd
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResultsFolder = new System.Windows.Forms.TextBox();
            this.btnDirectory = new System.Windows.Forms.Button();
            this.btnAccounts = new System.Windows.Forms.Button();
            this.btnProxies = new System.Windows.Forms.Button();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.lblInvalid = new System.Windows.Forms.Label();
            this.lblValid = new System.Windows.Forms.Label();
            this.lblChecked = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbInfo.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Controls.Add(this.label1);
            this.gbInfo.Controls.Add(this.txtResultsFolder);
            this.gbInfo.Controls.Add(this.btnDirectory);
            this.gbInfo.Controls.Add(this.btnAccounts);
            this.gbInfo.Controls.Add(this.btnProxies);
            this.gbInfo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbInfo.Location = new System.Drawing.Point(12, 12);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(362, 133);
            this.gbInfo.TabIndex = 1;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Info";
            this.gbInfo.Enter += new System.EventHandler(this.gbInfo_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Accounts:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Proxies:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Results folder:";
            // 
            // txtResultsFolder
            // 
            this.txtResultsFolder.Location = new System.Drawing.Point(18, 95);
            this.txtResultsFolder.Name = "txtResultsFolder";
            this.txtResultsFolder.ReadOnly = true;
            this.txtResultsFolder.Size = new System.Drawing.Size(224, 21);
            this.txtResultsFolder.TabIndex = 7;
            // 
            // btnDirectory
            // 
            this.btnDirectory.Location = new System.Drawing.Point(248, 94);
            this.btnDirectory.Name = "btnDirectory";
            this.btnDirectory.Size = new System.Drawing.Size(97, 23);
            this.btnDirectory.TabIndex = 6;
            this.btnDirectory.Text = "Load Directory";
            this.btnDirectory.UseVisualStyleBackColor = true;
            this.btnDirectory.Click += new System.EventHandler(this.btnDirectory_Click);
            // 
            // btnAccounts
            // 
            this.btnAccounts.Location = new System.Drawing.Point(113, 47);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.Size = new System.Drawing.Size(97, 23);
            this.btnAccounts.TabIndex = 5;
            this.btnAccounts.Text = "Load Accounts";
            this.btnAccounts.UseVisualStyleBackColor = true;
            this.btnAccounts.Click += new System.EventHandler(this.btnAccounts_Click);
            // 
            // btnProxies
            // 
            this.btnProxies.Location = new System.Drawing.Point(18, 47);
            this.btnProxies.Name = "btnProxies";
            this.btnProxies.Size = new System.Drawing.Size(89, 23);
            this.btnProxies.TabIndex = 4;
            this.btnProxies.Text = "Load Proxies";
            this.btnProxies.UseVisualStyleBackColor = true;
            this.btnProxies.Click += new System.EventHandler(this.btnProxies_Click);
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.lblInvalid);
            this.gbStatus.Controls.Add(this.lblValid);
            this.gbStatus.Controls.Add(this.lblChecked);
            this.gbStatus.Controls.Add(this.label6);
            this.gbStatus.Controls.Add(this.label5);
            this.gbStatus.Controls.Add(this.label4);
            this.gbStatus.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbStatus.Location = new System.Drawing.Point(12, 151);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(200, 110);
            this.gbStatus.TabIndex = 2;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
            // 
            // lblInvalid
            // 
            this.lblInvalid.AutoSize = true;
            this.lblInvalid.Location = new System.Drawing.Point(83, 76);
            this.lblInvalid.Name = "lblInvalid";
            this.lblInvalid.Size = new System.Drawing.Size(14, 15);
            this.lblInvalid.TabIndex = 15;
            this.lblInvalid.Text = "0";
            // 
            // lblValid
            // 
            this.lblValid.AutoSize = true;
            this.lblValid.Location = new System.Drawing.Point(83, 51);
            this.lblValid.Name = "lblValid";
            this.lblValid.Size = new System.Drawing.Size(14, 15);
            this.lblValid.TabIndex = 14;
            this.lblValid.Text = "0";
            // 
            // lblChecked
            // 
            this.lblChecked.AutoSize = true;
            this.lblChecked.Location = new System.Drawing.Point(83, 26);
            this.lblChecked.Name = "lblChecked";
            this.lblChecked.Size = new System.Drawing.Size(24, 15);
            this.lblChecked.TabIndex = 13;
            this.lblChecked.Text = "0/0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Invalid:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Valid:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Checked:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(218, 238);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(299, 238);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 267);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(362, 23);
            this.progressBar.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(218, 209);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(386, 301);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.gbInfo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbInfo;
        private GroupBox gbStatus;
        private Button btnStart;
        private Button btnStop;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtResultsFolder;
        private Button btnDirectory;
        private Button btnAccounts;
        private Button btnProxies;
        private ProgressBar progressBar;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label lblInvalid;
        private Label lblValid;
        private Label lblChecked;
        private Button btnClear;
    }
}