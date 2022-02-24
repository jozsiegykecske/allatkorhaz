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
    public partial class Fomenu : Form
    {
        MySqlConnection conn;
        User user;
        public Fomenu(User user,MySqlConnection conn)
        {
            InitializeComponent();
            this.user = user;
            this.conn = conn;
            string jog = user.Jogkor == 1 ? "admin" : "user";
            if (user.Jogkor == 0)
            {
                btnKutyafajtak.Enabled = false;
                btnGazdak.Enabled = false;
                btnKutyak.Enabled = false;
                btnKezelesfajtak.Enabled = false;
            }
            this.Text = $"Főmenü - {user.Nev} ({jog})";
        }

        private void btnKezelesek_Click(object sender, EventArgs e)
        {
            Kezelesek kez = new Kezelesek(conn);
            kez.ShowDialog();
        }

        private void Fomenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGazdak_Click(object sender, EventArgs e)
        {
            Gazdak gazdak = new Gazdak(conn);
            gazdak.ShowDialog();
        }

        private void btnKutyafajtak_Click(object sender, EventArgs e)
        {
            Kutyafajtak k = new Kutyafajtak(conn);
            k.ShowDialog();
        }

        private void btnKutyak_Click(object sender, EventArgs e)
        {
            Kutyak k = new Kutyak(conn);
            k.ShowDialog();
        }

        private void btnKezelesfajtak_Click(object sender, EventArgs e)
        {
            Kezelesfajtak k = new Kezelesfajtak(conn);
            k.ShowDialog();
        }
    }
}
