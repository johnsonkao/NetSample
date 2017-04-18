namespace CSharpAddEvent
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
            this.btnOri = new System.Windows.Forms.Button();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.btnRemoveEvent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOri
            // 
            this.btnOri.Location = new System.Drawing.Point(81, 50);
            this.btnOri.Name = "btnOri";
            this.btnOri.Size = new System.Drawing.Size(106, 23);
            this.btnOri.TabIndex = 0;
            this.btnOri.Text = "原始按鈕";
            this.btnOri.UseVisualStyleBackColor = true;
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Location = new System.Drawing.Point(81, 112);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(106, 23);
            this.btnAddEvent.TabIndex = 1;
            this.btnAddEvent.Text = " Add Event";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // btnRemoveEvent
            // 
            this.btnRemoveEvent.Location = new System.Drawing.Point(81, 176);
            this.btnRemoveEvent.Name = "btnRemoveEvent";
            this.btnRemoveEvent.Size = new System.Drawing.Size(106, 23);
            this.btnRemoveEvent.TabIndex = 2;
            this.btnRemoveEvent.Text = "Remove  Event";
            this.btnRemoveEvent.UseVisualStyleBackColor = true;
            this.btnRemoveEvent.Click += new System.EventHandler(this.btnRemoveEvent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnRemoveEvent);
            this.Controls.Add(this.btnAddEvent);
            this.Controls.Add(this.btnOri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOri;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.Button btnRemoveEvent;
    }
}

