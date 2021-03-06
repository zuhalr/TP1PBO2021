using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class MenuUtama : Form
    {
        Barang[] barang = new Barang[5];
        public MenuUtama()
        {
            InitializeComponent();
            String[] nama = new String[] { "Handphone", "Headphone", "Kemeja", "Spaghetti", "Pizza" };
            String[] jenis = new String[] { "Elektronik", "Elektronik", "Pakaian", "Makanan", "Makanan"};
            int[] harga = new int[] { 750000,400000,175000,600000,300000};
            int[] range = new int[] { 3, 2, 1, 3, 2 };
            for (int i = 0; i < 5; i++)
            {
                barang[i] = new Barang(nama[i], jenis[i], harga[i],range[i]);
            }

            lblNama1.Text = barang[0].NamaBarang;
            lblHarga1.Text = "Rp." + barang[0].HargaBarang;
            lblNama2.Text = barang[1].NamaBarang;
            lblHarga2.Text = "Rp." + barang[1].HargaBarang;
            lblNama3.Text = barang[2].NamaBarang;
            lblHarga3.Text = "Rp." + barang[2].HargaBarang;
            lblNama4.Text = barang[3].NamaBarang;
            lblHarga4.Text = "Rp." + barang[3].HargaBarang;
            lblNama5.Text = barang[4].NamaBarang;
            lblHarga5.Text = "Rp." + barang[4].HargaBarang;

            btnHarga1.Height = 0;
            btnHarga2.Height = 0;
            btnHarga3.Height = 0;

            btnBaju.Height = 0;
            btnElektronik.Height = 0;
            btnMakanan.Height = 0;
            btnKembali.Visible = false;
            reset();
        }

        private void btnJenisBarang_Click(object sender, EventArgs e)
        {
            if(btnBaju.Height == 0)
            {
                btnBaju.Height = 39;
                btnElektronik.Height = 39;
                btnMakanan.Height = 39;
            }
            else
            {
                btnBaju.Height = 0;
                btnElektronik.Height = 0;
                btnMakanan.Height = 0;
            }
            
        }

        private void btnElektronik_Click(object sender, EventArgs e)
        {
            btnJenisBarang.Text = "Elektronik";
            btnBaju.Height = 0;
            btnElektronik.Height = 0;
            btnMakanan.Height = 0;
        }

        private void btnBaju_Click(object sender, EventArgs e)
        {
            btnJenisBarang.Text = "Pakaian";
            btnBaju.Height = 0;
            btnElektronik.Height = 0;
            btnMakanan.Height = 0;
        }

        private void btnMakanan_Click(object sender, EventArgs e)
        {
            btnJenisBarang.Text = "Makanan";
            btnBaju.Height = 0;
            btnElektronik.Height = 0;
            btnMakanan.Height = 0;
        }

        private void btnHarga_Click(object sender, EventArgs e)
        {
            if (btnHarga3.Height == 0)
            {
                btnHarga1.Height = 39;
                btnHarga2.Height = 39;
                btnHarga3.Height = 39;
            }
            else
            {
                btnHarga1.Height = 0;
                btnHarga2.Height = 0;
                btnHarga3.Height = 0;
            }
        }

        private void btnHarga1_Click(object sender, EventArgs e)
        {
            btnHarga.Text = "100rb - 200rb";
            btnHarga1.Height = 0;
            btnHarga2.Height = 0;
            btnHarga3.Height = 0;
        }

        private void btnHarga2_Click(object sender, EventArgs e)
        {
            btnHarga.Text = "200rb - 500rb";
            btnHarga1.Height = 0;
            btnHarga2.Height = 0;
            btnHarga3.Height = 0;
        }

        private void btnHarga3_Click(object sender, EventArgs e)
        {
            btnHarga.Text = "500rb - 1jt";
            btnHarga1.Height = 0;
            btnHarga2.Height = 0;
            btnHarga3.Height = 0;
        }
        public void locationbarang1(int x,int y)
        {
            pbBarang1.Location = new System.Drawing.Point(x, y);
            lblNama1.Location = new System.Drawing.Point(x+15, y+125);
            lblHarga1.Location = new System.Drawing.Point(x+5, y+150);
            btnBeli1.Location = new System.Drawing.Point(x+15, y+180);
        }
        public void locationbarang2(int x, int y)
        {
            pbBarang2.Location = new System.Drawing.Point(x, y);
            lblNama2.Location = new System.Drawing.Point(x + 15, y + 125);
            lblHarga2.Location = new System.Drawing.Point(x + 5, y + 150);
            btnBeli2.Location = new System.Drawing.Point(x + 15, y + 180);
        }
        public void locationbarang3(int x, int y)
        {
            pbBarang3.Location = new System.Drawing.Point(x, y);
            lblNama3.Location = new System.Drawing.Point(x + 15, y + 125);
            lblHarga3.Location = new System.Drawing.Point(x + 5, y + 150);
            btnBeli3.Location = new System.Drawing.Point(x + 15, y + 180);
        }
        public void locationbarang4(int x, int y)
        {
            pbBarang4.Location = new System.Drawing.Point(x, y);
            lblNama4.Location = new System.Drawing.Point(x + 15, y + 125);
            lblHarga4.Location = new System.Drawing.Point(x + 5, y + 150);
            btnBeli4.Location = new System.Drawing.Point(x + 15, y + 180);
        }
        public void locationbarang5(int x, int y)
        {
            pbBarang5.Location = new System.Drawing.Point(x, y);
            lblNama5.Location = new System.Drawing.Point(x + 15, y + 125);
            lblHarga5.Location = new System.Drawing.Point(x + 5, y + 150);
            btnBeli5.Location = new System.Drawing.Point(x + 15, y + 180);
        }
        public void visiblebarang1(bool x)
        {
            pbBarang1.Visible = x;
            lblHarga1.Visible = x;
            lblNama1.Visible = x;
            btnBeli1.Visible = x;
        }
        public void visiblebarang2(bool x)
        {
            pbBarang2.Visible = x;
            lblHarga2.Visible = x;
            lblNama2.Visible = x;
            btnBeli2.Visible = x;
        }
        public void visiblebarang3(bool x)
        {
            pbBarang3.Visible = x;
            lblHarga3.Visible = x;
            lblNama3.Visible = x;
            btnBeli3.Visible = x;
        }
        public void visiblebarang4(bool x)
        {
            pbBarang4.Visible = x;
            lblHarga4.Visible = x;
            lblNama4.Visible = x;
            btnBeli4.Visible = x;
        }
        public void visiblebarang5(bool x)
        {
            pbBarang5.Visible = x;
            lblHarga5.Visible = x;
            lblNama5.Visible = x;
            btnBeli5.Visible = x;
        }
        public void reset()
        {
            locationbarang1(210, 136);
            locationbarang2(340, 136);
            locationbarang3(470, 136);
            locationbarang4(600, 136);
            locationbarang5(730, 136);

            visiblebarang1(true);
            visiblebarang2(true);
            visiblebarang3(true);
            visiblebarang4(true);
            visiblebarang5(true);
            lblNotFound.Visible = false;
        }
        private void btnCari_Click(object sender, EventArgs e)
        {
            string jenis = Convert.ToString(btnJenisBarang.Text);
            if(btnHarga.Text == "Harga" || jenis == "Jenis Barang")
            {
                MessageBox.Show("Harap masukkan jenis/harga Barang", "Error");
            }
            else
            {
                reset();
                int rangeharga = 0;
                if(btnHarga.Text == "500rb - 1jt")
                {
                    rangeharga = 3;
                }
                if(btnHarga.Text == "200rb - 500rb")
                {
                    rangeharga = 2;
                }
                if (btnHarga.Text == "100rb - 200rb")
                {
                    rangeharga = 1;
                }
                int counter = 0;
                int position = 225;
                if (barang[0].range == rangeharga && barang[0].JenisBarang == jenis)
                {
                    locationbarang1(position + counter * 145, 136);
                    counter++;
                }
                else
                {
                    visiblebarang1(false);
                }
                
                if (barang[1].range == rangeharga && barang[1].JenisBarang == jenis)
                {
                    locationbarang2(position + counter * 145, 136);
                    counter++;
                }
                else
                {
                    visiblebarang2(false);
                }
                if (barang[2].range == rangeharga && barang[2].JenisBarang == jenis)
                {
                    locationbarang3(position + counter* 145, 136);
                    counter++;
                }
                else
                {
                    visiblebarang3(false);
                }
                if (barang[3].range == rangeharga && barang[3].JenisBarang == jenis)
                {
                    locationbarang4(position + counter * 140, 136);
                    counter++;
                }
                else
                {
                    visiblebarang4(false);
                }
                if (barang[4].range == rangeharga && barang[4].JenisBarang == jenis)
                {
                    locationbarang5(position + counter * 140, 136);
                }
                else
                {
                    visiblebarang5(false);
                }
                btnJenisBarang.Visible = false;
                btnHarga.Visible = false;
                btnCari.Visible = false;
                btnKembali.Visible = true;
                if(counter == 0)
                {
                    lblNotFound.Visible = true;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tokopedia.com");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tokopedia.com");
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            reset();
            btnHarga.Text = "Harga";
            btnJenisBarang.Text = "Jenis Barang";
            btnJenisBarang.Visible = true;
            btnHarga.Visible = true;
            btnCari.Visible = true;
            btnKembali.Visible = false;
        }

        private void btnBeli5_Click(object sender, EventArgs e)
        {
            locationbarang5(225, 136);

            visiblebarang1(false);
            visiblebarang4(false);
            visiblebarang3(false);
            visiblebarang2(false);

            btnJenisBarang.Visible = false;
            btnHarga.Visible = false;
            btnCari.Visible = false;
            btnKembali.Visible = true;
        }

        private void btnBeli4_Click(object sender, EventArgs e)
        {
            locationbarang4(225, 136);

            visiblebarang1(false);
            visiblebarang5(false);
            visiblebarang3(false);
            visiblebarang2(false);

            btnJenisBarang.Visible = false;
            btnHarga.Visible = false;
            btnCari.Visible = false;
            btnKembali.Visible = true;
        }

        private void btnBeli3_Click(object sender, EventArgs e)
        {
            locationbarang3(225, 136);

            visiblebarang1(false);
            visiblebarang4(false);
            visiblebarang5(false);
            visiblebarang2(false);

            btnJenisBarang.Visible = false;
            btnHarga.Visible = false;
            btnCari.Visible = false;
            btnKembali.Visible = true;
        }

        private void btnBeli1_Click(object sender, EventArgs e)
        {
            locationbarang1(225, 136);

            visiblebarang5(false);
            visiblebarang4(false);
            visiblebarang3(false);
            visiblebarang2(false);

            btnJenisBarang.Visible = false;
            btnHarga.Visible = false;
            btnCari.Visible = false;
            btnKembali.Visible = true;
        }

        private void btnBeli2_Click(object sender, EventArgs e)
        {
            locationbarang2(225, 136);

            visiblebarang1(false);
            visiblebarang4(false);
            visiblebarang3(false);
            visiblebarang5(false);

            btnJenisBarang.Visible = false;
            btnHarga.Visible = false;
            btnCari.Visible = false;
            btnKembali.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 logout = new Form1();
            logout.Show();
            MessageBox.Show("Kamu Sudah Logout|", "Warning!");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 logout = new Form1();
            logout.Show();
            MessageBox.Show("Kamu Sudah Logout|", "Warning!");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            reset();
            btnHarga.Text = "Harga";
            btnJenisBarang.Text = "Jenis Barang";
            btnJenisBarang.Visible = true;
            btnHarga.Visible = true;
            btnCari.Visible = true;
            btnKembali.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            reset();
            btnHarga.Text = "Harga";
            btnJenisBarang.Text = "Jenis Barang";
            btnJenisBarang.Visible = true;
            btnHarga.Visible = true;
            btnCari.Visible = true;
            btnKembali.Visible = false;
        }
    }
}
