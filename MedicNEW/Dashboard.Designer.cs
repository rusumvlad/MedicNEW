namespace MedicNEW
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.Meniu = new System.Windows.Forms.MenuStrip();
            this.homeTool = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolPacient = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolPacient = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolConsultatii = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePacientTool = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblListaPacienti = new System.Windows.Forms.Label();
            this.btnCauta = new System.Windows.Forms.Button();
            this.mPacientiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mPacientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.familieMDataSet = new MedicNEW.FamilieMDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.mPacientiTableAdapter = new MedicNEW.FamilieMDataSetTableAdapters.MPacientiTableAdapter();
            this.tableAdapterManager = new MedicNEW.FamilieMDataSetTableAdapters.TableAdapterManager();
            this.consultatiiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultatiiTableAdapter = new MedicNEW.FamilieMDataSetTableAdapters.ConsultatiiTableAdapter();
            this.raportStergereTableAdapter = new MedicNEW.FamilieMDataSetTableAdapters.RaportStergereTableAdapter();
            this.raportStergereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Meniu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mPacientiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mPacientiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familieMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultatiiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raportStergereBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Meniu
            // 
            this.Meniu.BackColor = System.Drawing.Color.DodgerBlue;
            this.Meniu.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Meniu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeTool,
            this.addToolPacient,
            this.removeToolPacient,
            this.showToolConsultatii,
            this.updatePacientTool});
            this.Meniu.Location = new System.Drawing.Point(0, 0);
            this.Meniu.Name = "Meniu";
            this.Meniu.Size = new System.Drawing.Size(1338, 31);
            this.Meniu.TabIndex = 0;
            this.Meniu.Text = "MENIU";
            // 
            // homeTool
            // 
            this.homeTool.ForeColor = System.Drawing.Color.MidnightBlue;
            this.homeTool.Name = "homeTool";
            this.homeTool.Size = new System.Drawing.Size(140, 27);
            this.homeTool.Text = "Afisare Pacienti";
            this.homeTool.Click += new System.EventHandler(this.homeTool_Click);
            // 
            // addToolPacient
            // 
            this.addToolPacient.ForeColor = System.Drawing.Color.MidnightBlue;
            this.addToolPacient.Name = "addToolPacient";
            this.addToolPacient.Size = new System.Drawing.Size(132, 27);
            this.addToolPacient.Text = "Adauga Pacient";
            this.addToolPacient.Click += new System.EventHandler(this.addToolPacient_Click);
            // 
            // removeToolPacient
            // 
            this.removeToolPacient.ForeColor = System.Drawing.Color.MidnightBlue;
            this.removeToolPacient.Name = "removeToolPacient";
            this.removeToolPacient.Size = new System.Drawing.Size(129, 27);
            this.removeToolPacient.Text = "Sterge Pacient";
            this.removeToolPacient.Click += new System.EventHandler(this.removeToolPacient_Click);
            // 
            // showToolConsultatii
            // 
            this.showToolConsultatii.ForeColor = System.Drawing.Color.MidnightBlue;
            this.showToolConsultatii.Name = "showToolConsultatii";
            this.showToolConsultatii.Size = new System.Drawing.Size(100, 27);
            this.showToolConsultatii.Text = "Consultatii";
            this.showToolConsultatii.Click += new System.EventHandler(this.showToolConsultatii_Click);
            // 
            // updatePacientTool
            // 
            this.updatePacientTool.ForeColor = System.Drawing.Color.MidnightBlue;
            this.updatePacientTool.Name = "updatePacientTool";
            this.updatePacientTool.Size = new System.Drawing.Size(254, 27);
            this.updatePacientTool.Text = "Modificarea datelor pacientilor";
            this.updatePacientTool.Click += new System.EventHandler(this.updatePacientTool_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSearch.Location = new System.Drawing.Point(420, 67);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(152, 23);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Cautare CNP/Nume";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(578, 64);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(577, 30);
            this.txtSearch.TabIndex = 2;
            // 
            // lblListaPacienti
            // 
            this.lblListaPacienti.AutoSize = true;
            this.lblListaPacienti.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblListaPacienti.Location = new System.Drawing.Point(53, 59);
            this.lblListaPacienti.Name = "lblListaPacienti";
            this.lblListaPacienti.Size = new System.Drawing.Size(219, 38);
            this.lblListaPacienti.TabIndex = 5;
            this.lblListaPacienti.Text = "Lista Pacientilor";
            // 
            // btnCauta
            // 
            this.btnCauta.Location = new System.Drawing.Point(1161, 64);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(151, 30);
            this.btnCauta.TabIndex = 7;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // mPacientiDataGridView
            // 
            this.mPacientiDataGridView.AutoGenerateColumns = false;
            this.mPacientiDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.mPacientiDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mPacientiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mPacientiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.mPacientiDataGridView.DataSource = this.mPacientiBindingSource;
            this.mPacientiDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.mPacientiDataGridView.Location = new System.Drawing.Point(60, 131);
            this.mPacientiDataGridView.Name = "mPacientiDataGridView";
            this.mPacientiDataGridView.Size = new System.Drawing.Size(1252, 404);
            this.mPacientiDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CNP";
            this.dataGridViewTextBoxColumn1.HeaderText = "CNP";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nume";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nume";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Prenume";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prenume";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DataNasterii";
            this.dataGridViewTextBoxColumn4.HeaderText = "DataNasterii";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Varsta";
            this.dataGridViewTextBoxColumn5.HeaderText = "Varsta";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 75;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Adresa";
            this.dataGridViewTextBoxColumn6.HeaderText = "Adresa";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 250;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "IstoricBoli";
            this.dataGridViewTextBoxColumn7.HeaderText = "IstoricBoli";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 250;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DataInscrierii";
            this.dataGridViewTextBoxColumn8.HeaderText = "DataInscrierii";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(1221, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "LogOut";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // consultatiiBindingSource
            // 
            this.consultatiiBindingSource.DataMember = "Consultatii";
            this.consultatiiBindingSource.DataSource = this.familieMDataSet;
            // 
            // consultatiiTableAdapter
            // 
            this.consultatiiTableAdapter.ClearBeforeFill = true;
            // 
            // raportStergereTableAdapter
            // 
            this.raportStergereTableAdapter.ClearBeforeFill = true;
            // 
            // raportStergereBindingSource
            // 
            this.raportStergereBindingSource.DataMember = "RaportStergere";
            this.raportStergereBindingSource.DataSource = this.familieMDataSet;
            // 
            // Dashboard
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1338, 581);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mPacientiDataGridView);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.lblListaPacienti);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.Meniu);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Meniu;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.Meniu.ResumeLayout(false);
            this.Meniu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mPacientiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mPacientiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familieMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultatiiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raportStergereBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Meniu;
        private System.Windows.Forms.ToolStripMenuItem homeTool;
        private System.Windows.Forms.ToolStripMenuItem addToolPacient;
        private System.Windows.Forms.ToolStripMenuItem removeToolPacient;
        private System.Windows.Forms.ToolStripMenuItem showToolConsultatii;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblListaPacienti;
        private System.Windows.Forms.Button btnCauta;
        private FamilieMDataSet familieMDataSet;
        private System.Windows.Forms.BindingSource mPacientiBindingSource;
        private FamilieMDataSetTableAdapters.MPacientiTableAdapter mPacientiTableAdapter;
        private FamilieMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView mPacientiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource consultatiiBindingSource;
        private FamilieMDataSetTableAdapters.ConsultatiiTableAdapter consultatiiTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem updatePacientTool;
        private FamilieMDataSetTableAdapters.RaportStergereTableAdapter raportStergereTableAdapter;
        private System.Windows.Forms.BindingSource raportStergereBindingSource;
    }
}