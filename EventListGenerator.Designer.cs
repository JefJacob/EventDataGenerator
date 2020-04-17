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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventListGenerator));
            this.dgvEventList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbSortingOrder = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cmbMarkUnit = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventList)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEventList
            // 
            this.dgvEventList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEventList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEventList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEventList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtId,
            this.txtName,
            this.cmbSortingOrder,
            this.cmbMarkUnit});
            this.dgvEventList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvEventList.Location = new System.Drawing.Point(168, 12);
            this.dgvEventList.Name = "dgvEventList";
            this.dgvEventList.Size = new System.Drawing.Size(491, 392);
            this.dgvEventList.TabIndex = 0;
            this.dgvEventList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEventList_CellValueChanged);
            this.dgvEventList.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvEventList_UserDeletingRow);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dgvEventList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 416);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(152, 416);
            this.panel3.TabIndex = 2;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            // 
            // button3
            // 
            this.button3.AutoEllipsis = true;
            this.button3.BackColor = System.Drawing.Color.ForestGreen;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(0, 336);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "Add/Delete User";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.AutoEllipsis = true;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(0, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.No;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 125);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.AutoEllipsis = true;
            this.button4.BackColor = System.Drawing.Color.ForestGreen;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(0, 296);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "Show Event List in DB";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtId
            // 
            this.txtId.DataPropertyName = "Id";
            this.txtId.HeaderText = "Id";
            this.txtId.Name = "txtId";
            this.txtId.Width = 42;
            // 
            // txtName
            // 
            this.txtName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtName.DataPropertyName = "EventName";
            this.txtName.HeaderText = "EventName";
            this.txtName.Name = "txtName";
            // 
            // cmbSortingOrder
            // 
            this.cmbSortingOrder.DataPropertyName = "SortingOrder";
            this.cmbSortingOrder.HeaderText = "SortingOrder";
            this.cmbSortingOrder.Name = "cmbSortingOrder";
            this.cmbSortingOrder.Width = 85;
            // 
            // cmbMarkUnit
            // 
            this.cmbMarkUnit.DataPropertyName = "MarkUnit";
            this.cmbMarkUnit.HeaderText = "MarkUnit";
            this.cmbMarkUnit.Name = "cmbMarkUnit";
            this.cmbMarkUnit.Width = 64;
            // 
            // button5
            // 
            this.button5.AutoEllipsis = true;
            this.button5.BackColor = System.Drawing.Color.ForestGreen;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(0, 256);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(152, 40);
            this.button5.TabIndex = 4;
            this.button5.Text = "Event Names with Issue";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // EventListGenerator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(681, 416);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EventListGenerator";
            this.Text = "EventListGenerator";
            this.Load += new System.EventHandler(this.EventListGenerator_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EventListGenerator_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EventListGenerator_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEventList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtName;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbSortingOrder;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbMarkUnit;
        private System.Windows.Forms.Button button5;
    }
}