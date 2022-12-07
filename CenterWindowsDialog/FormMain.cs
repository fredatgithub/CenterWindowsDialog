using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CenterWindowsDialog
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    private void ButtonOpendialog_Click(object sender, EventArgs e)
    {
      FormOption form = new FormOption();
      form.ShowDialog();
    }
  }
}
