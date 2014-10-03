namespace DroneSystem.Ventanas
{
    partial class PlanesDisponibles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanesDisponibles));
            this.datagridPlanes = new System.Windows.Forms.DataGridView();
            this.nombrePlanes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbPlanesDisp = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridPlanes)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridPlanes
            // 
            this.datagridPlanes.AllowUserToAddRows = false;
            this.datagridPlanes.AllowUserToDeleteRows = false;
            this.datagridPlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridPlanes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombrePlanes});
            this.datagridPlanes.Location = new System.Drawing.Point(17, 57);
            this.datagridPlanes.Name = "datagridPlanes";
            this.datagridPlanes.Size = new System.Drawing.Size(247, 313);
            this.datagridPlanes.TabIndex = 0;
            // 
            // nombrePlanes
            // 
            this.nombrePlanes.HeaderText = "Nombre";
            this.nombrePlanes.Name = "nombrePlanes";
            // 
            // lbPlanesDisp
            // 
            this.lbPlanesDisp.AutoSize = true;
            this.lbPlanesDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlanesDisp.Location = new System.Drawing.Point(13, 34);
            this.lbPlanesDisp.Name = "lbPlanesDisp";
            this.lbPlanesDisp.Size = new System.Drawing.Size(161, 20);
            this.lbPlanesDisp.TabIndex = 1;
            this.lbPlanesDisp.Text = "Planes Disponibles";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(17, 376);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(98, 33);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar Plan";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(17, 437);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(98, 33);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar Plan";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(215, 437);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(98, 33);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // PlanesDisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 495);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lbPlanesDisp);
            this.Controls.Add(this.datagridPlanes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlanesDisponibles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Planes Disponibles";
            ((System.ComponentModel.ISupportInitialize)(this.datagridPlanes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridPlanes;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePlanes;
        private System.Windows.Forms.Label lbPlanesDisp;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCerrar;
    }
}