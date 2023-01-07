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
using System.Resources;

namespace CafeOtomasyonu
{
    public partial class frmMasalar : Form
    {
        public frmMasalar()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes);
            {
                Application.Exit();
            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmMenu frm=new frmMenu();
            this.Close();
            frm.Show();
        }

        private void btnMasa_1_Click(object sender, EventArgs e)
        {
            frmSiparis frm=new frmSiparis();
            int uzunluk = btnMasa_1.Text.Length;
            cGenel._ButtonValue = btnMasa_1.Text.Substring(uzunluk-6,6);
            cGenel._ButtonName= btnMasa_1.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa_2_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa_2.Text.Length;
            cGenel._ButtonValue = btnMasa_2.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = btnMasa_2.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa_3_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa_3.Text.Length;
            cGenel._ButtonValue = btnMasa_3.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = btnMasa_3.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa_4_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa_4.Text.Length;
            cGenel._ButtonValue = btnMasa_4.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = btnMasa_4.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa_5_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa_5.Text.Length;
            cGenel._ButtonValue = btnMasa_5.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = btnMasa_5.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa_6_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa_6.Text.Length;
            cGenel._ButtonValue = btnMasa_6.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = btnMasa_6.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa_7_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa_7.Text.Length;
            cGenel._ButtonValue = btnMasa_7.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = btnMasa_7.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa_8_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa_8.Text.Length;
            cGenel._ButtonValue = btnMasa_8.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = btnMasa_8.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa_9_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa_9.Text.Length;
            cGenel._ButtonValue = btnMasa_9.Text.Substring(uzunluk - 6, 6);
            cGenel._ButtonName = btnMasa_9.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa_10_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa_10.Text.Length;
            cGenel._ButtonValue = btnMasa_10.Text.Substring(uzunluk - 7, 7);
            cGenel._ButtonName = btnMasa_10.Name;
            this.Close();
            frm.ShowDialog();
        }
        
        cGenel gnl=new cGenel();
        private void frmMasalar_Load(object sender, EventArgs e)

        {   
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select DURUM,ID from Masalar",con);
            SqlDataReader dr = null;
            
            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {   //masaların durumlarının kontrolü
                foreach(Control item in this.Controls)
                {
                    if (item is Button)
                    {
                        if (item.Name == "btnMasa_" + dr["ID"].ToString() && dr["DURUM"].ToString()=="1")

                        {
                            item.BackgroundImage=(System.Drawing.Image)(Properties.Resources.bos);
                        }
                        else if (item.Name == "btnMasa_" + dr["ID"].ToString() && dr["DURUM"].ToString() == "2")
                        {
                            cMasalar ms= new cMasalar();
                            //dolu masalar için ne kadar süredir dolu olduğunun bilgisi
                            /*DateTime dt1 = Convert.ToDateTime(ms.SessionSum(2,dr["ID"].ToString()));
                            DateTime dt2=DateTime.Now;

                            string st1 = Convert.ToDateTime(ms.SessionSum(2,dr["ID"].ToString())).ToShortTimeString();
                            string st2=DateTime.Now.ToShortTimeString();

                            DateTime t1 = dt1.AddMinutes(DateTime.Parse(st1).TimeOfDay.TotalMinutes);
                            DateTime t2 = dt2.AddMinutes(DateTime.Parse(st2).TimeOfDay.TotalMinutes);

                            var fark = t2 - t1;

                            item.Text = String.Format("{0}{1}{2}",
                                fark.Days>0? string.Format("{0} Gün",fark.Days):"",
                                fark.Hours>0? string.Format("{0} Saat",fark.Hours):"",
                                fark.Minutes>0? string.Format("{0} Dakika", fark.Minutes) : "").Trim() + "\n\n\nMasa" + dr["ID"].ToString();*/

                            item.BackgroundImage = (System.Drawing.Image)(Properties.Resources.dolu);

                        }
                        else if (item.Name == "btnMasa_" + dr["ID"].ToString() && dr["DURUM"].ToString() == "3")
                        {
                            item.BackgroundImage=(System.Drawing.Image)(Properties.Resources.acikrezerve);
                        }
                        else if (item.Name == "btnMasa_" + dr["ID"].ToString() && dr["DURUM"].ToString() == "4")
                        {
                            item.BackgroundImage = (System.Drawing.Image)(Properties.Resources.rezerve);
                        }
                    }
                }
            }
            dr.Close();
            con.Close();

            
        }
    } 
}
