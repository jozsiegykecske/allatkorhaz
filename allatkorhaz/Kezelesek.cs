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
    public partial class Kezelesek : Form
    {
        MySqlConnection conn;
        public Kezelesek(MySqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void Kezelesek_Shown(object sender, EventArgs e)
        {
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM kezeles",conn);
            DataTable kezelesek = new DataTable();
            da.Fill(kezelesek);
            dgvKezelesek.DataSource = kezelesek;
            conn.Close();
        }
    }
}
