namespace MedicNEW
{
    partial class Consultatii
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
            this.btnAdaugaCon = new System.Windows.Forms.Button();
            this.dpDataConsultatiei = new System.Windows.Forms.DateTimePicker();
            this.txtReteta = new System.Windows.Forms.TextBox();
            this.lblMotive = new System.Windows.Forms.Label();
            this.lblDataCurenta = new System.Windows.Forms.Label();
            this.btnAddPacienti = new System.Windows.Forms.Button();
            this.dtpickDataInscrierii = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumeCompletC = new System.Windows.Forms.TextBox();
            this.lblNumeComplet = new System.Windows.Forms.Label();
            this.txtCNPC = new System.Windows.Forms.TextBox();
            this.lblCNP = new System.Windows.Forms.Label();
            this.familieMDataSet = new MedicNEW.FamilieMDataSet();
            this.consultatiiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultatiiTableAdapter = new MedicNEW.FamilieMDataSetTableAdapters.ConsultatiiTableAdapter();
            this.tableAdapterManager = new MedicNEW.FamilieMDataSetTableAdapters.TableAdapterManager();
            this.consultatiiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.errorCNPC = new System.Windows.Forms.ErrorProvider(this.components);
            this.mPacientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mPacientiTableAdapter = new MedicNEW.FamilieMDataSetTableAdapters.MPacientiTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCautaCon = new System.Windows.Forms.TextBox();
            this.btnCautaCon = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.grBoxPacient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.familieMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultatiiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultatiiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCNPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mPacientiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grBoxPacient
            // 
            this.grBoxPacient.Controls.Add(this.btnAdaugaCon);
            this.grBoxPacient.Controls.Add(this.dpDataConsultatiei);
            this.grBoxPacient.Controls.Add(this.txtReteta);
            this.grBoxPacient.Controls.Add(this.lblMotive);
            this.grBoxPacient.Controls.Add(this.lblDataCurenta);
            this.grBoxPacient.Controls.Add(this.btnAddPacienti);
            this.grBoxPacient.Controls.Add(this.dtpickDataInscrierii);
            this.grBoxPacient.Controls.Add(this.label4);
            this.grBoxPacient.Controls.Add(this.txtNumeCompletC);
            this.grBoxPacient.Controls.Add(this.lblNumeComplet);
            this.grBoxPacient.Controls.Add(this.txtCNPC);
            this.grBoxPacient.Controls.Add(this.lblCNP);
            this.grBoxPacient.Location = new System.Drawing.Point(41, 110);
            this.grBoxPacient.Name = "grBoxPacient";
            this.grBoxPacient.Size = new System.Drawing.Size(387, 347);
            this.grBoxPacient.TabIndex = 3;
            this.grBoxPacient.TabStop = false;
            this.grBoxPacient.Text = "Adauga Consultatie";
            // 
            // btnAdaugaCon
            // 
            this.btnAdaugaCon.Location = new System.Drawing.Point(18, 294);
            this.btnAdaugaCon.Name = "btnAdaugaCon";
            this.btnAdaugaCon.Size = new System.Drawing.Size(336, 34);
            this.btnAdaugaCon.TabIndex = 17;
            this.btnAdaugaCon.Text = "Adauga";
            this.btnAdaugaCon.UseVisualStyleBackColor = true;
            this.btnAdaugaCon.Click += new System.EventHandler(this.btnAdaugaCon_Click);
            // 
            // dpDataConsultatiei
            // 
            this.dpDataConsultatiei.CustomFormat = "dd.MM.yyyy";
            this.dpDataConsultatiei.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dpDataConsultatiei.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDataConsultatiei.Location = new System.Drawing.Point(143, 150);
            this.dpDataConsultatiei.Name = "dpDataConsultatiei";
            this.dpDataConsultatiei.Size = new System.Drawing.Size(211, 28);
            this.dpDataConsultatiei.TabIndex = 16;
            // 
            // txtReteta
            // 
            this.txtReteta.Location = new System.Drawing.Point(143, 194);
            this.txtReteta.Multiline = true;
            this.txtReteta.Name = "txtReteta";
            this.txtReteta.Size = new System.Drawing.Size(211, 83);
            this.txtReteta.TabIndex = 11;
            // 
            // lblMotive
            // 
            this.lblMotive.AutoSize = true;
            this.lblMotive.Location = new System.Drawing.Point(22, 197);
            this.lblMotive.Name = "lblMotive";
            this.lblMotive.Size = new System.Drawing.Size(59, 23);
            this.lblMotive.TabIndex = 10;
            this.lblMotive.Text = "Reteta";
            // 
            // lblDataCurenta
            // 
            this.lblDataCurenta.AutoSize = true;
            this.lblDataCurenta.Location = new System.Drawing.Point(2, 154);
            this.lblDataCurenta.Name = "lblDataCurenta";
            this.lblDataCurenta.Size = new System.Drawing.Size(136, 23);
            this.lblDataCurenta.TabIndex = 15;
            this.lblDataCurenta.Text = "Data Consultatiei";
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
            // txtNumeCompletC
            // 
            this.txtNumeCompletC.Enabled = false;
            this.txtNumeCompletC.Location = new System.Drawing.Point(143, 88);
            this.txtNumeCompletC.Name = "txtNumeCompletC";
            this.txtNumeCompletC.Size = new System.Drawing.Size(211, 30);
            this.txtNumeCompletC.TabIndex = 3;
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
            // txtCNPC
            // 
            this.txtCNPC.Enabled = false;
            this.txtCNPC.Location = new System.Drawing.Point(143, 35);
            this.txtCNPC.Name = "txtCNPC";
            this.txtCNPC.Size = new System.Drawing.Size(211, 30);
            this.txtCNPC.TabIndex = 1;
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
            // familieMDataSet
            // 
            this.familieMDataSet.DataSetName = "FamilieMDataSet";
            this.familieMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsultatiiTableAdapter = this.consultatiiTableAdapter;
            this.tableAdapterManager.MPacientiTableAdapter = null;
            this.tableAdapterManager.RaportStergereTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MedicNEW.FamilieMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // consultatiiDataGridView
            // 
            this.consultatiiDataGridView.AutoGenerateColumns = false;
            this.consultatiiDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.consultatiiDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consultatiiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consultatiiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.consultatiiDataGridView.DataSource = this.consultatiiBindingSource;
            this.consultatiiDataGridView.Enabled = false;
            this.consultatiiDataGridView.Location = new System.Drawing.Point(450, 145);
            this.consultatiiDataGridView.Name = "consultatiiDataGridView";
            this.consultatiiDataGridView.Size = new System.Drawing.Size(858, 336);
            this.consultatiiDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nr";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nr";
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DataConsultatie";
            this.dataGridViewTextBoxColumn4.HeaderText = "DataConsultatie";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Reteta";
            this.dataGridViewTextBoxColumn5.HeaderText = "Reteta";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 250;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(445, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tabelul consultatilor";
            // 
            // errorCNPC
            // 
            this.errorCNPC.ContainerControl = this;
            // 
            // mPacientiBindingSource
            // 
            this.mPacientiBindingSource.DataMember = "MPacienti";
            this.mPacientiBindingSource.DataSource = this.familieMDataSet;
            // 
            // mPacientiTableAdapter
            // 
            this.mPacientiTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(680, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Consultatie cautata(CNP)";
            // 
            // txtCautaCon
            // 
            this.txtCautaCon.Location = new System.Drawing.Point(879, 111);
            this.txtCautaCon.Name = "txtCautaCon";
            this.txtCautaCon.Size = new System.Drawing.Size(254, 30);
            this.txtCautaCon.TabIndex = 7;
            // 
            // btnCautaCon
            // 
            this.btnCautaCon.Location = new System.Drawing.Point(1139, 112);
            this.btnCautaCon.Name = "btnCautaCon";
            this.btnCautaCon.Size = new System.Drawing.Size(153, 29);
            this.btnCautaCon.TabIndex = 8;
            this.btnCautaCon.Text = "Cauta";
            this.btnCautaCon.UseVisualStyleBackColor = true;
            this.btnCautaCon.Click += new System.EventHandler(this.btnCautaCon_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1139, 487);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(153, 34);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Reimprospatare ";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Consultatii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1315, 749);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnCautaCon);
            this.Controls.Add(this.txtCautaCon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.consultatiiDataGridView);
            this.Controls.Add(this.grBoxPacient);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Consultatii";
            this.Text = "Consultatii";
            this.Load += new System.EventHandler(this.Consultatii_Load);
            this.grBoxPacient.ResumeLayout(false);
            this.grBoxPacient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.familieMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultatiiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultatiiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCNPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mPacientiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grBoxPacient;
        private System.Windows.Forms.Button btnAdaugaCon;
        private System.Windows.Forms.DateTimePicker dpDataConsultatiei;
        private System.Windows.Forms.TextBox txtReteta;
        private System.Windows.Forms.Label lblMotive;
        private System.Windows.Forms.Label lblDataCurenta;
        private System.Windows.Forms.Button btnAddPacienti;
        private System.Windows.Forms.DateTimePicker dtpickDataInscrierii;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumeCompletC;
        private System.Windows.Forms.Label lblNumeComplet;
        private System.Windows.Forms.TextBox txtCNPC;
        private System.Windows.Forms.Label lblCNP;
        private FamilieMDataSet familieMDataSet;
        private System.Windows.Forms.BindingSource consultatiiBindingSource;
        private FamilieMDataSetTableAdapters.ConsultatiiTableAdapter consultatiiTableAdapter;
        private FamilieMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView consultatiiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorCNPC;
        private System.Windows.Forms.BindingSource mPacientiBindingSource;
        private FamilieMDataSetTableAdapters.MPacientiTableAdapter mPacientiTableAdapter;
        private System.Windows.Forms.Button btnCautaCon;
        private System.Windows.Forms.TextBox txtCautaCon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRefresh;
    }
}