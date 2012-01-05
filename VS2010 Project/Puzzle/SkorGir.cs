using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PuzzleNS
  {
  public partial class SkorGir : Form
    {
    private SkorTablosu st;
    private int Skor;
    public SkorGir(int Skor,SkorTablosu st)
      {
      this.Skor = Skor;
      this.st = st;
      InitializeComponent();
      }
    private void SkoruYolla()
      {
      if (textBox1.Text.Length > 0)
        {
        st.SkorEkle(textBox1.Text, Skor);
        this.Close();
        }
      else
        {
        MessageBox.Show("İsim Girmediniz");
        }
      }
    private void button1_Click(object sender, EventArgs e)
      {
      SkoruYolla();
      }

    private void button2_Click(object sender, EventArgs e)
      {
      this.Close();
      }

    private void SkorGir_Load(object sender, EventArgs e)
      {
      label2.Text = this.Skor.ToString();
      }

    private void textBox1_KeyDown(object sender, KeyEventArgs e)
      {
      if (e.KeyCode == Keys.Enter)
        {
        SkoruYolla();
        }
      }

    }
  }
