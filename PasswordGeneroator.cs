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
    public partial class PasswordGeneroator : Form
    {
        public string constr = ConfigurationManager.ConnectionStrings["AODB"].ConnectionString;
        public int Userid = 0;

        public PasswordGeneroator(int id)
        {
            Userid = id;
            InitializeComponent();
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {

            if (txtPassword.Text.ToString() == txtConfirmPassword.Text.ToString()&& txtPassword.Text.ToString()!="")
            {
                if (MessageBox.Show("Confirm Update Password", "DataGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();

                        SqlCommand cd = new SqlCommand("uspPwdGenerator", conn);

                        cd.CommandType = CommandType.StoredProcedure;
                        cd.Parameters.AddWithValue("@Id", Userid);
                        cd.Parameters.AddWithValue("@pPassword", txtPassword.Text.ToString());

                        cd.ExecuteNonQuery();

                    }
                }
                this.Close();
            }
            else MessageBox.Show("Passwords do not Match");
        }

        private void PasswordGeneroator_Load(object sender, EventArgs e)
        {
            int uid = 0;
            string name = "";
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();

                SqlCommand cd = new SqlCommand("select * from [User] where UserId=@Id", conn);

                //cd.CommandType = CommandType.StoredProcedure;
                cd.Parameters.AddWithValue("@Id", Userid);
                SqlDataReader proReader =
                     cd.ExecuteReader(
                         System.Data.CommandBehavior.SingleRow);
                if (proReader.Read())
                {
                    uid = Convert.ToInt32(proReader["UserId"]);
                    name = proReader["LoginName"].ToString();
                }
                else
                {
                    uid = 0; ;
                }


            }
            if (uid == 0)
            {
                MessageBox.Show("Invalid User id");
                this.Close();
            }
            lblDisplayName.Text = $"Update Password for {name}";
            //this.Userid = uid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }

}