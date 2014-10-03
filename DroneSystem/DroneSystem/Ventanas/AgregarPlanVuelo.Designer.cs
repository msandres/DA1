namespace DroneSystem.Ventanas
{
    partial class AgregarPlanVuelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarPlanVuelo));
            this.datagridCoordenadas = new System.Windows.Forms.DataGridView();
            this.Punto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoordenadaX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoordenadaY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoordenadaZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCoodenadas = new System.Windows.Forms.Label();
            this.lbVelocidades = new System.Windows.Forms.Label();
            this.lbVelX = new System.Windows.Forms.Label();
            this.txtbVelX = new System.Windows.Forms.TextBox();
            this.lbUnidX = new System.Windows.Forms.Label();
            this.lbUnidY = new System.Windows.Forms.Label();
            this.txtbVelY = new System.Windows.Forms.TextBox();
            this.lbVelY = new System.Windows.Forms.Label();
            this.lbUnidZ = new System.Windows.Forms.Label();
            this.txtbVelZ = new System.Windows.Forms.TextBox();
            this.lbVelZ = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtBNombrePlan = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridCoordenadas)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridCoordenadas
            // 
            this.datagridCoordenadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridCoordenadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Punto,
            this.CoordenadaX,
            this.CoordenadaY,
            this.CoordenadaZ});
            this.datagridCoordenadas.Location = new System.Drawing.Point(15, 44);
            this.datagridCoordenadas.Name = "datagridCoordenadas";
            this.datagridCoordenadas.Size = new System.Drawing.Size(442, 322);
            this.datagridCoordenadas.TabIndex = 0;
            this.datagridCoordenadas.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ValidarCeldaDataGrid);
            this.datagridCoordenadas.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.ValidarNuevoRegistro);
            // 
            // Punto
            // 
            this.Punto.HeaderText = "Punto";
            this.Punto.Name = "Punto";
            this.Punto.ReadOnly = true;
            // 
            // CoordenadaX
            // 
            this.CoordenadaX.HeaderText = "Coordenada X";
            this.CoordenadaX.Name = "CoordenadaX";
            // 
            // CoordenadaY
            // 
            this.CoordenadaY.HeaderText = "Coordenada Y";
            this.CoordenadaY.Name = "CoordenadaY";
            // 
            // CoordenadaZ
            // 
            this.CoordenadaZ.HeaderText = "Coordenada Z";
            this.CoordenadaZ.Name = "CoordenadaZ";
            // 
            // lblCoodenadas
            // 
            this.lblCoodenadas.AutoSize = true;
            this.lblCoodenadas.ForeColor = System.Drawing.Color.Blue;
            this.lblCoodenadas.Location = new System.Drawing.Point(12, 28);
            this.lblCoodenadas.Name = "lblCoodenadas";
            this.lblCoodenadas.Size = new System.Drawing.Size(106, 13);
            this.lblCoodenadas.TabIndex = 1;
            this.lblCoodenadas.Text = "Puntos del Recorrido";
            // 
            // lbVelocidades
            // 
            this.lbVelocidades.AutoSize = true;
            this.lbVelocidades.ForeColor = System.Drawing.Color.Blue;
            this.lbVelocidades.Location = new System.Drawing.Point(511, 28);
            this.lbVelocidades.Name = "lbVelocidades";
            this.lbVelocidades.Size = new System.Drawing.Size(149, 13);
            this.lbVelocidades.TabIndex = 2;
            this.lbVelocidades.Text = "Velocidades por Coordenadas";
            // 
            // lbVelX
            // 
            this.lbVelX.AutoSize = true;
            this.lbVelX.ForeColor = System.Drawing.Color.Blue;
            this.lbVelX.Location = new System.Drawing.Point(511, 56);
            this.lbVelX.Name = "lbVelX";
            this.lbVelX.Size = new System.Drawing.Size(85, 13);
            this.lbVelX.TabIndex = 3;
            this.lbVelX.Text = "Velociadad en X";
            // 
            // txtbVelX
            // 
            this.txtbVelX.Location = new System.Drawing.Point(514, 72);
            this.txtbVelX.Name = "txtbVelX";
            this.txtbVelX.Size = new System.Drawing.Size(82, 20);
            this.txtbVelX.TabIndex = 4;
            this.txtbVelX.TextChanged += new System.EventHandler(this.ValidarVelocidad);
            // 
            // lbUnidX
            // 
            this.lbUnidX.AutoSize = true;
            this.lbUnidX.Location = new System.Drawing.Point(602, 75);
            this.lbUnidX.Name = "lbUnidX";
            this.lbUnidX.Size = new System.Drawing.Size(25, 13);
            this.lbUnidX.TabIndex = 5;
            this.lbUnidX.Text = "m/s";
            // 
            // lbUnidY
            // 
            this.lbUnidY.AutoSize = true;
            this.lbUnidY.Location = new System.Drawing.Point(602, 128);
            this.lbUnidY.Name = "lbUnidY";
            this.lbUnidY.Size = new System.Drawing.Size(25, 13);
            this.lbUnidY.TabIndex = 8;
            this.lbUnidY.Text = "m/s";
            // 
            // txtbVelY
            // 
            this.txtbVelY.Location = new System.Drawing.Point(514, 125);
            this.txtbVelY.Name = "txtbVelY";
            this.txtbVelY.Size = new System.Drawing.Size(82, 20);
            this.txtbVelY.TabIndex = 7;
            this.txtbVelY.TextChanged += new System.EventHandler(this.ValidarVelocidad);
            // 
            // lbVelY
            // 
            this.lbVelY.AutoSize = true;
            this.lbVelY.ForeColor = System.Drawing.Color.Blue;
            this.lbVelY.Location = new System.Drawing.Point(511, 109);
            this.lbVelY.Name = "lbVelY";
            this.lbVelY.Size = new System.Drawing.Size(85, 13);
            this.lbVelY.TabIndex = 6;
            this.lbVelY.Text = "Velociadad en Y";
            // 
            // lbUnidZ
            // 
            this.lbUnidZ.AutoSize = true;
            this.lbUnidZ.Location = new System.Drawing.Point(602, 182);
            this.lbUnidZ.Name = "lbUnidZ";
            this.lbUnidZ.Size = new System.Drawing.Size(25, 13);
            this.lbUnidZ.TabIndex = 11;
            this.lbUnidZ.Text = "m/s";
            // 
            // txtbVelZ
            // 
            this.txtbVelZ.Location = new System.Drawing.Point(514, 179);
            this.txtbVelZ.Name = "txtbVelZ";
            this.txtbVelZ.Size = new System.Drawing.Size(82, 20);
            this.txtbVelZ.TabIndex = 10;
            this.txtbVelZ.TextChanged += new System.EventHandler(this.ValidarVelocidad);
            // 
            // lbVelZ
            // 
            this.lbVelZ.AutoSize = true;
            this.lbVelZ.ForeColor = System.Drawing.Color.Blue;
            this.lbVelZ.Location = new System.Drawing.Point(511, 163);
            this.lbVelZ.Name = "lbVelZ";
            this.lbVelZ.Size = new System.Drawing.Size(85, 13);
            this.lbVelZ.TabIndex = 9;
            this.lbVelZ.Text = "Velociadad en Z";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(521, 371);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 37);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtBNombrePlan
            // 
            this.txtBNombrePlan.Location = new System.Drawing.Point(514, 274);
            this.txtBNombrePlan.Name = "txtBNombrePlan";
            this.txtBNombrePlan.Size = new System.Drawing.Size(146, 20);
            this.txtBNombrePlan.TabIndex = 14;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.ForeColor = System.Drawing.Color.Blue;
            this.lbNombre.Location = new System.Drawing.Point(511, 258);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(83, 13);
            this.lbNombre.TabIndex = 13;
            this.lbNombre.Text = "Nombre de Plan";
            // 
            // AgregarPlanVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 426);
            this.Controls.Add(this.txtBNombrePlan);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lbUnidZ);
            this.Controls.Add(this.txtbVelZ);
            this.Controls.Add(this.lbVelZ);
            this.Controls.Add(this.lbUnidY);
            this.Controls.Add(this.txtbVelY);
            this.Controls.Add(this.lbVelY);
            this.Controls.Add(this.lbUnidX);
            this.Controls.Add(this.txtbVelX);
            this.Controls.Add(this.lbVelX);
            this.Controls.Add(this.lbVelocidades);
            this.Controls.Add(this.lblCoodenadas);
            this.Controls.Add(this.datagridCoordenadas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarPlanVuelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Plan de Vuelo";
            ((System.ComponentModel.ISupportInitialize)(this.datagridCoordenadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridCoordenadas;
        private System.Windows.Forms.Label lblCoodenadas;
        private System.Windows.Forms.Label lbVelocidades;
        private System.Windows.Forms.Label lbVelX;
        private System.Windows.Forms.TextBox txtbVelX;
        private System.Windows.Forms.Label lbUnidX;
        private System.Windows.Forms.Label lbUnidY;
        private System.Windows.Forms.TextBox txtbVelY;
        private System.Windows.Forms.Label lbVelY;
        private System.Windows.Forms.Label lbUnidZ;
        private System.Windows.Forms.TextBox txtbVelZ;
        private System.Windows.Forms.Label lbVelZ;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Punto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoordenadaX;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoordenadaY;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoordenadaZ;
        private System.Windows.Forms.TextBox txtBNombrePlan;
        private System.Windows.Forms.Label lbNombre;
    }
}