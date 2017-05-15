namespace DateTimeTest
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
            this.btnSaveT1 = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblT1 = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.lblNow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSaveT1
            // 
            this.btnSaveT1.Location = new System.Drawing.Point(31, 56);
            this.btnSaveT1.Name = "btnSaveT1";
            this.btnSaveT1.Size = new System.Drawing.Size(75, 23);
            this.btnSaveT1.TabIndex = 0;
            this.btnSaveT1.Text = "Save T1 ";
            this.btnSaveT1.UseVisualStyleBackColor = true;
            this.btnSaveT1.Click += new System.EventHandler(this.btnSaveT1_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(31, 107);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculates";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblT1
            // 
            this.lblT1.AutoSize = true;
            this.lblT1.Location = new System.Drawing.Point(139, 62);
            this.lblT1.Name = "lblT1";
            this.lblT1.Size = new System.Drawing.Size(33, 12);
            this.lblT1.TabIndex = 2;
            this.lblT1.Text = "label1";
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Location = new System.Drawing.Point(129, 172);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(33, 12);
            this.lblSec.TabIndex = 3;
            this.lblSec.Text = "label1";
            // 
            // lblNow
            // 
            this.lblNow.AutoSize = true;
            this.lblNow.Location = new System.Drawing.Point(139, 114);
            this.lblNow.Name = "lblNow";
            this.lblNow.Size = new System.Drawing.Size(33, 12);
            this.lblNow.TabIndex = 4;
            this.lblNow.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 199);
            this.Controls.Add(this.lblNow);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.lblT1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnSaveT1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveT1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblT1;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label lblNow;
    }
}

