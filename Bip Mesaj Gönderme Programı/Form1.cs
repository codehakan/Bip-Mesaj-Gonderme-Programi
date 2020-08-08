using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bip_Mesaj_Gönderme_Programı
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }
        string[] kelimeler;
        int say = 0;
        int gonderilenMesaj = 0;

        void system() {
            if (say == (kelimeler.Length))
                say = 0;
            SendKeys.Send(kelimeler[say++]);
            SendKeys.Send("{ENTER}");
            ++gonderilenMesaj;
            lbl_gonderilen.Text = gonderilenMesaj + " kelime gönderildi.";
        }

        private void timer1_Tick(object sender, EventArgs e) {
            system();
        }

        private void btn_baslat_Click(object sender, EventArgs e) {
            gönderilenKelimeSayacınıSıfırlaToolStripMenuItem.Enabled = false;
            timer2.Interval = 100;
            btn_degistir.Enabled = false;
            txt_hiz.Enabled = false;
            btn_baslat.Enabled = false;
            btn_durdur.Enabled = true;
            txt_gonderilecekMetin.Enabled = false;
            timer1.Start();
            lbl_notice.BackColor = Color.PaleGreen;
            lbl_notice.Text = "Mesaj gönderimi başarılı şekilde başladı.";
            timer2.Start();
        }

        private void btn_durdur_Click(object sender, EventArgs e) {
            gönderilenKelimeSayacınıSıfırlaToolStripMenuItem.Enabled = true;
            timer2.Interval = 100;
            btn_degistir.Enabled = true;
            lbl_notice.Text = "Mesaj gönderimi durduruldu.";
            lbl_notice.BackColor = Color.DarkOrange;
            txt_gonderilecekMetin.Enabled = true;
            btn_baslat.Enabled = true;
            btn_durdur.Enabled = false;
            timer1.Stop();
        }

        private void btn_hazirla_Click(object sender, EventArgs e) {
            timer2.Interval = 100;
            txt_hiz.Enabled = false;
            btn_hazirla.Enabled = false;
            btn_baslat.Enabled = true;
            kelimeler = txt_gonderilecekMetin.Text.Split(' ');
            say = 0;
            timer1.Interval = Convert.ToInt32(txt_hiz.Text);
            lbl_gonderilecek.Text = kelimeler.Length + " kelime ayarlandı.";
            lbl_notice.Text = TimeSpan.FromMilliseconds(Convert.ToInt32(txt_hiz.Text)).TotalSeconds + " saniyede bir adet mesaj gönderecek şekilde ayarlandı.";
            lbl_notice.BackColor = Color.PaleGreen;
            timer2.Start();
        }

        private void txt_hiz_TextChanged(object sender, EventArgs e) {
            btn_hazirla.Enabled = true;
            txt_hiz.BackColor = Color.White;
            timer1.Stop();
            btn_baslat.Enabled = false;
        }

        private void txt_gonderilecekMetin_TextChanged(object sender, EventArgs e) {
            btn_hazirla.Enabled = true;
            btn_baslat.Enabled = false;
            txt_hiz.BackColor = Color.White;
            lbl_notice.Text = "Lütfen tekrar hazırlayın.";
            lbl_notice.BackColor = Color.OrangeRed;
            lbl_notice.Visible = true;
            timer2.Stop();
        }

        private void txt_hiz_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void timer2_Tick(object sender, EventArgs e) {
            lbl_notice.Visible = true;
            if (timer2.Interval >= 600) {
                timer2.Stop();
                lbl_notice.Visible = false;
                timer2.Interval = 100;
            }
            timer2.Interval += 50;
        }

        private void btn_degistir_Click(object sender, EventArgs e) {
            timer2.Interval = 100;
            if (!txt_hiz.Enabled) {
                btn_degistir.Enabled = true;
                txt_hiz.Enabled = true;
            }
            lbl_notice.BackColor = Color.DarkOrange;
            lbl_notice.Text = "Mesaj gönderim süresini lütfen ayarlayıp, hazırla butonuna basınız.";
            timer2.Start();
        }

        private void gönderilenKelimeSayacınıSıfırlaToolStripMenuItem_Click(object sender, EventArgs e) {
            timer2.Interval = 100;
            gonderilenMesaj = 0;
            lbl_gonderilen.Text = gonderilenMesaj + " kelime gönderildi.";
            lbl_notice.BackColor = Color.DarkOrange;
            lbl_notice.Text = "Gönderilen mesaj sayısı sıfırlandı.";
            timer2.Start();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Bu program Hakan AKKAYA tarafından kodlanmıştır.\n\nİletişim: code.hakan@gmail.com", "Hakkında", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
