using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicNEW
{
    public partial class DeletePacienti : Form
    {
        #region Initializarea noilor date pentru stergerea pacientilor
        public string CNPS
        {
            get
            {
                return txtCNPS.Text;

            }
            set
            {
                txtCNPS.Text = value;
            }
        }

        public DateTime DataCurenta
        {
            get
            {
                return Convert.ToDateTime(dpDataCurenta.Text);
            }
            set
            {
                dpDataCurenta.Text = Convert.ToString(value);
            }
        }
        public string NumeComplet
        {
            get
            {
                return txtNumeComplet.Text;

            }
            set
            {
                txtNumeComplet.Text = value;
            }
        }
        public string Motive
        {
            get
            {
                return txtMotive.Text;

            }
            set
            {
                txtMotive.Text = value;
            }
        }
        #endregion
        public DeletePacienti()
        {
            InitializeComponent();
        }

        public void raportStergereBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.raportStergereBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.familieMDataSet);

        }

        public void DeletePacienti_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'familieMDataSet.RaportStergere' table. You can move, or remove it, as needed.
            this.raportStergereTableAdapter.Fill(this.familieMDataSet.RaportStergere);
            

        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            Consultatii consultatii = new Consultatii();
            //Verific daca este validat CNP
            
            if (txtCNPS.TextLength != 13)
            {
                txtCNPS.Focus();
                errorCNPS.SetError(txtCNPS, "CNP trebuie sa contina 13 numere!");


            }
            //Verific daca exista CNP in tabela Pacienti, daca exista il sterg si il adaug in tabelul de rapoarte
            else if (txtCNPS.TextLength == 13 && mPacientiTableAdapter.DeleteCNP(CNPS)>0 &&  raportStergereTableAdapter.SelectCNPS(familieMDataSet.RaportStergere, CNPS) == 0)
            {
                DialogResult = DialogResult.OK;
                raportStergereTableAdapter.Insert(CNPS, NumeComplet, DataCurenta, Motive);
                raportStergereTableAdapter.Fill(familieMDataSet.RaportStergere);
                
                
             } 
            //Daca acesta nu exista, o sa afisez un mesaj de eroare
            else if (txtCNPS.TextLength == 13 && mPacientiTableAdapter.DeleteCNP(CNPS) == 0 && raportStergereTableAdapter.SelectCNPS(familieMDataSet.RaportStergere, CNPS) == 0)
            {
                DialogResult = DialogResult.Cancel;
                MessageBox.Show("Nu exista acest CNP in baza de date");

            }else if (txtCNPS.TextLength == 13 && mPacientiTableAdapter.DeleteCNP(CNPS) == 0 && raportStergereTableAdapter.SelectCNPS(familieMDataSet.RaportStergere, CNPS) > 0)
            {
                mPacientiTableAdapter.Fill(familieMDataSet.MPacienti);
                DialogResult = DialogResult.Cancel;
                MessageBox.Show("Acest pacient "+txtCNPS.Text+" a mai fost sters din baza de date, nu-l mai introducem in tabelul Raport");
                
            }
        }

        private void raportStergereDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void raportStergereBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.raportStergereBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.familieMDataSet);

        }
    }
}
