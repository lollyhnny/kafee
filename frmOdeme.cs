using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyonu
{
    public partial class frmOdeme : Form
    {
        public frmOdeme()
        {
            InitializeComponent();
        }

        private void bnGeriDon_Click(object sender, EventArgs e)
        {
            
            frmMenu frm=new frmMenu();
            this.Close();
            frm.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) ;
            {
                Application.Exit();
            }
        }
        cSiparis cs=new cSiparis();
        int odemeTurId = 0;
        private void frmOdeme_Load(object sender, EventArgs e)
        {
            gbIndirim.Visible = false;
            if (cGenel._ServisTurNo==1)
            {
                lblAdısyonId.Text = cGenel._AdisyonId;
                txtIndirimTutar.TextChanged += new EventHandler(txtIndirimTutar_TextChanged); 
                cs.getByOrder(lvUrunler,Convert.ToInt32(lblAdısyonId.Text));
                if (lvUrunler.Items.Count > 0)
                {
                    decimal toplam = 0;
                    for (int i = 0; i < lvUrunler.Items.Count; i++)
                    {
                        toplam += Convert.ToDecimal(lvUrunler.Items[i].SubItems[3].Text);
                    }
                    lblToplamTutar.Text = string.Format("{0:0.000}", toplam);
                    lblOdenecek.Text = string.Format("{0:0.000}", toplam);
                    decimal kdv = Convert.ToDecimal(lblToplamTutar.Text) * 18 / 100;
                    lblKdv.Text = string.Format("{0:0.000}", kdv);
                }
                gbIndirim.Visible = true;
                txtIndirimTutar.Clear();
            }
            
            else if (cGenel._ServisTurNo==2)
            {
                lblAdısyonId.Text = cGenel._AdisyonId;
                cPaketler pc=new cPaketler();
                odemeTurId=pc.OdemeTurIdGetir(Convert.ToInt32(lblAdısyonId.Text));
                txtIndirimTutar.TextChanged += new EventHandler(txtIndirimTutar_TextChanged);
                cs.getByOrder(lvUrunler, Convert.ToInt32(lblAdısyonId.Text));
                if (odemeTurId==1)
                {
                    rbNakit.Checked= true;
                }
                else if (odemeTurId==2)
                {
                    rbKrediKarti.Checked= true;
                }
                else if (odemeTurId == 3)
                {
                    rbKupon.Checked= true;
                }



                if (lvUrunler.Items.Count > 0)
                {
                    decimal toplam = 0;
                    for (int i = 0; i < lvUrunler.Items.Count; i++)
                    {   
                        toplam += Convert.ToDecimal(lvUrunler.Items[i].SubItems[3].Text);
                    }
                    lblToplamTutar.Text = string.Format("{0:0.000}", toplam);
                    lblOdenecek.Text = string.Format("{0:0.000}", toplam);
                    decimal kdv = Convert.ToDecimal(lblToplamTutar.Text) * 18 / 100;
                    lblKdv.Text = string.Format("{0:0.000}", kdv);
                }
                gbIndirim.Visible = true;
                txtIndirimTutar.Clear();
            }
        }

        private void txtIndirimTutar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(txtIndirimTutar.Text) < Convert.ToDecimal(lblToplamTutar.Text))
                {

                    try
                    {
                        lblIndirim.Text = string.Format("{0:0.000}", Convert.ToDecimal(txtIndirimTutar.Text));
                    }
                    catch (Exception)
                    {

                        lblIndirim.Text = string.Format("{0:0.000}", 0);
                    }
                    
                }
                else
                {
                    MessageBox.Show("İndirim Tutarı Toplam Tutardan Fazla Olamaz!");
                }

            }
            catch (Exception)
            {

                lblIndirim.Text = string.Format("{0:0.000}", 0);
            }
        }

        private void chkIndirim_CheckedChanged(object sender, EventArgs e)
        {
            if(chkIndirim.Checked)
            {
                gbIndirim.Visible= true;
                txtIndirimTutar.Clear();
            }
            else
            {
                gbIndirim.Visible = false;
                txtIndirimTutar.Clear();
            }
        }

        private void lblIndirim_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(lblIndirim.Text) > 0)
            {
                decimal odenecek = 0;
                lblOdenecek.Text = lblToplamTutar.Text;
                odenecek = Convert.ToDecimal(lblOdenecek.Text) - Convert.ToDecimal(lblIndirim.Text);
                lblOdenecek.Text = string.Format("{0:0.000}", odenecek);
            }
            decimal kdv = Convert.ToDecimal(lblToplamTutar.Text) * 18/100;
            lblKdv.Text = string.Format("{0:0.000}", kdv);

        }

        cMasalar masalar= new cMasalar();
        cRezervasyon rezerve=new cRezervasyon();
        private void btnHesapKapat_Click(object sender, EventArgs e)
        {

        }
    }
}
