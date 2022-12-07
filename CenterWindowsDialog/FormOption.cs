using System;
using System.Windows.Forms;

namespace CenterWindowsDialog
{
  public partial class FormOption : Form
  {
    public FormOption()
    {
      InitializeComponent();
    }

    private void ButtonCancel_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void ButtonOK_Click(object sender, EventArgs e)
    {
      using (new CenterWinDialog(this))
      {
        MessageBox.Show("Une erreur s'est produite lors du chargement de la valeur de ...", "Erreur connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

    }
  }
}
