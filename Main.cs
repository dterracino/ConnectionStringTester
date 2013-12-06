using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectionStringTester
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {

            try
            {

                using (SqlConnection conn = new SqlConnection(this.txtConnectionString.Text))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select 1", conn);
                    cmd.ExecuteNonQuery();
                }

                this.txtResult.Text = "Success!";
            }
            catch (Exception ex)
            {
                this.txtResult.Text = "Error! " + ex.Message;
            }
        }
    }
}
