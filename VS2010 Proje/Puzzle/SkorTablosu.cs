using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PuzzleNS
  {
  public class SkorTablosu
    {
    private ListBox lb;
    public SkorTablosu()
      {

      }
    public SkorTablosu(ListBox lb)
      {
      this.lb = lb;
      }
    public void SkorGirdisi(int puan)
      {
      SkorGir temp = new SkorGir(puan,this);
      temp.Show();
      }
    public void SkorEkle(String isim, int puan)
      {
      StreamWriter sw = new StreamWriter("scores.txt", true);
      sw.WriteLine(isim+" "+puan.ToString());
      sw.Close();
      yenile();
      }
    public void yenile()
      {
      this.lb.Items.Clear();
      string satir;

      StreamReader dosya = new StreamReader("scores.txt");
      while ((satir = dosya.ReadLine()) != null)
        {
        lb.Items.Add(satir);
        }

      dosya.Close();
      }
    }
  }
