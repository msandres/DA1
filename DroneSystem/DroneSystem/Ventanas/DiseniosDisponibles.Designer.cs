namespace DroneSystem.Ventanas
{
    partial class DiseniosDisponibles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiseniosDisponibles));
            this.dataGridDisDron = new System.Windows.Forms.DataGridView();
            this.NombreDisDron = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VersionDisDron = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridDisComp = new System.Windows.Forms.DataGridView();
            this.lbDisDron = new System.Windows.Forms.Label();
            this.lbDisComp = new System.Windows.Forms.Label();
            this.btnCerrarDisponibles = new System.Windows.Forms.Button();
            this.bntAgregarDisDron = new System.Windows.Forms.Button();
            this.btnAgregarDisComp = new System.Windows.Forms.Button();
            this.btnElimDisComp = new System.Windows.Forms.Button();
            this.btnElimDisDron = new System.Windows.Forms.Button();
            this.btnModifDisDron = new System.Windows.Forms.Button();
            this.btnModifDisComp = new System.Windows.Forms.Button();
            this.VersionDisComp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomDisComp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDisDron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDisComp)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridDisDron
            // 
            this.dataGridDisDron.AllowUserToAddRows = false;
            this.dataGridDisDron.AllowUserToDeleteRows = false;
            this.dataGridDisDron.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDisDron.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreDisDron,
            this.VersionDisDron});
            this.dataGridDisDron.Location = new System.Drawing.Point(12, 38);
            this.dataGridDisDron.Name = "dataGridDisDron";
            this.dataGridDisDron.Size = new System.Drawing.Size(240, 244);
            this.dataGridDisDron.TabIndex = 0;
            // 
            // NombreDisDron
            // 
            this.NombreDisDron.HeaderText = "Nombre";
            this.NombreDisDron.Name = "NombreDisDron";
            // 
            // VersionDisDron
            // 
            this.VersionDisDron.HeaderText = "Version";
            this.VersionDisDron.Name = "VersionDisDron";
            // 
            // dataGridDisComp
            // 
            this.dataGridDisComp.AllowUserToAddRows = false;
            this.dataGridDisComp.AllowUserToDeleteRows = false;
            this.dataGridDisComp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDisComp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VersionDisComp,
            this.NomDisComp});
            this.dataGridDisComp.Location = new System.Drawing.Point(345, 38);
            this.dataGridDisComp.Name = "dataGridDisComp";
            this.dataGridDisComp.Size = new System.Drawing.Size(240, 244);
            this.dataGridDisComp.TabIndex = 1;
            // 
            // lbDisDron
            // 
            this.lbDisDron.AutoSize = true;
            this.lbDisDron.Location = new System.Drawing.Point(9, 19);
            this.lbDisDron.Name = "lbDisDron";
            this.lbDisDron.Size = new System.Drawing.Size(97, 13);
            this.lbDisDron.TabIndex = 2;
            this.lbDisDron.Text = "Diseños de Drones";
            // 
            // lbDisComp
            // 
            this.lbDisComp.AutoSize = true;
            this.lbDisComp.Location = new System.Drawing.Point(342, 19);
            this.lbDisComp.Name = "lbDisComp";
            this.lbDisComp.Size = new System.Drawing.Size(128, 13);
            this.lbDisComp.TabIndex = 3;
            this.lbDisComp.Text = "Diseños de Componentes";
            // 
            // btnCerrarDisponibles
            // 
            this.btnCerrarDisponibles.Location = new System.Drawing.Point(258, 452);
            this.btnCerrarDisponibles.Name = "btnCerrarDisponibles";
            this.btnCerrarDisponibles.Size = new System.Drawing.Size(81, 23);
            this.btnCerrarDisponibles.TabIndex = 4;
            this.btnCerrarDisponibles.Text = "Cerrar";
            this.btnCerrarDisponibles.UseVisualStyleBackColor = true;
            this.btnCerrarDisponibles.Click += new System.EventHandler(this.btnCerrarDisponibles_Click);
            // 
            // bntAgregarDisDron
            // 
            this.bntAgregarDisDron.Location = new System.Drawing.Point(12, 311);
            this.bntAgregarDisDron.Name = "bntAgregarDisDron";
            this.bntAgregarDisDron.Size = new System.Drawing.Size(75, 23);
            this.bntAgregarDisDron.TabIndex = 5;
            this.bntAgregarDisDron.Text = "Agregar";
            this.bntAgregarDisDron.UseVisualStyleBackColor = true;
            this.bntAgregarDisDron.Click += new System.EventHandler(this.bntAgregarDisDron_Click);
            // 
            // btnAgregarDisComp
            // 
            this.btnAgregarDisComp.Location = new System.Drawing.Point(510, 311);
            this.btnAgregarDisComp.Name = "btnAgregarDisComp";
            this.btnAgregarDisComp.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarDisComp.TabIndex = 6;
            this.btnAgregarDisComp.Text = "Agregar";
            this.btnAgregarDisComp.UseVisualStyleBackColor = true;
            this.btnAgregarDisComp.Click += new System.EventHandler(this.btnAgregarDisComp_Click);
            // 
            // btnElimDisComp
            // 
            this.btnElimDisComp.Location = new System.Drawing.Point(509, 375);
            this.btnElimDisComp.Name = "btnElimDisComp";
            this.btnElimDisComp.Size = new System.Drawing.Size(75, 23);
            this.btnElimDisComp.TabIndex = 7;
            this.btnElimDisComp.Text = "Eliminar";
            this.btnElimDisComp.UseVisualStyleBackColor = true;
            this.btnElimDisComp.Click += new System.EventHandler(this.btnElimDisComp_Click);
            // 
            // btnElimDisDron
            // 
            this.btnElimDisDron.Location = new System.Drawing.Point(12, 374);
            this.btnElimDisDron.Name = "btnElimDisDron";
            this.btnElimDisDron.Size = new System.Drawing.Size(75, 23);
            this.btnElimDisDron.TabIndex = 8;
            this.btnElimDisDron.Text = "Eliminar";
            this.btnElimDisDron.UseVisualStyleBackColor = true;
            this.btnElimDisDron.Click += new System.EventHandler(this.btnElimDisDron_Click);
            // 
            // btnModifDisDron
            // 
            this.btnModifDisDron.Location = new System.Drawing.Point(12, 340);
            this.btnModifDisDron.Name = "btnModifDisDron";
            this.btnModifDisDron.Size = new System.Drawing.Size(75, 23);
            this.btnModifDisDron.TabIndex = 9;
            this.btnModifDisDron.Text = "Modificar";
            this.btnModifDisDron.UseVisualStyleBackColor = true;
            this.btnModifDisDron.Click += new System.EventHandler(this.btnModifDisDron_Click);
            // 
            // btnModifDisComp
            // 
            this.btnModifDisComp.Location = new System.Drawing.Point(510, 340);
            this.btnModifDisComp.Name = "btnModifDisComp";
            this.btnModifDisComp.Size = new System.Drawing.Size(75, 23);
            this.btnModifDisComp.TabIndex = 10;
            this.btnModifDisComp.Text = "Modificar";
            this.btnModifDisComp.UseVisualStyleBackColor = true;
            this.btnModifDisComp.Click += new System.EventHandler(this.btnModifDisComp_Click);
            // 
            // VersionDisComp
            // 
            this.VersionDisComp.HeaderText = "Marca";
            this.VersionDisComp.Name = "VersionDisComp";
            // 
            // NomDisComp
            // 
            this.NomDisComp.HeaderText = "Nombre Modelo";
            this.NomDisComp.Name = "NomDisComp";
            // 
            // DiseniosDisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 476);
            this.Controls.Add(this.btnModifDisComp);
            this.Controls.Add(this.btnModifDisDron);
            this.Controls.Add(this.btnElimDisDron);
            this.Controls.Add(this.btnElimDisComp);
            this.Controls.Add(this.btnAgregarDisComp);
            this.Controls.Add(this.bntAgregarDisDron);
            this.Controls.Add(this.btnCerrarDisponibles);
            this.Controls.Add(this.lbDisComp);
            this.Controls.Add(this.lbDisDron);
            this.Controls.Add(this.dataGridDisComp);
            this.Controls.Add(this.dataGridDisDron);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DiseniosDisponibles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diseños Disponibles";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDisDron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDisComp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridDisDron;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDisDron;
        private System.Windows.Forms.DataGridViewTextBoxColumn VersionDisDron;
        private System.Windows.Forms.DataGridView dataGridDisComp;
        private System.Windows.Forms.Label lbDisDron;
        private System.Windows.Forms.Label lbDisComp;
        private System.Windows.Forms.Button btnCerrarDisponibles;
        private System.Windows.Forms.Button bntAgregarDisDron;
        private System.Windows.Forms.Button btnAgregarDisComp;
        private System.Windows.Forms.Button btnElimDisComp;
        private System.Windows.Forms.Button btnElimDisDron;
        private System.Windows.Forms.Button btnModifDisDron;
        private System.Windows.Forms.Button btnModifDisComp;
        private System.Windows.Forms.DataGridViewTextBoxColumn VersionDisComp;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomDisComp;
    }
}