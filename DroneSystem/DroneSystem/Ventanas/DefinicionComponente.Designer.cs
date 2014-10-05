namespace DroneSystem.Ventanas
{
    partial class DefinicionComponente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefinicionComponente));
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cBTipos = new System.Windows.Forms.ComboBox();
            this.txtBCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.dataGridDefinicion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDefinicion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 242);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(85, 39);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cBTipos
            // 
            this.cBTipos.FormattingEnabled = true;
            this.cBTipos.Location = new System.Drawing.Point(12, 51);
            this.cBTipos.Name = "cBTipos";
            this.cBTipos.Size = new System.Drawing.Size(121, 21);
            this.cBTipos.TabIndex = 7;
            this.cBTipos.SelectedIndexChanged += new System.EventHandler(this.cBTipos_SelectedIndexChanged);
            // 
            // txtBCantidad
            // 
            this.txtBCantidad.Location = new System.Drawing.Point(12, 130);
            this.txtBCantidad.Name = "txtBCantidad";
            this.txtBCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtBCantidad.TabIndex = 8;
            this.txtBCantidad.TextChanged += new System.EventHandler(this.txtBCantidad_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Seleccione Tipo";
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Location = new System.Drawing.Point(9, 107);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(49, 13);
            this.lbCantidad.TabIndex = 10;
            this.lbCantidad.Text = "Cantidad";
            // 
            // dataGridDefinicion
            // 
            this.dataGridDefinicion.AllowUserToAddRows = false;
            this.dataGridDefinicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDefinicion.Location = new System.Drawing.Point(164, 51);
            this.dataGridDefinicion.Name = "dataGridDefinicion";
            this.dataGridDefinicion.Size = new System.Drawing.Size(663, 150);
            this.dataGridDefinicion.TabIndex = 11;
            this.dataGridDefinicion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDefinicion_CellClick);
            this.dataGridDefinicion.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridDefinicion_DataError);
            // 
            // DefinicionComponente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 298);
            this.Controls.Add(this.dataGridDefinicion);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBCantidad);
            this.Controls.Add(this.cBTipos);
            this.Controls.Add(this.btnAgregar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DefinicionComponente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Definicion Componente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDefinicion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cBTipos;
        private System.Windows.Forms.TextBox txtBCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.DataGridView dataGridDefinicion;
    }
}