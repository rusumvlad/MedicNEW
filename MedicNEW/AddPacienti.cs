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
    public partial class AddPacienti : Form
    {
        #region Initializarea datelor ce trebuie introduse in baza de date
        public string CNP
            {
                get
                {
                    return txtCNP.Text;
                    
                }
                set
                {
                   txtCNP.Text = value;
                }
            }

            public DateTime DataInscrierii
            {
            
                get
                {
                    return Convert.ToDateTime(dtpickDataInscrierii.Text);
                }
                set
                {
                   dtpickDataInscrierii.Text=Convert.ToString(value);
                }


            }

            public DateTime DataNasterii
            {
                
                get
                {
                    return Convert.ToDateTime(dpickDataNasterii.Text);
                }
                set
                {
                    dpickDataNasterii.Text = Convert.ToString(value);
                }

            }

            public string Nume
            {
                get
                {
                    return txtNume.Text;
                }


                set
                {
                    txtNume.Text = value;
                }
            }

            public string Prenume
            {
                get
                {
                   return txtPrenume.Text;
                }

                set
                {
                   txtPrenume.Text = value;
                }
            }

            public string Adresa
            {
                get
                {
                    return txtAdresa.Text;
                }

                set
                {
                    txtAdresa.Text = value;
                }
            }

            public string IstoricBoli
            {
                get
                {
                    return txtIstoricBoli.Text;
                }

                set
                {
                    txtIstoricBoli.Text = value;
                }
            }

            public int Varsta
            {
                get
                {
                    return Decimal.ToInt32(numVarsta.Value);
                }

                set
                {
                    numVarsta.Value = value;
                }
            }
        

        #endregion


        public AddPacienti()
        {
            InitializeComponent();
            
        }





        private void btnAddPacienti_Click(object sender, EventArgs e)
        {
            //Am verificat daca CNP este de 13 caractere, daca nu este atunci o sa apara o eroare
            if (txtCNP.TextLength != 13)
            {
                txtCNP.Focus();
                errorCNP.SetError(txtCNP, "CNP trebuie sa contina 13 numere!");
                
            } 
            else if (txtNume.TextLength == 0)
            {
                errorCNP.Clear();
                errorNume.SetError(txtNume, "Introduceti numele pacientului");
            }
            else if (txtPrenume.TextLength == 0)
            {
                errorNume.Clear();
                errorPrenume.SetError(txtPrenume, "Introduceti prenumele pacientului");
                
            }
            else if (txtPrenume.TextLength > 0)
            {
                errorPrenume.Clear();
            }

            //Daca CNP este validat, ii setat un Nume si un Prenume, verific daca mai exista CNP, daca nu exista atunci il inserez
            if (txtCNP.TextLength == 13 && mPacientiTableAdapter.SelectCNP(familieMDataSet.MPacienti, CNP) == 0 && txtNume.TextLength>0 && txtPrenume.TextLength > 0) 
            {
                DialogResult = DialogResult.OK;
                MessageBox.Show("Pacientul a fost adaugat cu succes");
                errorCNP.SetError(txtCNP, null);
                
            } 
            //Daca mai exista atunci afisez un mesaj de eroare
            else if(txtCNP.TextLength == 13 && mPacientiTableAdapter.SelectCNP(familieMDataSet.MPacienti, CNP) > 0 && txtNume.TextLength > 0 && txtPrenume.TextLength > 0)
            {
                MessageBox.Show("Pacientul deja exista in baza de date");
            }
           
            
        }

        private void dpickDataNasterii_ValueChanged(object sender, EventArgs e)
        {
            
            dpickDataNasterii.Format = DateTimePickerFormat.Custom;
            dpickDataNasterii.CustomFormat = "dd.MM.yyyy";
        }

        private void dtpickDataInscrierii_ValueChanged(object sender, EventArgs e)
        {
            dtpickDataInscrierii.Format = DateTimePickerFormat.Custom;
            dtpickDataInscrierii.CustomFormat = "dd.MM.yyyy";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
