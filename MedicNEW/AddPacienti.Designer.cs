namespace MedicNEW
{
    partial class AddPacienti
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grBoxPacient = new System.Windows.Forms.GroupBox();
            this.numVarsta = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.dpickDataNasterii = new System.Windows.Forms.DateTimePicker();
            this.btnAddPacienti = new System.Windows.Forms.Button();
            this.dtpickDataInscrierii = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIstoricBoli = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCNP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorCNP = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableAdapterManager = new MedicNEW.FamilieMDataSetTableAdapters.TableAdapterManager();
            this.mPacientiTableAdapter = new MedicNEW.FamilieMDataSetTableAdapters.MPacientiTableAdapter();
            this.mPacientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.familieMDataSet = new MedicNEW.FamilieMDataSet();
            this.errorNume = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPrenume = new System.Windows.Forms.ErrorProvider(this.components);
            this.grBoxPacient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVarsta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCNP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mPacientiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familieMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrenume)).BeginInit();
            this.SuspendLayout();
            // 
            // grBoxPacient
            // 
            this.grBoxPacient.Controls.Add(this.numVarsta);
            this.grBoxPacient.Controls.Add(this.label8);
            this.grBoxPacient.Controls.Add(this.dpickDataNasterii);
            this.grBoxPacient.Controls.Add(this.btnAddPacienti);
            this.grBoxPacient.Controls.Add(this.dtpickDataInscrierii);
            this.grBoxPacient.Controls.Add(this.label7);
            this.grBoxPacient.Controls.Add(this.txtIstoricBoli);
            this.grBoxPacient.Controls.Add(this.label6);
            this.grBoxPacient.Controls.Add(this.txtAdresa);
            this.grBoxPacient.Controls.Add(this.label5);
            this.grBoxPacient.Controls.Add(this.label4);
            this.grBoxPacient.Controls.Add(this.txtPrenume);
            this.grBoxPacient.Controls.Add(this.label3);
            this.grBoxPacient.Controls.Add(this.txtNume);
            this.grBoxPacient.Controls.Add(this.label2);
            this.grBoxPacient.Controls.Add(this.txtCNP);
            this.grBoxPacient.Controls.Add(this.label1);
            this.grBoxPacient.Location = new System.Drawing.Point(165, 32);
            this.grBoxPacient.Name = "grBoxPacient";
            this.grBoxPacient.Size = new System.Drawing.Size(371, 597);
            this.grBoxPacient.TabIndex = 0;
            this.grBoxPacient.TabStop = false;
            this.grBoxPacient.Text = "Adaugare Pacient";
            // 
            // numVarsta
            // 
            this.numVarsta.Location = new System.Drawing.Point(131, 238);
            this.numVarsta.Name = "numVarsta";
            this.numVarsta.Size = new System.Drawing.Size(211, 30);
            this.numVarsta.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Varsta";
            // 
            // dpickDataNasterii
            // 
            this.dpickDataNasterii.CustomFormat = "dd.MM.yyyy";
            this.dpickDataNasterii.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dpickDataNasterii.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpickDataNasterii.Location = new System.Drawing.Point(131, 190);
            this.dpickDataNasterii.Name = "dpickDataNasterii";
            this.dpickDataNasterii.Size = new System.Drawing.Size(211, 28);
            this.dpickDataNasterii.TabIndex = 15;
            this.dpickDataNasterii.Value = new System.DateTime(2019, 12, 23, 13, 51, 21, 0);
            this.dpickDataNasterii.ValueChanged += new System.EventHandler(this.dpickDataNasterii_ValueChanged);
            // 
            // btnAddPacienti
            // 
            this.btnAddPacienti.Location = new System.Drawing.Point(10, 557);
            this.btnAddPacienti.Name = "btnAddPacienti";
            this.btnAddPacienti.Size = new System.Drawing.Size(355, 34);
            this.btnAddPacienti.TabIndex = 14;
            this.btnAddPacienti.Text = "Adauga";
            this.btnAddPacienti.UseVisualStyleBackColor = true;
            this.btnAddPacienti.Click += new System.EventHandler(this.btnAddPacienti_Click);
            // 
            // dtpickDataInscrierii
            // 
            this.dtpickDataInscrierii.CustomFormat = "dd.MM.yyyy";
            this.dtpickDataInscrierii.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpickDataInscrierii.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpickDataInscrierii.Location = new System.Drawing.Point(131, 508);
            this.dtpickDataInscrierii.Name = "dtpickDataInscrierii";
            this.dtpickDataInscrierii.Size = new System.Drawing.Size(211, 28);
            this.dtpickDataInscrierii.TabIndex = 13;
            this.dtpickDataInscrierii.ValueChanged += new System.EventHandler(this.dtpickDataInscrierii_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "DataNasterii";
            // 
            // txtIstoricBoli
            // 
            this.txtIstoricBoli.Location = new System.Drawing.Point(131, 408);
            this.txtIstoricBoli.Multiline = true;
            this.txtIstoricBoli.Name = "txtIstoricBoli";
            this.txtIstoricBoli.Size = new System.Drawing.Size(211, 83);
            this.txtIstoricBoli.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Istoric Boli";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(131, 291);
            this.txtAdresa.Multiline = true;
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(211, 101);
            this.txtAdresa.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Adresa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 512);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data Inscrierii";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(131, 139);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(211, 30);
            this.txtPrenume.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prenume";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(131, 85);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(211, 30);
            this.txtNume.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nume";
            // 
            // txtCNP
            // 
            this.txtCNP.Location = new System.Drawing.Point(131, 35);
            this.txtCNP.Name = "txtCNP";
            this.txtCNP.Size = new System.Drawing.Size(211, 30);
            this.txtCNP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "CNP";
            // 
            // errorCNP
            // 
            this.errorCNP.ContainerControl = this;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsultatiiTableAdapter = null;
            this.tableAdapterManager.MPacientiTableAdapter = this.mPacientiTableAdapter;
            this.tableAdapterManager.RaportStergereTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MedicNEW.FamilieMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mPacientiTableAdapter
            // 
            this.mPacientiTableAdapter.ClearBeforeFill = true;
            // 
            // mPacientiBindingSource
            // 
            this.mPacientiBindingSource.DataMember = "MPacienti";
            this.mPacientiBindingSource.DataSource = this.familieMDataSet;
            // 
            // familieMDataSet
            // 
            this.familieMDataSet.DataSetName = "FamilieMDataSet";
            this.familieMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // errorNume
            // 
            this.errorNume.ContainerControl = this;
            // 
            // errorPrenume
            // 
            this.errorPrenume.ContainerControl = this;
            // 
            // AddPacienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(694, 641);
            this.Controls.Add(this.grBoxPacient);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddPacienti";
            this.Text = "AddPacienti";
            this.grBoxPacient.ResumeLayout(false);
            this.grBoxPacient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVarsta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCNP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mPacientiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familieMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrenume)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grBoxPacient;
        private System.Windows.Forms.Button btnAddPacienti;
        private System.Windows.Forms.DateTimePicker dtpickDataInscrierii;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIstoricBoli;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCNP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dpickDataNasterii;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numVarsta;
        private System.Windows.Forms.ErrorProvider errorCNP;
        private FamilieMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private FamilieMDataSetTableAdapters.MPacientiTableAdapter mPacientiTableAdapter;
        private System.Windows.Forms.BindingSource mPacientiBindingSource;
        private FamilieMDataSet familieMDataSet;
        private System.Windows.Forms.ErrorProvider errorNume;
        private System.Windows.Forms.ErrorProvider errorPrenume;
    }
}