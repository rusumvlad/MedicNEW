namespace MedicNEW
{
    partial class UpdatePacienti
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
            this.numVarstaMP = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.dpickDataNasteriiMP = new System.Windows.Forms.DateTimePicker();
            this.btnModficaPacienti = new System.Windows.Forms.Button();
            this.dtpickDataInscrieriiMP = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIstoricBoliMP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdresaMP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrenumeMP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumeMP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCNPMP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorPrenumeMP = new System.Windows.Forms.ErrorProvider(this.components);
            this.familieMDataSet = new MedicNEW.FamilieMDataSet();
            this.mPacientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mPacientiTableAdapter = new MedicNEW.FamilieMDataSetTableAdapters.MPacientiTableAdapter();
            this.tableAdapterManager = new MedicNEW.FamilieMDataSetTableAdapters.TableAdapterManager();
            this.errorNumeMP = new System.Windows.Forms.ErrorProvider(this.components);
            this.grBoxPacient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVarstaMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrenumeMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familieMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mPacientiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNumeMP)).BeginInit();
            this.SuspendLayout();
            // 
            // grBoxPacient
            // 
            this.grBoxPacient.Controls.Add(this.numVarstaMP);
            this.grBoxPacient.Controls.Add(this.label8);
            this.grBoxPacient.Controls.Add(this.dpickDataNasteriiMP);
            this.grBoxPacient.Controls.Add(this.btnModficaPacienti);
            this.grBoxPacient.Controls.Add(this.dtpickDataInscrieriiMP);
            this.grBoxPacient.Controls.Add(this.label7);
            this.grBoxPacient.Controls.Add(this.txtIstoricBoliMP);
            this.grBoxPacient.Controls.Add(this.label6);
            this.grBoxPacient.Controls.Add(this.txtAdresaMP);
            this.grBoxPacient.Controls.Add(this.label5);
            this.grBoxPacient.Controls.Add(this.label4);
            this.grBoxPacient.Controls.Add(this.txtPrenumeMP);
            this.grBoxPacient.Controls.Add(this.label3);
            this.grBoxPacient.Controls.Add(this.txtNumeMP);
            this.grBoxPacient.Controls.Add(this.label2);
            this.grBoxPacient.Controls.Add(this.txtCNPMP);
            this.grBoxPacient.Controls.Add(this.label1);
            this.grBoxPacient.Location = new System.Drawing.Point(153, 75);
            this.grBoxPacient.Name = "grBoxPacient";
            this.grBoxPacient.Size = new System.Drawing.Size(369, 633);
            this.grBoxPacient.TabIndex = 1;
            this.grBoxPacient.TabStop = false;
            this.grBoxPacient.Text = "Modifica Pacient";
            // 
            // numVarstaMP
            // 
            this.numVarstaMP.Location = new System.Drawing.Point(131, 238);
            this.numVarstaMP.Name = "numVarstaMP";
            this.numVarstaMP.Size = new System.Drawing.Size(211, 30);
            this.numVarstaMP.TabIndex = 1;
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
            // dpickDataNasteriiMP
            // 
            this.dpickDataNasteriiMP.CustomFormat = "dd.MM.yyyy";
            this.dpickDataNasteriiMP.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dpickDataNasteriiMP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpickDataNasteriiMP.Location = new System.Drawing.Point(131, 190);
            this.dpickDataNasteriiMP.Name = "dpickDataNasteriiMP";
            this.dpickDataNasteriiMP.Size = new System.Drawing.Size(211, 28);
            this.dpickDataNasteriiMP.TabIndex = 15;
            this.dpickDataNasteriiMP.Value = new System.DateTime(2019, 12, 23, 13, 51, 21, 0);
            // 
            // btnModficaPacienti
            // 
            this.btnModficaPacienti.Location = new System.Drawing.Point(10, 582);
            this.btnModficaPacienti.Name = "btnModficaPacienti";
            this.btnModficaPacienti.Size = new System.Drawing.Size(353, 34);
            this.btnModficaPacienti.TabIndex = 14;
            this.btnModficaPacienti.Text = "Modfica";
            this.btnModficaPacienti.UseVisualStyleBackColor = true;
            this.btnModficaPacienti.Click += new System.EventHandler(this.btnModficaPacienti_Click);
            // 
            // dtpickDataInscrieriiMP
            // 
            this.dtpickDataInscrieriiMP.CustomFormat = "dd.MM.yyyy";
            this.dtpickDataInscrieriiMP.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpickDataInscrieriiMP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpickDataInscrieriiMP.Location = new System.Drawing.Point(131, 533);
            this.dtpickDataInscrieriiMP.Name = "dtpickDataInscrieriiMP";
            this.dtpickDataInscrieriiMP.Size = new System.Drawing.Size(211, 28);
            this.dtpickDataInscrieriiMP.TabIndex = 13;
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
            // txtIstoricBoliMP
            // 
            this.txtIstoricBoliMP.Location = new System.Drawing.Point(131, 408);
            this.txtIstoricBoliMP.Multiline = true;
            this.txtIstoricBoliMP.Name = "txtIstoricBoliMP";
            this.txtIstoricBoliMP.Size = new System.Drawing.Size(211, 119);
            this.txtIstoricBoliMP.TabIndex = 11;
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
            // txtAdresaMP
            // 
            this.txtAdresaMP.Location = new System.Drawing.Point(131, 291);
            this.txtAdresaMP.Multiline = true;
            this.txtAdresaMP.Name = "txtAdresaMP";
            this.txtAdresaMP.Size = new System.Drawing.Size(211, 101);
            this.txtAdresaMP.TabIndex = 9;
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
            this.label4.Location = new System.Drawing.Point(6, 533);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data Inscrierii";
            // 
            // txtPrenumeMP
            // 
            this.txtPrenumeMP.Location = new System.Drawing.Point(131, 139);
            this.txtPrenumeMP.Name = "txtPrenumeMP";
            this.txtPrenumeMP.Size = new System.Drawing.Size(211, 30);
            this.txtPrenumeMP.TabIndex = 5;
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
            // txtNumeMP
            // 
            this.txtNumeMP.Location = new System.Drawing.Point(131, 85);
            this.txtNumeMP.Name = "txtNumeMP";
            this.txtNumeMP.Size = new System.Drawing.Size(211, 30);
            this.txtNumeMP.TabIndex = 3;
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
            // txtCNPMP
            // 
            this.txtCNPMP.Enabled = false;
            this.txtCNPMP.Location = new System.Drawing.Point(131, 35);
            this.txtCNPMP.Name = "txtCNPMP";
            this.txtCNPMP.Size = new System.Drawing.Size(211, 30);
            this.txtCNPMP.TabIndex = 1;
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
            // errorPrenumeMP
            // 
            this.errorPrenumeMP.ContainerControl = this;
            // 
            // familieMDataSet
            // 
            this.familieMDataSet.DataSetName = "FamilieMDataSet";
            this.familieMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsultatiiTableAdapter = null;
            this.tableAdapterManager.MPacientiTableAdapter = this.mPacientiTableAdapter;
            this.tableAdapterManager.RaportStergereTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MedicNEW.FamilieMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // errorNumeMP
            // 
            this.errorNumeMP.ContainerControl = this;
            // 
            // UpdatePacienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(693, 749);
            this.Controls.Add(this.grBoxPacient);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "UpdatePacienti";
            this.Text = "UpdatePacienti";
            this.grBoxPacient.ResumeLayout(false);
            this.grBoxPacient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVarstaMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrenumeMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familieMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mPacientiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNumeMP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grBoxPacient;
        private System.Windows.Forms.NumericUpDown numVarstaMP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dpickDataNasteriiMP;
        private System.Windows.Forms.Button btnModficaPacienti;
        private System.Windows.Forms.DateTimePicker dtpickDataInscrieriiMP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIstoricBoliMP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAdresaMP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrenumeMP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumeMP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCNPMP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorPrenumeMP;
        private FamilieMDataSet familieMDataSet;
        private System.Windows.Forms.BindingSource mPacientiBindingSource;
        private FamilieMDataSetTableAdapters.MPacientiTableAdapter mPacientiTableAdapter;
        private FamilieMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ErrorProvider errorNumeMP;
    }
}