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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

        }
       
    private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'familieMDataSet.MPacienti' table. You can move, or remove it, as needed.
            this.mPacientiTableAdapter.Fill(this.familieMDataSet.MPacienti);
            // TODO: This line of code loads data into the 'familieMDataSet.Consultatii' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'familieMDataSet.MPacienti' table. You can move, or remove it, as needed.
            this.mPacientiTableAdapter.Fill(familieMDataSet.MPacienti);

            this.consultatiiTableAdapter.Fill(this.familieMDataSet.Consultatii);

         }


        private void addToolPacient_Click(object sender, EventArgs e)
        {
            AddPacienti adaugarePacienti= new AddPacienti();
           
            
            
            if (adaugarePacienti.ShowDialog() == DialogResult.OK)
            {
                
                
                mPacientiTableAdapter.Insert(adaugarePacienti.CNP,adaugarePacienti.Nume,adaugarePacienti.Prenume,adaugarePacienti.DataNasterii,adaugarePacienti.Varsta,adaugarePacienti.Adresa,adaugarePacienti.IstoricBoli,adaugarePacienti.DataInscrierii);
                mPacientiTableAdapter.Fill(this.familieMDataSet.MPacienti);
                

            }
        }

        private void removeToolPacient_Click(object sender, EventArgs e)
        {
            DeletePacienti delete = new DeletePacienti();
            //Daca este in baza de date, atunci o sa fie sters
            delete.CNPS = (string)((DataRowView)mPacientiBindingSource.Current)["CNP"];
            delete.NumeComplet = (string)((DataRowView)mPacientiBindingSource.Current)["Nume"] + " " + (string)((DataRowView)mPacientiBindingSource.Current)["Prenume"];



            if (delete.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("A fost sters cu succes");
                mPacientiTableAdapter.DeleteCNP(delete.CNPS);

                mPacientiTableAdapter.Fill(familieMDataSet.MPacienti);
                delete.Show();

            } else 
            {
                delete.Hide();
            }
        }

        private void showToolConsultatii_Click(object sender, EventArgs e)
        {
            Consultatii consultatii = new Consultatii();

            consultatii.CNPC = (string)((DataRowView)mPacientiBindingSource.Current)["CNP"];
            consultatii.NumeCompletC = (string)((DataRowView)mPacientiBindingSource.Current)["Nume"] + " " + (string)((DataRowView)mPacientiBindingSource.Current)["Prenume"];
            if (consultatii.ShowDialog() == DialogResult.OK)
            {
                 MessageBox.Show("Consultatia a fost adaugata cu succes");
                consultatii.Show();
            }
            
        }

       

       

        private void btnCauta_Click(object sender, EventArgs e)
        {
            string searchCNP = txtSearch.Text;
            if(mPacientiTableAdapter.SelectCNP(familieMDataSet.MPacienti, searchCNP)>0 )
            {
                mPacientiTableAdapter.SelectCNP(familieMDataSet.MPacienti, searchCNP);
                
                MessageBox.Show("A fost gasit pacientul cu CNP: " + txtSearch.Text);
            } else if (mPacientiTableAdapter.SelectNume(familieMDataSet.MPacienti, searchCNP) > 0)
            {
                mPacientiTableAdapter.SelectNume(familieMDataSet.MPacienti, searchCNP);
                MessageBox.Show("A fost gasit pacientul cu Nume: " + txtSearch.Text);
            }

            if((mPacientiTableAdapter.SelectCNP(familieMDataSet.MPacienti, searchCNP) == 0 || mPacientiTableAdapter.SelectNume(familieMDataSet.MPacienti, searchCNP) == 0) && txtSearch.TextLength>0)
            {
                MessageBox.Show("Ati introdus CNP/Nume: " +txtSearch.Text+ " care nu exista in baza de date");
                txtSearch.Focus();
                mPacientiTableAdapter.Fill(this.familieMDataSet.MPacienti);
            }
            else if((mPacientiTableAdapter.SelectCNP(familieMDataSet.MPacienti, searchCNP) == 0 || mPacientiTableAdapter.SelectNume(familieMDataSet.MPacienti, searchCNP) == 0) && txtSearch.TextLength==0)
            {
                MessageBox.Show("Introduceti CNP/Nume");
                txtSearch.Focus();
                mPacientiTableAdapter.Fill(this.familieMDataSet.MPacienti);
            }
            

        }

        private void homeTool_Click(object sender, EventArgs e)
        {
            mPacientiTableAdapter.Fill(this.familieMDataSet.MPacienti);
        }

        private void mPacientiBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.mPacientiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.familieMDataSet);

        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            MessageBox.Show("Ati fost deconectat");
            login.Show();
        }

        private void updatePacientTool_Click(object sender, EventArgs e)
        {
            
            UpdatePacienti updatePacienti = new UpdatePacienti();
            Consultatii consultatii = new Consultatii();
            //Daca este in baza de date, atunci o sa fie sters
            updatePacienti.CNPMP = (string)((DataRowView)mPacientiBindingSource.Current)["CNP"];
            updatePacienti.NumeMP = (string)((DataRowView)mPacientiBindingSource.Current)["Nume"];
            updatePacienti.PrenumeMP = (string)((DataRowView)mPacientiBindingSource.Current)["Prenume"];
            updatePacienti.DataNasteriiMP = Convert.ToDateTime(((DataRowView)mPacientiBindingSource.Current)["DataNasterii"]);
            updatePacienti.VarstaMP = (int)((DataRowView)mPacientiBindingSource.Current)["Varsta"];
            updatePacienti.AdresaMP = (string)((DataRowView)mPacientiBindingSource.Current)["Adresa"];
            updatePacienti.IstoricBoliMP = (string)((DataRowView)mPacientiBindingSource.Current)["IstoricBoli"];
            updatePacienti.DataInscrieriiMP = Convert.ToDateTime(((DataRowView)mPacientiBindingSource.Current)["DataInscrierii"]);



            if (updatePacienti.ShowDialog() == DialogResult.OK)
            {
                mPacientiTableAdapter.UpdateQuery(updatePacienti.CNPMP, updatePacienti.NumeMP, updatePacienti.PrenumeMP, updatePacienti.DataNasteriiMP, updatePacienti.VarstaMP, updatePacienti.AdresaMP, updatePacienti.IstoricBoliMP, updatePacienti.DataInscrieriiMP);
                consultatiiTableAdapter.UpdateQueryCons(updatePacienti.CNPMP, updatePacienti.NumeMP + " " + updatePacienti.PrenumeMP);
                raportStergereTableAdapter.UpdateQueryStergere(updatePacienti.CNPMP, updatePacienti.NumeMP + " " + updatePacienti.PrenumeMP);
                mPacientiTableAdapter.Fill(familieMDataSet.MPacienti);
            }
            else
            {
                updatePacienti.Hide();
            }
        }
    }
}
