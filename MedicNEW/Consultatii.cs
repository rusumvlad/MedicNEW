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
    public partial class Consultatii : Form
    {
        public Consultatii()
        {
            InitializeComponent();
        }

        #region Initializarea noilor date pentru adaugarea unei consultatii
        public string CNPC
        {
            get
            {
                return txtCNPC.Text;

            }
            set
            {
                txtCNPC.Text = value;
            }
        }

        public DateTime DataConsultatiei
        {
            get
            {
                return Convert.ToDateTime(dpDataConsultatiei.Text);
            }
            set
            {
                dpDataConsultatiei.Text = Convert.ToString(value);
            }
        }
        public string NumeCompletC
        {
            get
            {
                return txtNumeCompletC.Text;

            }
            set
            {
                txtNumeCompletC.Text = value;
            }
        }
        public string Reteta
        {
            get
            {
                return txtReteta.Text;

            }
            set
            {
                txtReteta.Text = value;
            }
        }
        #endregion


        private void consultatiiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.consultatiiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.familieMDataSet);

        }

        private void Consultatii_Load(object sender, EventArgs e)
        {
            
            mPacientiTableAdapter.Fill(familieMDataSet.MPacienti);
            // TODO: This line of code loads data into the 'familieMDataSet.Consultatii' table. You can move, or remove it, as needed.
            this.consultatiiTableAdapter.Fill(this.familieMDataSet.Consultatii);
            


        }

        private void btnAdaugaCon_Click(object sender, EventArgs e)
        {
            if (txtCNPC.TextLength != 13)
            {
                txtCNPC.Focus();
                errorCNPC.SetError(txtCNPC, "CNP trebuie sa contina 13 numere!");


            }
            //Verific daca exista CNP in tabela Pacienti, daca exista il sterg si il adaug in tabelul de rapoarte
            else if (txtCNPC.TextLength == 13 && mPacientiTableAdapter.SelectCNP(familieMDataSet.MPacienti, CNPC) > 0)
            {
                DialogResult = DialogResult.OK;
                consultatiiTableAdapter.Insert(CNPC, NumeCompletC, DataConsultatiei, Reteta);
                consultatiiTableAdapter.Fill(familieMDataSet.Consultatii);
                

            }
            //Daca acesta nu exista, o sa afisez un mesaj de eroare
            else if (txtCNPC.TextLength == 13 && mPacientiTableAdapter.SelectCNP(familieMDataSet.MPacienti, CNPC) == 0)
            {
                MessageBox.Show("Nu exista acest pacient");
                DialogResult = DialogResult.Cancel;
                

            }
            
        }

        private void btnCautaCon_Click(object sender, EventArgs e)
        {
            string searchCNPCON = txtCautaCon.Text;
            if (consultatiiTableAdapter.SelectCNPCON(familieMDataSet.Consultatii, searchCNPCON) > 0)
            {
                consultatiiTableAdapter.SelectCNPCON(familieMDataSet.Consultatii, searchCNPCON);
                
                MessageBox.Show("Am gasit consultatia pentru pacientul cu CNP: " + txtCautaCon.Text);
            } else if(consultatiiTableAdapter.FillBy(familieMDataSet.Consultatii, searchCNPCON) > 0)
            {
                consultatiiTableAdapter.FillBy(familieMDataSet.Consultatii, searchCNPCON);
                MessageBox.Show("Am gasit consultatia pentru pacientul cu Nume: " + txtCautaCon.Text);
            }
            else if ((consultatiiTableAdapter.SelectCNPCON(familieMDataSet.Consultatii, searchCNPCON) == 0 || consultatiiTableAdapter.FillBy(familieMDataSet.Consultatii, searchCNPCON) == 0) && txtCautaCon.TextLength > 0)
            {
                MessageBox.Show("Ati introdus CNP/Nume: " + txtCautaCon.Text + " care nu exista in baza de date");
                txtCautaCon.Focus();
                consultatiiTableAdapter.Fill(familieMDataSet.Consultatii);
            }else 
            if ((consultatiiTableAdapter.SelectCNPCON(familieMDataSet.Consultatii, searchCNPCON) == 0 || consultatiiTableAdapter.FillBy(familieMDataSet.Consultatii, searchCNPCON) == 0) && txtCautaCon.TextLength == 0)
            {
                MessageBox.Show("Introduceti un CNP/Nume");
                txtCautaCon.Focus();
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            consultatiiTableAdapter.Fill(familieMDataSet.Consultatii);
        }
    }
}
