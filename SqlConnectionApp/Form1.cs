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

namespace SqlConnectionApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Global Connection için bağlantı
       SqlConnection cnn2 = new SqlConnection("Server =.; Database=Northwind; UID=sa; PWD=123");


        //Local Connection
        private void btnLocalConn_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Server =.; Database=Northwind; UID=sa; PWD=123");

            try
            {
                if(cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                    MessageBox.Show("Local Bağlantı açıldı");
                }

                else 
                {
                    cnn.Close();
                    MessageBox.Show("Local Bağlantı kapandı");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Bağlantı hatası" + ex.Message);
            }
        }

        //Global Connection
        private void btnGlobalConn_Click(object sender, EventArgs e)
        {
            try
            {
                if (cnn2.State == ConnectionState.Closed)
                {
                    cnn2.Open();
                    MessageBox.Show("Global Bağlantı açıldı");
                }

                else
                {
                    cnn2.Close();
                    MessageBox.Show("Global Bağlantı kapandı");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Bağlantı hatası" + ex.Message);
            }
        }

        //Class Connection
        private void btnClassConn_Click(object sender, EventArgs e)
        {
            SqlConnection cnnClass = new SqlConnection(Tools.ConnectionString());

            try
            {
                if (cnnClass.State == ConnectionState.Closed)
                {
                    cnnClass.Open();
                    MessageBox.Show("Class Bağlantısı açıldı");
                }

                else
                {
                    cnnClass.Close();
                    MessageBox.Show("Class Bağlantısı kapandı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı hatası" + ex.Message);
            }
        }

        //AppConfig Bağlantısı
        private void btnAppConfigConn_Click(object sender, EventArgs e)
        {
            SqlConnection cnnApp = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);

            try
            {
                if (cnnApp.State == ConnectionState.Closed)
                {
                    cnnApp.Open();
                    MessageBox.Show("App.Config Bağlantısı açıldı");
                }

                else
                {
                    cnnApp.Close();
                    MessageBox.Show("App.Config Bağlantısı kapandı");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Bağlantı hatası" + ex.Message);
            }
        }
    }
}
