using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace PuzzleNS
  {
  public partial class Puzzle : Form
    {
    private PictureBox mainpic;
    private object[] pboxlar = new object[25];
    private System.Collections.Hashtable tokenstate = new System.Collections.Hashtable(25);
    private int en,boy;
    private int zorluk = 3;
    private Image resim;
    private int hamle = 0;
    private PuzzleForm  form;
    public Puzzle()
      {

      }
    public Puzzle(PuzzleForm  form, Image resim, int zorluk)
      {
      this.form = form;
      this.resim = resim;
      this.zorluk = zorluk;
      InitializeComponent();
      }

    private void Puzzle_FormClosed(object sender, FormClosedEventArgs e)
      {

      }
    public void Hazirla()
      {
      float fto=boyutHesapla();
      resim=ResimOps.resizeImage(resim, new Size((int)fto,(int) fto));
      pboxlar = new object[zorluk * zorluk];
      tokenstate = new System.Collections.Hashtable(zorluk * zorluk);
      BoxOlustur();
      BoxResimleriYukle();
      resmiCoz();
      resimleriKaristir();
      }
    private float boyutHesapla()
      {
      float max = Math.Max(resim.Height, resim.Width);
      float fitto = Math.Min(panel1.Height,panel1.Width);
      float carpan = fitto / max;
      en = (int)(carpan * resim.Width);
      boy = (int)(carpan * resim.Height);
      return fitto;
      }
    private void BoxOlustur()
      {
      int index = 0;
      for (int i = 0; i < zorluk; i++)
        {
        for (int j = 0; j < zorluk; j++)
          {
          PictureBox pic = new PictureBox();
          pic.Size = new Size(en / zorluk, boy / zorluk);
          if (index == zorluk * zorluk - 1)
            {
            pic.BorderStyle = BorderStyle.None;
            pic.BackColor = Color.Transparent;
            }
          else
            {
            pic.BorderStyle = BorderStyle.FixedSingle;
            pic.BackColor = Color.Transparent;
            }
          pic.Name = string.Format("pbox{0}", index);
          pic.Click += new EventHandler(resimClick);
          pic.Tag = index;
          pboxlar[index] = pic;
          index++;
          }
        }
      }

    private void BoxResimleriYukle()
      {
      mainpic = new PictureBox();
      mainpic.Size = new Size(en, boy);
      mainpic.Location = new Point(0, 0);
      mainpic.Image = resim;
      mainpic.SizeMode = PictureBoxSizeMode.StretchImage;
      int top = 0;
      int left = 0;
      int k = 0;
      Bitmap bmp = new Bitmap(mainpic.Image);
      for (int i = 0; i < zorluk; i++)
        {
        for (int j = 0; j < zorluk; j++)
          {
          PictureBox pbox = (PictureBox)pboxlar[k];
          if (k == zorluk * zorluk - 1)
            {
            pbox.Image = PuzzleNS.Properties.Resources.blank;
             }
          else
            {
            pbox.Image = bmp.Clone(new Rectangle(left, top, en / zorluk, boy / zorluk), System.Drawing.Imaging.PixelFormat.DontCare);
            }
            left += en / zorluk;
          k++;
          }
        left = 0;
        top += boy / zorluk;
        }
      }
    private void resimleriKaristir()
      {
      tokenstate.Clear();
      // hamle sifirlanir - baslangic
      hamle = 0;
      label2.Text = hamle.ToString();
      // hamle siniflanir - bitis
      this.panel1.Controls.Clear(); // paneldeki tüm elemanlar silinir.
      int left = 0;
      int top = 0;
      Random rnd = new Random(); 
      ArrayList gen = new ArrayList(zorluk * zorluk);
      for (int i = 0; i < zorluk * zorluk; i++)
        {

        int yeniResimIndis = rnd.Next(0, zorluk * zorluk);
        while (gen.Contains(yeniResimIndis))
          {
          yeniResimIndis = rnd.Next(0, zorluk * zorluk);
          }
        PictureBox pic = (PictureBox)pboxlar[yeniResimIndis];
        pic.Location = new Point(left, top);
        this.panel1.Controls.Add(pic);
        tokenstate.Add(pic.Tag, i);
        gen.Add(yeniResimIndis);
        left += en / zorluk;
        if ((i + 1) % zorluk == 0)
          {
          left = 0;
          top += boy / zorluk;
          }
        }
      }
    private void resmiCoz()
      {
      tokenstate.Clear();
      this.panel1.Controls.Clear();
      int left = 0;
      int top = 0;
      Random rnd = new Random();
      System.Collections.Hashtable gen = new System.Collections.Hashtable(zorluk * zorluk);
      for (int i = 0; i < zorluk * zorluk; i++)
        {
        PictureBox pic = (PictureBox)pboxlar[i];
        pic.Location = new Point(left, top);
        this.panel1.Controls.Add(pic);
        tokenstate.Add(pic.Tag, i);
        gen.Add(i, i);
        left += en / zorluk;
        if ((i + 1) % zorluk == 0)
          {
          left = 0;
          top += boy / zorluk;
          }
        }
      }

        private void kontrolEt()
        {
            bool yenildi=false;
            for (int i = 0; i < zorluk*zorluk; i++)
            {
            PictureBox tokenpic = (PictureBox)pboxlar[i];
            if (Convert.ToInt32(tokenstate[i]) != i)
              {
              yenildi = true;
              }
            }
            if (yenildi == false)
              {
              MessageBox.Show("Tebrikler, Puzzle'ı Çözmeyi Başardınız!");
              form.st.SkorGirdisi(hamle);
              this.Close();
              }
        }
        private void yerDegistir(ref PictureBox A, ref PictureBox B)
        {
            object temp = tokenstate[A.Tag];
            tokenstate[A.Tag] = tokenstate[B.Tag];
            tokenstate[B.Tag] = temp;
        }
        private void resimClick(object sender, EventArgs e)
        {
            PictureBox pbox = (PictureBox)pboxlar[zorluk*zorluk-1];
            
            PictureBox tiklanan = (PictureBox)sender;
            bool hamleYapildi = false;
            if ((pbox.Left == tiklanan.Left - en / zorluk) && (pbox.Top == tiklanan.Top))
            {
                for (int i = 1; i <= en/zorluk; i++)
                {
                pbox.Left++;
                tiklanan.Left--;
                }
                hamleYapildi = true;
            }
            else if ((pbox.Top == tiklanan.Top - boy / zorluk) && (pbox.Left == tiklanan.Left))
            {
                for (int i = 1; i <= boy/zorluk; i++)
                {
                pbox.Top++;
                tiklanan.Top--;
                }
                hamleYapildi = true;
            }
            else if ((pbox.Top == tiklanan.Top + boy / zorluk) && (pbox.Left == tiklanan.Left))
            {
            for (int i = 1; i <= boy / zorluk; i++)
                {
                pbox.Top--;
                tiklanan.Top++;
                }
            hamleYapildi = true;
            }
            else if ((pbox.Left == tiklanan.Left + en / zorluk) && (pbox.Top == tiklanan.Top))
            {
            for (int i = 1; i <= en / zorluk; i++)
                {
                pbox.Left--;
                tiklanan.Left++;
                }
            hamleYapildi = true;
            }
            if (hamleYapildi)
              {
              hamle++;
              label2.Text = hamle.ToString();
              }
            yerDegistir(ref pbox, ref tiklanan);
            kontrolEt();
        }

        private void button3_Click(object sender, EventArgs e)
          {
          resimleriKaristir();
          }

        private void button2_Click(object sender, EventArgs e)
          {
          this.Close();
          }

        private void button1_Click(object sender, EventArgs e)
          {
          resimleriKaristir();
          hamle = 0;
          label2.Text = hamle.ToString();
          }
    }
  }
