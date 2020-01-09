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
    public partial class UpdatePacienti : Form
    {
        public UpdatePacienti()
        {
            InitializeComponent();
        }

        #region Initializarea datelor ce trebuie modificate din baza de date
        public string CNPMP
        {
            get
            {
                return txtCNPMP.Text;

            }
            set
            {
                txtCNPMP.Text = value;
            }
        }

        public DateTime DataInscrieriiMP
        {

            get
            {
                return Convert.ToDateTime(dtpickDataInscrieriiMP.Text);
            }
            set
            {
                dtpickDataInscrieriiMP.Text = Convert.ToString(value);
            }


        }

        public DateTime DataNasteriiMP
        {

            get
            {
                return Convert.ToDateTime(dpickDataNasteriiMP.Text);
            }
            set
            {
                dpickDataNasteriiMP.Text = Convert.ToString(value);
            }

        }

        public string NumeMP
        {
            get
            {
                return txtNumeMP.Text;
            }


            set
            {
                txtNumeMP.Text = value;
            }
        }

        public string PrenumeMP
        {
            get
            {
                return txtPrenumeMP.Text;
            }

            set
            {
                txtPrenumeMP.Text = value;
            }
        }

        public string AdresaMP
        {
            get
            {
                return txtAdresaMP.Text;
            }

            set
            {
                txtAdresaMP.Text = value;
            }
        }

        public string IstoricBoliMP
        {
            get
            {
                return txtIstoricBoliMP.Text;
            }

            set
            {
                txtIstoricBoliMP.Text = value;
            }
        }

        public int VarstaMP
        {
            get
            {
                return Decimal.ToInt32(numVarstaMP.Value);
            }

            set
            {
                numVarstaMP.Value = value;
            }
        }


        #endregion

        private void btnModficaPacienti_Click(object sender, EventArgs e)
        {
            
           
            if (txtPrenumeMP.TextLength == 0)
            {
                
                errorPrenumeMP.SetError(txtPrenumeMP, "Introduceti prenumele pacientului");

            }
            if (txtNumeMP.TextLength == 0)
            {
                
                errorNumeMP.SetError(txtNumeMP, "Introduceti numele pacientului");
            }
            if (txtPrenumeMP.TextLength > 0)
            {
                errorPrenumeMP.Clear();
            }
            if (txtNumeMP.TextLength > 0)
            {
                errorNumeMP.Clear();
            }
            if (txtCNPMP.TextLength == 13 && mPacientiTableAdapter.SelectCNP(familieMDataSet.MPacienti, CNPMP) > 0 && txtNumeMP.TextLength > 0 && txtPrenumeMP.TextLength > 0)
            {
                DialogResult = DialogResult.OK;
                MessageBox.Show("Pacientul a fost modificat cu succes");
                

            }
            //Daca mai exista atunci afisez un mesaj de eroare
            else if (txtCNPMP.TextLength == 13 && mPacientiTableAdapter.SelectCNP(familieMDataSet.MPacienti, CNPMP) == 0 && txtNumeMP.TextLength > 0 && txtPrenumeMP.TextLength > 0)
            {
                MessageBox.Show("Pacientul nu exista in baza de date");
            }
        }
    }
}
