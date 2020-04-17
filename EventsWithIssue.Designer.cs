namespace EventDataGenerator
{
    partial class EventsWithIssue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventsWithIssue));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvIssueEvents = new System.Windows.Forms.DataGridView();
            this.txtEventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssueEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvIssueEvents);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 399);
            this.panel1.TabIndex = 0;
            // 
            // dgvIssueEvents
            // 
            this.dgvIssueEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIssueEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtEventName});
            this.dgvIssueEvents.Location = new System.Drawing.Point(4, 4);
            this.dgvIssueEvents.Name = "dgvIssueEvents";
            this.dgvIssueEvents.Size = new System.Drawing.Size(391, 392);
            this.dgvIssueEvents.TabIndex = 0;
            // 
            // txtEventName
            // 
            this.txtEventName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtEventName.DataPropertyName = "EventName";
            this.txtEventName.HeaderText = "EventNamewithIssue";
            this.txtEventName.Name = "txtEventName";
            // 
            // EventsWithIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 399);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EventsWithIssue";
            this.Text = "EventsWithIssue";
            this.Load += new System.EventHandler(this.EventsWithIssue_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssueEvents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvIssueEvents;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEventName;
    }
}