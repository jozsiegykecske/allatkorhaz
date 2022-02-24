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
    public partial class Kutyak : Form
    {
        MySqlConnection conn;
        public Kutyak(MySqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void Kutyak_Shown(object sender, EventArgs e)
        {
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM kutya", conn);
            DataTable kezelesek = new DataTable();
            da.Fill(kezelesek);
            dgvKutyak.DataSource = kezelesek;
            conn.Close();
        }
    }
}
