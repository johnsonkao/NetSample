namespace OpenData
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.lblSiteId = new System.Windows.Forms.Label();
            this.txtSiteId = new System.Windows.Forms.TextBox();
            this.txtSiteName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTownship = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTWD67Lon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "GetOpenData";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSiteId
            // 
            this.lblSiteId.AutoSize = true;
            this.lblSiteId.Location = new System.Drawing.Point(52, 108);
            this.lblSiteId.Name = "lblSiteId";
            this.lblSiteId.Size = new System.Drawing.Size(32, 12);
            this.lblSiteId.TabIndex = 1;
            this.lblSiteId.Text = "SiteId";
            // 
            // txtSiteId
            // 
            this.txtSiteId.Location = new System.Drawing.Point(128, 105);
            this.txtSiteId.Name = "txtSiteId";
            this.txtSiteId.Size = new System.Drawing.Size(100, 22);
            this.txtSiteId.TabIndex = 2;
            // 
            // txtSiteName
            // 
            this.txtSiteName.Location = new System.Drawing.Point(128, 143);
            this.txtSiteName.Name = "txtSiteName";
            this.txtSiteName.Size = new System.Drawing.Size(100, 22);
            this.txtSiteName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "SiteName";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(128, 182);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(100, 22);
            this.txtCountry.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "County";
            // 
            // txtTownship
            // 
            this.txtTownship.Location = new System.Drawing.Point(128, 223);
            this.txtTownship.Name = "txtTownship";
            this.txtTownship.Size = new System.Drawing.Size(100, 22);
            this.txtTownship.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Township";
            // 
            // txtTWD67Lon
            // 
            this.txtTWD67Lon.Location = new System.Drawing.Point(128, 263);
            this.txtTWD67Lon.Name = "txtTWD67Lon";
            this.txtTWD67Lon.Size = new System.Drawing.Size(100, 22);
            this.txtTWD67Lon.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "TWD67Lon";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 367);
            this.Controls.Add(this.txtTWD67Lon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTownship);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSiteName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSiteId);
            this.Controls.Add(this.lblSiteId);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "s";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSiteId;
        private System.Windows.Forms.TextBox txtSiteId;
        private System.Windows.Forms.TextBox txtSiteName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTownship;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTWD67Lon;
        private System.Windows.Forms.Label label4;
    }
}

