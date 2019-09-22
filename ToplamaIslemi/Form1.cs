using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToplamaIslemi
{
    public partial class Toplamaİşlemi : Form
    {
        public Toplamaİşlemi()
        {
            InitializeComponent();

        }
        void LogYaz(string mesaj)
        {
            lvLog.Items.Add(mesaj);

        }
        void EkranıHazirla()
        {
            txtsayi1.Text = "0";
            txtsayi2.Text = "0";
            txtsayi1.Focus();

        }

        int Topla(int say1, int say2)
        {
            //ToDo

            return (say1+say2);
        }

        Boolean Doğrula()
        {
            try
            {
                Convert.ToInt32(txtsayi1.Text);
                Convert.ToInt32(txtsayi2.Text);

            }
            catch (Exception)
            {
                txtsayi1.Focus();
                return false;
            }

            return true;
        }

        private void BtnToplama_Click(object sender, EventArgs e)
        {
           // string mesaj;
            
            if (Doğrula())
            {
                int toplam;
                toplam=Topla(Convert.ToInt32(txtsayi1.Text), Convert.ToInt32(txtsayi2.Text));
                txtSonuc.Text = toplam.ToString();
                LogYaz("Toplama İşlemi Başarılı . Birinci sayi :" + txtsayi1.Text + ",İkinci sayi" + txtsayi2.Text);

                EkranıHazirla();
                

            }
            else
            {
                MessageBox.Show("HATALI GİRİŞ !!!");
                LogYaz("Toplama İşlemi Başarı. Birinci sayi :" + txtsayi1.Text + ",İkinci sayi" + txtsayi2.Text);
                txtSonuc.Text = "!$?%&";
            }




        }

      

        private void Toplamaİşlemi_Shown(object sender, EventArgs e)
        {
            EkranıHazirla();
        }


        private void txtsayi1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                            char.IsLetter(e.KeyChar) ||
                            char.IsSymbol(e.KeyChar) ||
                            char.IsWhiteSpace(e.KeyChar) ||
                            char.IsPunctuation(e.KeyChar)

                            )
            {
                e.Handled = true;
            }
        }

        private void txtsayi2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                char.IsLetter(e.KeyChar) ||
                char.IsSymbol(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) ||
                char.IsPunctuation(e.KeyChar)

                )
            {
                e.Handled = true;
            }
        }

        private void Toplamaİşlemi_Load(object sender, EventArgs e)
        {
            EkranıHazirla();
        }

        private void btnİleri_Click(object sender, EventArgs e)
        {
            TabToplamGenel.SelectedTab = TabLog;
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            TabToplamGenel.SelectedTab = TabToplama;

        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            lvLog.SelectedItems[0].Remove();
            ;
        }
    }
}
