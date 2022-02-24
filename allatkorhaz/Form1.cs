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
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        User user;
        public Form1()
        {
            InitializeComponent();
            conn = new MySqlConnection($"server=localhost;uid=root;database=centrum");
        }

        private void btnKuldes_Click(object sender, EventArgs e)
        {
            string fnev = tbFnev.Text;
            string jelszo = tbJelszo.Text;
            if (fnev != "" && jelszo != "")
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand($"SELECT * from dolgozok WHERE fnev = '{fnev}' AND jelszo = '{jelszo}'", conn);
                    MySqlDataReader result = cmd.ExecuteReader();

                    if (result.HasRows)
                    {
                        while (result.Read())
                        {
                            user = new User(Convert.ToInt32(result[0]), result[3].ToString(), Convert.ToInt32(result[4]));
                            Fomenu fmenu = new Fomenu(user, conn);
                            fmenu.Show();
                            Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nincs ilyen felhasználó!");
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hiba lépett fel: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Töltse ki a mezőket!");
            }
           
        }
    }
}
