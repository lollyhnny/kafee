namespace CafeOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cPersoneller p = new cPersoneller();
            p.personelGetbyInformation(cbKullanici);

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            cPersoneller p = new cPersoneller();
            cGenel gnl = new cGenel();
            bool result = p.personelEntryControl(txtSifre.Text, cGenel._personelId);
            if (result)
            {


                this.Hide();
                frmMenu menu = new frmMenu();
                menu.Show();

            }
            else
            {
                MessageBox.Show("Þifre Hatalý", "Uyarý!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void cbKullanici_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPersoneller p = (cPersoneller)cbKullanici.SelectedItem;
            cGenel._personelId = p.PersonelId;
            cGenel._gorevId = p.PersonelGorevid;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Uygulamadan çýkmak istiyor musunuz?", "Uyarý!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}