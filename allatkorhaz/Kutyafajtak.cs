using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace allatkorhaz
{
    public partial class Kutyafajtak : Form
    {
        MySqlConnection conn;
        public Kutyafajtak(MySqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void Kutyafajtak_Shown(object sender, EventArgs e)
        {
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM fajta", conn);
            DataTable kezelesek = new DataTable();
            da.Fill(kezelesek);
            dgvKutyafajtak.DataSource = kezelesek;
            conn.Close();
        }
    }
}
