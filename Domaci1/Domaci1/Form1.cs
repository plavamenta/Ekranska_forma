using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Domaci1
{
    public partial class Form1 : Form
    {
        string cs = "Data source = DESKTOP-809VKAP\\SQLEXPRESS; Initial catalog = Pesme; Integrated security = true";
        DataTable podaci = new DataTable();
        SqlConnection veza;
        string naziv, izvodjac, trajanje, jezik;
        SqlDataAdapter adapter;
        int zastava = 0;

        private void but_update_Click(object sender, EventArgs e)
        {
            veza = new SqlConnection(cs);
            naziv = txt_naziv.Text;
            izvodjac = txt_izvodjac.Text;
            trajanje = txt_trajanje.Text;
            jezik = txt_jezik.Text;
            if (naziv == "" && izvodjac == "" && trajanje == "" && jezik== "" )
                MessageBox.Show("Niste uneli nijedan podatak za updateovanje");
            veza.Open();
            SqlCommand naredba = new SqlCommand($"update pesma set naziv = '{naziv}', izvodjac = '{izvodjac}', trajanje = '{trajanje}', jezik = '{jezik}' where id = {txt_id.Text}", veza);
            naredba.ExecuteNonQuery();
            veza.Close();
            podaci.Clear();
            adapter = new SqlDataAdapter("select * from pesma", veza);
            adapter.Fill(podaci);
            Refresh();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            veza = new SqlConnection(cs);
            adapter = new SqlDataAdapter("select * from pesma", veza);
            adapter.Fill(podaci);
            txt_id.Enabled = false;
            Refresh();
        }

        private void but_delete_Click(object sender, EventArgs e)
        {
            veza = new SqlConnection(cs);
            SqlCommand naredba = new SqlCommand(String.Format($"delete from pesma where id={txt_id.Text}"), veza);
            veza.Open();
            naredba.ExecuteNonQuery();
            veza.Close();
            podaci.Clear();
            adapter = new SqlDataAdapter("select * from pesma", veza);
            adapter.Fill(podaci);
            zastava = 0;
            Refresh();
        }

        private void but_clear_Click(object sender, EventArgs e)
        {
            txt_naziv.Text = "";
            txt_izvodjac.Text = "";
            txt_trajanje.Text = "";
            txt_jezik.Text = "";
        }

        private void but_levolevo_Click(object sender, EventArgs e)
        {
            zastava = 0;
            Refresh();

        }

        private void but_levo_Click(object sender, EventArgs e)
        {
            if (zastava - 1 >= 0)
            {
                zastava--;
                Refresh();
            }

        }

        private void but_desno_Click(object sender, EventArgs e)
        {
            if (zastava + 1 <= podaci.Rows.Count)
            {
                zastava++;
                Refresh();
            }
        }

        private void but_desnodesno_Click(object sender, EventArgs e)
        {
            zastava = podaci.Rows.Count - 1;
            Refresh();
            
        }

        void Refresh()
        {
            if (podaci.Rows.Count == 0)
            {
                but_delete.Enabled = false;
                but_update.Enabled = false;
                but_desno.Enabled = false;
                but_desnodesno.Enabled = false;
                but_levo.Enabled = false;
                but_levolevo.Enabled = false;
                txt_id.Text = "";
                txt_naziv.Text = "";
                txt_izvodjac.Text = "";
                txt_trajanje.Text = "";
                txt_jezik.Text = "";
                
            }
            else
            {
                txt_id.Text = podaci.Rows[zastava]["id"].ToString();
                txt_naziv.Text = podaci.Rows[zastava]["naziv"].ToString();
                txt_izvodjac.Text = podaci.Rows[zastava]["izvodjac"].ToString();
                txt_trajanje.Text = podaci.Rows[zastava]["trajanje"].ToString();
                txt_jezik.Text = podaci.Rows[zastava]["jezik"].ToString();
                but_levo.Enabled = (zastava != 0);
                but_levolevo.Enabled = (zastava != podaci.Rows.Count - 1);
                but_desno.Enabled = (zastava != podaci.Rows.Count - 1);
                but_desnodesno.Enabled = (zastava!= 0);
                
            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(cs);
            naziv = txt_naziv.Text;
            izvodjac = txt_izvodjac.Text;
            trajanje = txt_trajanje.Text;
            jezik = txt_jezik.Text;
            veza.Open();
            SqlCommand naredba = new SqlCommand($"insert into pesma values('{naziv}','{izvodjac}','{trajanje}','{jezik}')", veza);
            naredba.ExecuteNonQuery();
            veza.Close();
            podaci.Clear();
            adapter = new SqlDataAdapter("select * from pesma", veza);
            adapter.Fill(podaci);
            zastava = podaci.Rows.Count - 1;
            Refresh();
        }
    }
}
