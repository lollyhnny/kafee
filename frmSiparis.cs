﻿using System;
using System.Collections;
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
    public partial class frmSiparis : Form
    {
        public frmSiparis()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) ;
            {
                Application.Exit();
            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Close();
            frm.Show();
        }

        //hesap işlemi
        void islem(Object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "btn1":
                    txtAdet.Text += (1).ToString();
                    break;
                case "btn2":
                    txtAdet.Text += (2).ToString();
                    break;
                case "btn3":
                    txtAdet.Text += (3).ToString();
                    break;
                case "btn4":
                    txtAdet.Text += (4).ToString();
                    break;
                case "btn5":
                    txtAdet.Text += (5).ToString();
                    break;
                case "btn6":
                    txtAdet.Text += (6).ToString();
                    break;
                case "btn7":
                    txtAdet.Text += (7).ToString();
                    break;
                case "btn8":
                    txtAdet.Text += (8).ToString();
                    break;
                case "btn9":
                    txtAdet.Text += (9).ToString();
                    break;

                case "btn0":
                    txtAdet.Text += (0).ToString();
                    break;

                default:
                    MessageBox.Show("Sayı giriniz!");
                    break;
            }
        }
        int tableId = 0; int additionId = 0;
        private void frmSiparis_Load(object sender, EventArgs e)
        {
            lblMasaNo.Text = cGenel._ButtonValue;
            cMasalar ms = new cMasalar();
            tableId = ms.TableGetByNumber(cGenel._ButtonName);
            if (ms.TableGetByState(tableId, 2) == true || ms.TableGetByState(tableId, 4) == true)
            {
                cAdisyon ad = new cAdisyon();
                additionId = ad.getByAddition(tableId);
                cSiparis siparis = new cSiparis();
                siparis.getByOrder(lvSiparisler, additionId);
            }

            btn1.Click += new EventHandler(islem);
            btn2.Click += new EventHandler(islem);
            btn3.Click += new EventHandler(islem);
            btn4.Click += new EventHandler(islem);
            btn5.Click += new EventHandler(islem);
            btn6.Click += new EventHandler(islem);
            btn7.Click += new EventHandler(islem);
            btn8.Click += new EventHandler(islem);
            btn9.Click += new EventHandler(islem);
            btn0.Click += new EventHandler(islem);



        }
        cUrunCesitleri uc = new cUrunCesitleri();
        private void btnAnaYemek3_Click(object sender, EventArgs e)
        {

            uc.getByProductTypes(lvMenu, btnAnaYemek3);

        }

        private void btnIcecek8_Click(object sender, EventArgs e)
        {
            uc.getByProductTypes(lvMenu, btnIcecek8);
        }

        private void btnTatlilar7_Click(object sender, EventArgs e)
        {
            uc.getByProductTypes(lvMenu, btnTatlilar7);

        }

        private void btnSalata6_Click(object sender, EventArgs e)
        {
            uc.getByProductTypes(lvMenu, btnSalata6);

        }

        private void btnFastFood5_Click(object sender, EventArgs e)
        {
            uc.getByProductTypes(lvMenu, btnFastFood5);
        }

        private void btnCorba1_Click(object sender, EventArgs e)
        {
            uc.getByProductTypes(lvMenu, btnCorba1);
        }

        private void btnKahvalti4_Click(object sender, EventArgs e)
        {
            uc.getByProductTypes(lvMenu, btnKahvalti4);
        }

        private void btnAraSicak2_Click(object sender, EventArgs e)
        {
            uc.getByProductTypes(lvMenu, btnAraSicak2);
        }

        int sayac = 0; int sayac2 = 0;
        private void lvMenu_DoubleClick(object sender, EventArgs e)
        {
            if (txtAdet.Text == "")

            {
                txtAdet.Text = "1";

            }
            if (lvMenu.Items.Count > 0)
            {
                sayac = lvSiparisler.Items.Count;
                lvSiparisler.Items.Add(lvMenu.SelectedItems[0].Text);
                lvSiparisler.Items[sayac].SubItems.Add(txtAdet.Text);
                lvSiparisler.Items[sayac].SubItems.Add(lvMenu.SelectedItems[0].SubItems[2].Text);
                lvSiparisler.Items[sayac].SubItems.Add((Convert.ToDecimal(lvMenu.SelectedItems[0].SubItems[1].Text) * Convert.ToDecimal
                (txtAdet.Text)).ToString());
                lvSiparisler.Items[sayac].SubItems.Add("0");

                sayac2 = lvYeniEklenenler.Items.Count;
                lvSiparisler.Items[sayac].SubItems.Add(sayac2.ToString());
                lvYeniEklenenler.Items.Add(additionId.ToString());
                lvYeniEklenenler.Items[sayac2].SubItems.Add(lvMenu.SelectedItems[0].SubItems[2].Text);
                lvYeniEklenenler.Items[sayac2].SubItems.Add(txtAdet.Text);
                lvYeniEklenenler.Items[sayac2].SubItems.Add(tableId.ToString());
                lvYeniEklenenler.Items[sayac2].SubItems.Add(sayac2.ToString());
                sayac2++;
                txtAdet.Text = "";
            }


        }

        ArrayList silinenler=new ArrayList();
        
        private void btnSiparis_Click(object sender, EventArgs e)
        {
            //1 masa bos
            //2 masa dolu
            //3 acik rezerve
            //4 rezevrve
            cSiparis saveOrder = new cSiparis();
            cMasalar masa = new cMasalar();
            cAdisyon newAddition = new cAdisyon();
            frmMasalar fm = new frmMasalar();

            bool sonuc = false;
            if (masa.TableGetByState(tableId, 1) == true)
            {
                newAddition.ServisTurNo = 1;
                
                newAddition.PersonelId = 1;
                newAddition.MasaId = tableId;
                newAddition.Tarih = DateTime.Now;
                sonuc = newAddition.setByAdditionNew(newAddition);
                masa.setChangeTableState(cGenel._ButtonName, 2);


                if (lvSiparisler.Items.Count > 0)
                {
                    for (int i = 0; i < lvSiparisler.Items.Count; i++)
                    {
                        saveOrder.MasaId = tableId;
                        saveOrder.UrunId = Convert.ToInt32(lvSiparisler.Items[i].SubItems[2].Text);
                        saveOrder.AdisyonId = newAddition.getByAddition(tableId);
                        saveOrder.Adet = Convert.ToInt32(lvSiparisler.Items[i].SubItems[1].Text);
                        saveOrder.setSaveOrder(saveOrder);
                    }//ürün bilgilerini yolladık
                    this.Close();
                    fm.Show();
                }

            }
            else if (masa.TableGetByState(tableId, 2) == true || masa.TableGetByState(tableId, 4) == true)
            {
                if (lvYeniEklenenler.Items.Count > 0)
                {
                    for (int i = 0; i < lvYeniEklenenler.Items.Count; i++)
                    {
                        saveOrder.MasaId = tableId;
                        saveOrder.UrunId = Convert.ToInt32(lvYeniEklenenler.Items[i].SubItems[1].Text);
                        saveOrder.AdisyonId = newAddition.getByAddition(tableId);
                        saveOrder.Adet = Convert.ToInt32(lvYeniEklenenler.Items[i].SubItems[2].Text);
                        saveOrder.setSaveOrder(saveOrder);
                    }
                    cGenel._AdisyonId= Convert.ToString(newAddition.getByAddition(tableId));
                }
                if (silinenler.Count > 0)
                {
                    foreach (string item in silinenler)
                    {
                        saveOrder.setDeleteOrder(Convert.ToInt32(item));
                    }
                }
                this.Close();
                fm.Show();


            }
            else if (masa.TableGetByState(tableId, 3) == true)//açık rezerve masalarda müşteri gelip sipariş verdiğinde masa durumu rezerve yapıldı
            {
                
                newAddition.ServisTurNo = 1;
                newAddition.PersonelId = 1;
                newAddition.MasaId = tableId;
                newAddition.Tarih = DateTime.Now;
                sonuc = newAddition.setByAdditionNew(newAddition);
                masa.setChangeTableState(cGenel._ButtonName, 4);


                if (lvSiparisler.Items.Count > 0)
                {
                    for (int i = 0; i < lvSiparisler.Items.Count; i++)
                    {
                        saveOrder.MasaId = tableId;
                        saveOrder.UrunId = Convert.ToInt32(lvSiparisler.Items[i].SubItems[2].Text);
                        saveOrder.AdisyonId = newAddition.getByAddition(tableId);
                        saveOrder.Adet = Convert.ToInt32(lvSiparisler.Items[i].SubItems[1].Text);
                        saveOrder.setSaveOrder(saveOrder);
                    }//ürün bilgilerini yolladık
                    this.Close();
                    fm.Show();
                }
            }
        }

        private void lvSiparisler_DoubleClick(object sender, EventArgs e)
        {
            if (lvSiparisler.Items.Count > 0)
            {
                if (lvSiparisler.SelectedItems[0].SubItems[4].Text != "0")
                {

                    cSiparis saveOrder = new cSiparis();
                    saveOrder.setDeleteOrder(Convert.ToInt32(lvSiparisler.Items[0].SubItems[4].Text));
                }
                else
                {
                    for (int i = 0; i < lvYeniEklenenler.Items.Count; i++)
                    {

                        if (lvYeniEklenenler.Items[i].SubItems[4].Text == lvSiparisler.SelectedItems[0].SubItems[5].Text)
                        {
                            
                          lvYeniEklenenler.Items.RemoveAt(i);
                            
                        }
                    }

                }
                lvSiparisler.Items.RemoveAt(lvSiparisler.SelectedItems[0].Index);
            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (txtAra.Text=="")
            {
                txtAra.Text = "";
            }
            else
            {
                cUrunCesitleri cu = new cUrunCesitleri();
                cu.getByProductSearch(lvMenu, Convert.ToInt32(txtAra.Text));
            }
        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            cGenel._ServisTurNo = 1;
            cGenel._AdisyonId=additionId.ToString();
            frmOdeme frm= new frmOdeme();
            this.Close();
            frm.Show();
        }
    }

}