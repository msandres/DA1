namespace DroneSystem.Ventanas
{
    partial class DefinicionDisDron
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefinicionDisDron));
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridDefinicion = new System.Windows.Forms.DataGridView();
            this.lbComp = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbColor = new System.Windows.Forms.Label();
            this.lblControlRemoto = new System.Windows.Forms.Label();
            this.txtBControl = new System.Windows.Forms.TextBox();
            this.txtBColor = new System.Windows.Forms.TextBox();
            this.txtBNombre = new System.Windows.Forms.TextBox();
            this.txtBPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDefinicion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(190, 388);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(85, 39);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dataGridDefinicion
            // 
            this.dataGridDefinicion.AllowUserToAddRows = false;
            this.dataGridDefinicion.AllowUserToDeleteRows = false;
            this.dataGridDefinicion.AllowUserToResizeColumns = false;
            this.dataGridDefinicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDefinicion.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridDefinicion.Location = new System.Drawing.Point(12, 188);
            this.dataGridDefinicion.Name = "dataGridDefinicion";
            this.dataGridDefinicion.Size = new System.Drawing.Size(444, 152);
            this.dataGridDefinicion.TabIndex = 11;
            // 
            // lbComp
            // 
            this.lbComp.AutoSize = true;
            this.lbComp.Location = new System.Drawing.Point(13, 175);
            this.lbComp.Name = "lbComp";
            this.lbComp.Size = new System.Drawing.Size(122, 13);
            this.lbComp.TabIndex = 12;
            this.lbComp.Text = "Seleccione Componetes";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(16, 33);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(70, 13);
            this.lbNombre.TabIndex = 13;
            this.lbNombre.Text = "Nombre Dron";
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Location = new System.Drawing.Point(16, 60);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(31, 13);
            this.lbColor.TabIndex = 14;
            this.lbColor.Text = "Color";
            // 
            // lblControlRemoto
            // 
            this.lblControlRemoto.AutoSize = true;
            this.lblControlRemoto.Location = new System.Drawing.Point(16, 89);
            this.lblControlRemoto.Name = "lblControlRemoto";
            this.lblControlRemoto.Size = new System.Drawing.Size(113, 13);
            this.lblControlRemoto.TabIndex = 15;
            this.lblControlRemoto.Text = "Marca Control Remoto";
            // 
            // txtBControl
            // 
            this.txtBControl.Location = new System.Drawing.Point(147, 82);
            this.txtBControl.Name = "txtBControl";
            this.txtBControl.Size = new System.Drawing.Size(100, 20);
            this.txtBControl.TabIndex = 16;
            // 
            // txtBColor
            // 
            this.txtBColor.Location = new System.Drawing.Point(147, 57);
            this.txtBColor.Name = "txtBColor";
            this.txtBColor.Size = new System.Drawing.Size(100, 20);
            this.txtBColor.TabIndex = 17;
            // 
            // txtBNombre
            // 
            this.txtBNombre.Location = new System.Drawing.Point(147, 30);
            this.txtBNombre.Name = "txtBNombre";
            this.txtBNombre.Size = new System.Drawing.Size(100, 20);
            this.txtBNombre.TabIndex = 18;
            // 
            // txtBPrecio
            // 
            this.txtBPrecio.Location = new System.Drawing.Point(147, 108);
            this.txtBPrecio.Name = "txtBPrecio";
            this.txtBPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtBPrecio.TabIndex = 20;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(16, 115);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 19;
            this.lblPrecio.Text = "Precio";
            // 
            // DefinicionDisDron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 439);
            this.Controls.Add(this.txtBPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtBNombre);
            this.Controls.Add(this.txtBColor);
            this.Controls.Add(this.txtBControl);
            this.Controls.Add(this.lblControlRemoto);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbComp);
            this.Controls.Add(this.dataGridDefinicion);
            this.Controls.Add(this.btnAgregar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DefinicionDisDron";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Definicion Diseño Dron";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDefinicion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dataGridDefinicion;
        private System.Windows.Forms.Label lbComp;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.Label lblControlRemoto;
        private System.Windows.Forms.TextBox txtBControl;
        private System.Windows.Forms.TextBox txtBColor;
        private System.Windows.Forms.TextBox txtBNombre;
        private System.Windows.Forms.TextBox txtBPrecio;
        private System.Windows.Forms.Label lblPrecio;
    }
}