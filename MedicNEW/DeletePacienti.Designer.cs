namespace MedicNEW
{
    partial class DeletePacienti
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
            this.btnStergere = new System.Windows.Forms.Button();
            this.dpDataCurenta = new System.Windows.Forms.DateTimePicker();
            this.txtMotive = new System.Windows.Forms.TextBox();
            this.lblMotive = new System.Windows.Forms.Label();
            this.lblDataCurenta = new System.Windows.Forms.Label();
            this.btnAddPacienti = new System.Windows.Forms.Button();
            this.dtpickDataInscrierii = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumeComplet = new System.Windows.Forms.TextBox();
            this.lblNumeComplet = new System.Windows.Forms.Label();
            this.txtCNPS = new System.Windows.Forms.TextBox();
            this.lblCNP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorCNPS = new System.Windows.Forms.ErrorProvider(this.components);
            this.familieMDataSet = new MedicNEW.FamilieMDataSet();
            this.raportStergereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raportStergereTableAdapter = new MedicNEW.FamilieMDataSetTableAdapters.RaportStergereTableAdapter();
            this.tableAdapterManager = new MedicNEW.FamilieMDataSetTableAdapters.TableAdapterManager();
            this.mPacientiTableAdapter = new MedicNEW.FamilieMDataSetTableAdapters.MPacientiTableAdapter();
            this.raportStergereDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mPacientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultatiiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultatiiTableAdapter = new MedicNEW.FamilieMDataSetTableAdapters.ConsultatiiTableAdapter();
            this.grBoxPacient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorCNPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familieMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raportStergereBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raportStergereDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mPacientiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultatiiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grBoxPacient
            // 
            this.grBoxPacient.Controls.Add(this.btnStergere);
            this.grBoxPacient.Controls.Add(this.dpDataCurenta);
            this.grBoxPacient.Controls.Add(this.txtMotive);
            this.grBoxPacient.Controls.Add(this.lblMotive);
            this.grBoxPacient.Controls.Add(this.lblDataCurenta);
            this.grBoxPacient.Controls.Add(this.btnAddPacienti);
            this.grBoxPacient.Controls.Add(this.dtpickDataInscrierii);
            this.grBoxPacient.Controls.Add(this.label4);
            this.grBoxPacient.Controls.Add(this.txtNumeComplet);
            this.grBoxPacient.Controls.Add(this.lblNumeComplet);
            this.grBoxPacient.Controls.Add(this.txtCNPS);
            this.grBoxPacient.Controls.Add(this.lblCNP);
            this.grBoxPacient.Location = new System.Drawing.Point(53, 74);
            this.grBoxPacient.Name = "grBoxPacient";
            this.grBoxPacient.Size = new System.Drawing.Size(357, 361);
            this.grBoxPacient.TabIndex = 2;
            this.grBoxPacient.TabStop = false;
            this.grBoxPacient.Text = "Stergere Pacient";
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(6, 307);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(336, 34);
            this.btnStergere.TabIndex = 17;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // dpDataCurenta
            // 
            this.dpDataCurenta.CustomFormat = "dd.MM.yyyy";
            this.dpDataCurenta.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dpDataCurenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDataCurenta.Location = new System.Drawing.Point(131, 150);
            this.dpDataCurenta.Name = "dpDataCurenta";
            this.dpDataCurenta.Size = new System.Drawing.Size(211, 28);
            this.dpDataCurenta.TabIndex = 16;
            // 
            // txtMotive
            // 
            this.txtMotive.Location = new System.Drawing.Point(131, 194);
            this.txtMotive.Multiline = true;
            this.txtMotive.Name = "txtMotive";
            this.txtMotive.Size = new System.Drawing.Size(211, 83);
            this.txtMotive.TabIndex = 11;
            // 
            // lblMotive
            // 
            this.lblMotive.AutoSize = true;
            this.lblMotive.Location = new System.Drawing.Point(22, 197);
            this.lblMotive.Name = "lblMotive";
            this.lblMotive.Size = new System.Drawing.Size(61, 23);
            this.lblMotive.TabIndex = 10;
            this.lblMotive.Text = "Motive";
            // 
            // lblDataCurenta
            // 
            this.lblDataCurenta.AutoSize = true;
            this.lblDataCurenta.Location = new System.Drawing.Point(6, 154);
            this.lblDataCurenta.Name = "lblDataCurenta";
            this.lblDataCurenta.Size = new System.Drawing.Size(107, 23);
            this.lblDataCurenta.TabIndex = 15;
            this.lblDataCurenta.Text = "Data Curenta";
            // 
            // btnAddPacienti
            // 
            this.btnAddPacienti.Location = new System.Drawing.Point(6, 557);
            this.btnAddPacienti.Name = "btnAddPacienti";
            this.btnAddPacienti.Size = new System.Drawing.Size(336, 34);
            this.btnAddPacienti.TabIndex = 14;
            this.btnAddPacienti.Text = "Adauga";
            this.btnAddPacienti.UseVisualStyleBackColor = true;
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
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 512);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data Inscrierii";
            // 
            // txtNumeComplet
            // 
            this.txtNumeComplet.Enabled = false;
            this.txtNumeComplet.Location = new System.Drawing.Point(131, 85);
            this.txtNumeComplet.Name = "txtNumeComplet";
            this.txtNumeComplet.Size = new System.Drawing.Size(211, 30);
            this.txtNumeComplet.TabIndex = 3;
            // 
            // lblNumeComplet
            // 
            this.lblNumeComplet.AutoSize = true;
            this.lblNumeComplet.Location = new System.Drawing.Point(6, 88);
            this.lblNumeComplet.Name = "lblNumeComplet";
            this.lblNumeComplet.Size = new System.Drawing.Size(113, 23);
            this.lblNumeComplet.TabIndex = 2;
            this.lblNumeComplet.Text = "Nume Complet";
            // 
            // txtCNPS
            // 
            this.txtCNPS.Enabled = false;
            this.txtCNPS.Location = new System.Drawing.Point(131, 35);
            this.txtCNPS.Name = "txtCNPS";
            this.txtCNPS.Size = new System.Drawing.Size(211, 30);
            this.txtCNPS.TabIndex = 1;
            // 
            // lblCNP
            // 
            this.lblCNP.AutoSize = true;
            this.lblCNP.Location = new System.Drawing.Point(22, 38);
            this.lblCNP.Name = "lblCNP";
            this.lblCNP.Size = new System.Drawing.Size(41, 23);
            this.lblCNP.TabIndex = 0;
            this.lblCNP.Text = "CNP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(469, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tabelul pacientilor stersi";
            // 
            // errorCNPS
            // 
            this.errorCNPS.ContainerControl = this;
            // 
            // familieMDataSet
            // 
            this.familieMDataSet.DataSetName = "FamilieMDataSet";
            this.familieMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // raportStergereBindingSource
            // 
            this.raportStergereBindingSource.DataMember = "RaportStergere";
            this.raportStergereBindingSource.DataSource = this.familieMDataSet;
            // 
            // raportStergereTableAdapter
            // 
            this.raportStergereTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsultatiiTableAdapter = null;
            this.tableAdapterManager.MPacientiTableAdapter = this.mPacientiTableAdapter;
            this.tableAdapterManager.RaportStergereTableAdapter = this.raportStergereTableAdapter;
            this.tableAdapterManager.UpdateOrder = MedicNEW.FamilieMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mPacientiTableAdapter
            // 
            this.mPacientiTableAdapter.ClearBeforeFill = true;
            // 
            // raportStergereDataGridView
            // 
            this.raportStergereDataGridView.AutoGenerateColumns = false;
            this.raportStergereDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.raportStergereDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.raportStergereDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.raportStergereDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.raportStergereDataGridView.DataSource = this.raportStergereBindingSource;
            this.raportStergereDataGridView.Enabled = false;
            this.raportStergereDataGridView.Location = new System.Drawing.Point(474, 74);
            this.raportStergereDataGridView.Name = "raportStergereDataGridView";
            this.raportStergereDataGridView.Size = new System.Drawing.Size(773, 361);
            this.raportStergereDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CNP";
            this.dataGridViewTextBoxColumn2.HeaderText = "CNP";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NumeComplet";
            this.dataGridViewTextBoxColumn3.HeaderText = "NumeComplet";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DataCurenta";
            this.dataGridViewTextBoxColumn4.HeaderText = "DataCurenta";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Motive";
            this.dataGridViewTextBoxColumn5.HeaderText = "Motive";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // consultatiiBindingSource
            // 
            this.consultatiiBindingSource.DataMember = "Consultatii";
            this.consultatiiBindingSource.DataSource = this.familieMDataSet;
            // 
            // consultatiiTableAdapter
            // 
            this.consultatiiTableAdapter.ClearBeforeFill = true;
            // 
            // DeletePacienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1288, 526);
            this.Controls.Add(this.raportStergereDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grBoxPacient);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DeletePacienti";
            this.Text = "DeletePacienti";
            this.Load += new System.EventHandler(this.DeletePacienti_Load);
            this.grBoxPacient.ResumeLayout(false);
            this.grBoxPacient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorCNPS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familieMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raportStergereBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raportStergereDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mPacientiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultatiiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grBoxPacient;
        private System.Windows.Forms.Button btnAddPacienti;
        private System.Windows.Forms.DateTimePicker dtpickDataInscrierii;
        private System.Windows.Forms.TextBox txtMotive;
        private System.Windows.Forms.Label lblMotive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumeComplet;
        private System.Windows.Forms.Label lblNumeComplet;
        private System.Windows.Forms.TextBox txtCNPS;
        private System.Windows.Forms.Label lblCNP;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.DateTimePicker dpDataCurenta;
        private System.Windows.Forms.Label lblDataCurenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorCNPS;
        private System.Windows.Forms.BindingSource raportStergereBindingSource;
        private FamilieMDataSet familieMDataSet;
        private FamilieMDataSetTableAdapters.RaportStergereTableAdapter raportStergereTableAdapter;
        private FamilieMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView raportStergereDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private FamilieMDataSetTableAdapters.MPacientiTableAdapter mPacientiTableAdapter;
        private System.Windows.Forms.BindingSource mPacientiBindingSource;
        private System.Windows.Forms.BindingSource consultatiiBindingSource;
        private FamilieMDataSetTableAdapters.ConsultatiiTableAdapter consultatiiTableAdapter;
    }
}