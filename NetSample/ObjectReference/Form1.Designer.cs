namespace ObjectReference
{
    partial class frmForm1
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
            this.btnAddObjectToList = new System.Windows.Forms.Button();
            this.dvShow = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddObjectToList
            // 
            this.btnAddObjectToList.Location = new System.Drawing.Point(98, 23);
            this.btnAddObjectToList.Name = "btnAddObjectToList";
            this.btnAddObjectToList.Size = new System.Drawing.Size(153, 41);
            this.btnAddObjectToList.TabIndex = 0;
            this.btnAddObjectToList.Text = "Add Object To List";
            this.btnAddObjectToList.UseVisualStyleBackColor = true;
            this.btnAddObjectToList.Click += new System.EventHandler(this.btnAddObjectToList_Click);
            // 
            // dvShow
            // 
            this.dvShow.AllowUserToAddRows = false;
            this.dvShow.AllowUserToDeleteRows = false;
            this.dvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.StdName});
            this.dvShow.Location = new System.Drawing.Point(63, 106);
            this.dvShow.Name = "dvShow";
            this.dvShow.ReadOnly = true;
            this.dvShow.RowTemplate.Height = 24;
            this.dvShow.Size = new System.Drawing.Size(272, 283);
            this.dvShow.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // StdName
            // 
            this.StdName.DataPropertyName = "Name";
            this.StdName.HeaderText = "Name";
            this.StdName.Name = "StdName";
            this.StdName.ReadOnly = true;
            // 
            // frmForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 430);
            this.Controls.Add(this.dvShow);
            this.Controls.Add(this.btnAddObjectToList);
            this.Name = "frmForm1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dvShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddObjectToList;
        private System.Windows.Forms.DataGridView dvShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StdName;
    }
}

