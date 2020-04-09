namespace EventDataGenerator
{
    partial class EventListGenerator
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
            this.dgvEventList = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEventList
            // 
            this.dgvEventList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtId,
            this.txtName});
            this.dgvEventList.Location = new System.Drawing.Point(12, 12);
            this.dgvEventList.Name = "dgvEventList";
            this.dgvEventList.Size = new System.Drawing.Size(406, 272);
            this.dgvEventList.TabIndex = 0;
            this.dgvEventList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEventList_CellValueChanged);
            this.dgvEventList.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvEventList_UserDeletingRow);
            // 
            // txtId
            // 
            this.txtId.DataPropertyName = "Id";
            this.txtId.HeaderText = "Id";
            this.txtId.Name = "txtId";
            this.txtId.Visible = false;
            // 
            // txtName
            // 
            this.txtName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtName.DataPropertyName = "EventName";
            this.txtName.HeaderText = "EventName";
            this.txtName.Name = "txtName";
            // 
            // EventListGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvEventList);
            this.Name = "EventListGenerator";
            this.Text = "EventListGenerator";
            this.Load += new System.EventHandler(this.EventListGenerator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEventList;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtName;
    }
}