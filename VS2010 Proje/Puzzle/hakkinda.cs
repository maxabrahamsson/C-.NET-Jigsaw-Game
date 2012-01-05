using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PuzzleNS
  {
  public partial class hakkinda : Form
    {
    public hakkinda()
      {
      InitializeComponent();
      }

    private void hakkinda_Load(object sender, EventArgs e)
      {
     
      }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
      {
      System.Diagnostics.Process.Start("http://mclightning.com/index.php#puzzle");
      }
    }
  }
