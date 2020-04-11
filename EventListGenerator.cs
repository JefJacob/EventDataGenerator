using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventDataGenerator
{
    public partial class EventListGenerator : Form
    {

        public string constr = ConfigurationManager.ConnectionStrings["AODB"].ConnectionString;
        public EventListGenerator()
        {
            InitializeComponent();
        }

        private void EventListGenerator_Load(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(100, 88, 44, 55);
            PopulateComboBox();
            PopulateDataDridView();
            
        }
        void PopulateDataDridView()
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from AthleteEventListAll", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvEventList.DataSource = dt;
            }
        }
        void PopulateComboBox()
        {
            DataTable table = new DataTable();
           
            table.Columns.Add("SortingOrder", typeof(string));
            table.Rows.Add( "Ascending");
            table.Rows.Add( "Descending");
            cmbSortingOrder.ValueMember = "SortingOrder";
            cmbSortingOrder.DisplayMember = "SortingOrder";
            //DataRow dr = table.NewRow();
            //dr[0] = "-Select-"; 
            //table.Rows.InsertAt(dr, 0);
            cmbSortingOrder.DataSource = table;
           

        }

        private void dgvEventList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEventList.CurrentRow != null)
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    try
                    {
                        conn.Open();
                        DataGridViewRow dgvRow = dgvEventList.CurrentRow;
                        SqlCommand cd = new SqlCommand("EventListAddUpdate", conn);
                        cd.CommandType = CommandType.StoredProcedure;
                        if (dgvRow.Cells["txtId"].Value == DBNull.Value)
                            cd.Parameters.AddWithValue("@Id", 0);
                        else
                            cd.Parameters.AddWithValue("@Id", Convert.ToInt32(dgvRow.Cells["txtId"].Value));
                        cd.Parameters.AddWithValue("@Name", dgvRow.Cells["txtName"].Value == DBNull.Value ? "" : dgvRow.Cells["txtName"].Value.ToString());
                        cd.Parameters.AddWithValue("@SortingOrder", dgvRow.Cells["cmbSortingOrder"].Value == DBNull.Value ? "" : dgvRow.Cells["cmbSortingOrder"].Value.ToString());
                        cd.ExecuteNonQuery();
                        PopulateDataDridView();
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.Contains("UNIQUE"))
                        {
                            MessageBox.Show("Duplicate Entry", "Alert");
                            PopulateDataDridView();
                        }
                        else
                            MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void dgvEventList_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //e.Control.KeyPress -= AllowNumbersOnly;
            //if (dgvEventList.CurrentCell.ColumnIndex == 2)
            //{
            //    e.Control.KeyPress -= AllowNumbersOnly;
            //    e.Control.KeyPress += AllowNumbersOnly;
            //}

        }
        //private void AllowNumbersOnly(Object Sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        //        e.Handled = true;
        //}

        private void dgvEventList_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dgvEventList.CurrentRow.Cells["txtId"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Confirm Delete", "DataGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();

                        SqlCommand cd = new SqlCommand("EventListDelete", conn);
                        
                        cd.CommandType = CommandType.StoredProcedure;
                        cd.Parameters.AddWithValue("@Id", Convert.ToInt32(dgvEventList.CurrentRow.Cells["txtId"].Value));
                        cd.ExecuteNonQuery();
                       
                    }
                }
                else
                    e.Cancel = true;
            }
            else
                e.Cancel = true;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Point lastPoint;
        private void EventListGenerator_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void EventListGenerator_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserGenerator usr = new UserGenerator();
            usr.ShowDialog();
        }
    }

}
