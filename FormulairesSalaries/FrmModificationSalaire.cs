using Poo3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormulairesSalaries
{
    public partial class FrmModificationSalaire : Form
    {
        public FrmModificationSalaire()
        {
            InitializeComponent();
            tbSalaire.Text = sal3.SalaireBrut.ToString();
        }
        Salarie sal3 = new Salarie("Grotte", "Pascal", "63CCC17");
        private void btnValider_Click(object sender, EventArgs e)
        {
            sal3.ChangementSalaire += new Salarie.ChangementSalaireEventHandler(Salarie_ChangementSalaire);
     
        }

        void Salarie_ChangementSalaire(object sender, ChangementSalaireEventArgs e)
        {
            MessageBox.Show(string.Format("Votre salaire est passé de {0} à {1}", e.AncienSalaire, e.NouveauSalaire));
        }
        private void btnValider_Validating(object sender, CancelEventArgs e)
        {
            //Salarie sal = new Salarie("Grotte", "Pascal", "47POT74");
            //sal.SalaireBrut = 1500m;
            //sal.ChangementSalaire +=
            //sal.SalaireBrut = 


            
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAncienSalaire_Click(object sender, EventArgs e)
        {
           
        }
    }
}
