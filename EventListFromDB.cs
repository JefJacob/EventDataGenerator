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
    public partial class EventListFromDB : Form
    {
        public string constr = ConfigurationManager.ConnectionStrings["AODB"].ConnectionString;
        public EventListFromDB()
        {
            InitializeComponent();
        }

        private void EventListFromDB_Load(object sender, EventArgs e)
        {
            PopulateDataDridView();
        }

        void PopulateDataDridView()
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select distinct Eventname from viewAthDetailsBySubRole", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvEventList.DataSource = dt;
            }
        }
    }
}
