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
    public partial class EventsWithIssue : Form
    {
        public string constr = ConfigurationManager.ConnectionStrings["AODB"].ConnectionString;
        public EventsWithIssue()
        {
            InitializeComponent();
        }

        private void EventsWithIssue_Load(object sender, EventArgs e)
        {
            PopulateDataDridView();
        }
        void PopulateDataDridView()
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select distinct eventname from viewAthDetailsBySubRole where eventname not in (select v.EventName from viewAthDetailsBySubRole v inner join AthleteEventListAll a on v.EventName like '%' + a.EventName + '%')", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvIssueEvents.DataSource = dt;
            }
        }
    }
}
