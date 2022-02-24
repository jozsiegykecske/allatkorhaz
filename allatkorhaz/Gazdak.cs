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
    public partial class Gazdak : Form
    {
        MySqlConnection conn;
        public Gazdak(MySqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void Gazdak_Shown(object sender, EventArgs e)
        {
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM gazda", conn);
            DataTable kezelesek = new DataTable();
            da.Fill(kezelesek);
            dgvGazdak.DataSource = kezelesek;
            conn.Close();
        }
    }
}
