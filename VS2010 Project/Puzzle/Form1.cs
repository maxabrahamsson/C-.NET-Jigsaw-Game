using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace PuzzleNS
{
    public partial class PuzzleForm : Form
    {
        private Image resim;
        private Puzzle pz = new Puzzle();
        private hakkinda hk = new hakkinda();
        public SkorTablosu st;
        public PuzzleForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void resimSec()
          {
          DialogResult r = DialogResult.Cancel;
          do
            {
            MessageBox.Show("Resim Seçiniz");
            r=openFileDialog1.ShowDialog();
            }
          while (r!=DialogResult.OK);
            resim = Image.FromFile(openFileDialog1.FileName);
            button1.BackgroundImage =ResimOps.resizeImage(resim, new Size(button1.Width, button1.Height));
          }
        private void puzzleBaslat()
          {
          int zorluk = 4;
          for (int i = 0; i < groupBox2.Controls.Count; i++)
            {
            RadioButton rb = (RadioButton)groupBox2.Controls[i];
            if (rb.Checked == true)
              {
              zorluk = rb.TabIndex;
              }
            }
          pz = new Puzzle(this, resim, zorluk);
          pz.Hazirla();
          pz.Show();
          }
        private void button1_Click(object sender, EventArgs e)
          {
          resimSec();
          }
        private void button2_Click(object sender, EventArgs e)
          {
          if (resim != null)
            {
            puzzleBaslat();
            }
          else
            {
            resimSec();
            }
          }

        private void button3_Click(object sender, EventArgs e)
          {
           hk.Show();
          }

        private void jigsaw_Load(object sender, EventArgs e)
          {
          st = new SkorTablosu(listBox1);
          st.yenile();
          }
    }
}