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
    public partial class UserGenerator : Form
    {
        public string constr = ConfigurationManager.ConnectionStrings["AODB"].ConnectionString;
        public UserGenerator()
        {
            InitializeComponent();
        }

        private void UserGenerator_Load(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(100, 88, 44, 55);
            PopulateUserDataDridView();
        }
        void PopulateUserDataDridView()
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from [User]", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUser.AutoGenerateColumns = false;
                dgvUser.DataSource = dt;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvUser.CurrentRow != null)
            {
                PasswordGeneroator pwd = new PasswordGeneroator(Convert.ToInt32(dgvUser.CurrentRow.Cells["txtUserID"].Value));
                pwd.ShowDialog();
            }
            else
                MessageBox.Show("Please select a User");
        }

        private void dgvUser_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUser.CurrentRow != null)
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    try
                    {
                        conn.Open();
                        DataGridViewRow dgvRow = dgvUser.CurrentRow;
                        SqlCommand cd = new SqlCommand("uspAddUser", conn);
                        cd.CommandType = CommandType.StoredProcedure;
                        if (dgvRow.Cells["txtUserID"].Value == DBNull.Value)
                            cd.Parameters.AddWithValue("@Id", 0);
                        else
                            cd.Parameters.AddWithValue("@Id", Convert.ToInt32(dgvRow.Cells["txtUserID"].Value));
                        cd.Parameters.AddWithValue("@pLogin", dgvRow.Cells["txtUserName"].Value == DBNull.Value ? "" : dgvRow.Cells["txtUserName"].Value.ToString());
                        cd.Parameters.AddWithValue("@pFirstName", dgvRow.Cells["txtFirstName"].Value == DBNull.Value ? "" : dgvRow.Cells["txtFirstName"].Value.ToString());
                        cd.Parameters.AddWithValue("@pLastName", dgvRow.Cells["txtLastName"].Value == DBNull.Value ? "" : dgvRow.Cells["txtLastName"].Value.ToString());
                        cd.Parameters.AddWithValue("@email", dgvRow.Cells["txtEmail"].Value == DBNull.Value ? "" : dgvRow.Cells["txtEmail"].Value.ToString());

                        cd.ExecuteNonQuery();
                        PopulateUserDataDridView();
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.Contains("UNIQUE"))
                        {
                            MessageBox.Show("Duplicate Entry", "Alert");
                            PopulateUserDataDridView();
                        }
                        else
                            MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void dgvUser_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dgvUser.CurrentRow.Cells["txtUserID"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Confirm Delete", "DataGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();

                        SqlCommand cd = new SqlCommand("UserDelete", conn);

                        cd.CommandType = CommandType.StoredProcedure;
                        cd.Parameters.AddWithValue("@Id", Convert.ToInt32(dgvUser.CurrentRow.Cells["txtUserID"].Value));
                        cd.ExecuteNonQuery();

                    }
                }
                else
                    e.Cancel = true;
            }
            else
                e.Cancel = true;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
