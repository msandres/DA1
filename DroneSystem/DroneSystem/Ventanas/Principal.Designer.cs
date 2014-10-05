namespace DroneSystem
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.reloj = new System.Windows.Forms.Label();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.lbComonentesDisp = new System.Windows.Forms.Label();
            this.lbDronesDisp = new System.Windows.Forms.Label();
            this.dataGridComponentes = new System.Windows.Forms.DataGridView();
            this.dataGridDrones = new System.Windows.Forms.DataGridView();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MArchivoCerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelosDisponiblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.diseñosDisponiblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejecutarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planesDeVueloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.simuladoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MAyudaAcerdaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModeloCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridComponentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDrones)).BeginInit();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // reloj
            // 
            this.reloj.AutoSize = true;
            this.reloj.Location = new System.Drawing.Point(732, 36);
            this.reloj.Name = "reloj";
            this.reloj.Size = new System.Drawing.Size(31, 13);
            this.reloj.TabIndex = 1;
            this.reloj.Text = "Reloj";
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.lbComonentesDisp);
            this.panelPrincipal.Controls.Add(this.lbDronesDisp);
            this.panelPrincipal.Controls.Add(this.dataGridComponentes);
            this.panelPrincipal.Controls.Add(this.dataGridDrones);
            this.panelPrincipal.Controls.Add(this.reloj);
            this.panelPrincipal.Controls.Add(this.Menu);
            this.panelPrincipal.Location = new System.Drawing.Point(2, 2);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(782, 468);
            this.panelPrincipal.TabIndex = 2;
            // 
            // lbComonentesDisp
            // 
            this.lbComonentesDisp.AutoSize = true;
            this.lbComonentesDisp.Location = new System.Drawing.Point(329, 54);
            this.lbComonentesDisp.Name = "lbComonentesDisp";
            this.lbComonentesDisp.Size = new System.Drawing.Size(129, 13);
            this.lbComonentesDisp.TabIndex = 6;
            this.lbComonentesDisp.Text = "Componentes Disponibles";
            // 
            // lbDronesDisp
            // 
            this.lbDronesDisp.AutoSize = true;
            this.lbDronesDisp.Location = new System.Drawing.Point(11, 54);
            this.lbDronesDisp.Name = "lbDronesDisp";
            this.lbDronesDisp.Size = new System.Drawing.Size(98, 13);
            this.lbDronesDisp.TabIndex = 5;
            this.lbDronesDisp.Text = "Drones Disponibles";
            // 
            // dataGridComponentes
            // 
            this.dataGridComponentes.AllowUserToAddRows = false;
            this.dataGridComponentes.AllowUserToDeleteRows = false;
            this.dataGridComponentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridComponentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Marca,
            this.ModeloCom});
            this.dataGridComponentes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridComponentes.Enabled = false;
            this.dataGridComponentes.Location = new System.Drawing.Point(332, 73);
            this.dataGridComponentes.Name = "dataGridComponentes";
            this.dataGridComponentes.Size = new System.Drawing.Size(385, 297);
            this.dataGridComponentes.TabIndex = 4;
            // 
            // dataGridDrones
            // 
            this.dataGridDrones.AllowUserToAddRows = false;
            this.dataGridDrones.AllowUserToDeleteRows = false;
            this.dataGridDrones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDrones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modelo});
            this.dataGridDrones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridDrones.Enabled = false;
            this.dataGridDrones.Location = new System.Drawing.Point(10, 73);
            this.dataGridDrones.Name = "dataGridDrones";
            this.dataGridDrones.Size = new System.Drawing.Size(259, 297);
            this.dataGridDrones.TabIndex = 3;
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.verToolStripMenuItem,
            this.ejecutarToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(782, 24);
            this.Menu.TabIndex = 2;
            this.Menu.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarDatosToolStripMenuItem,
            this.toolStripSeparator1,
            this.MArchivoCerrar});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.toolStripMenuItem1.Text = "Archivo";
            // 
            // cargarDatosToolStripMenuItem
            // 
            this.cargarDatosToolStripMenuItem.Name = "cargarDatosToolStripMenuItem";
            this.cargarDatosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cargarDatosToolStripMenuItem.Text = "Cargar Datos";
            this.cargarDatosToolStripMenuItem.Click += new System.EventHandler(this.cargarDatosToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // MArchivoCerrar
            // 
            this.MArchivoCerrar.Name = "MArchivoCerrar";
            this.MArchivoCerrar.Size = new System.Drawing.Size(152, 22);
            this.MArchivoCerrar.Text = "Cerrar";
            this.MArchivoCerrar.Click += new System.EventHandler(this.MArchivoCerrar_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modelosDisponiblesToolStripMenuItem,
            this.toolStripSeparator3,
            this.diseñosDisponiblesToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // modelosDisponiblesToolStripMenuItem
            // 
            this.modelosDisponiblesToolStripMenuItem.Name = "modelosDisponiblesToolStripMenuItem";
            this.modelosDisponiblesToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.modelosDisponiblesToolStripMenuItem.Text = "Modelos";
            this.modelosDisponiblesToolStripMenuItem.Click += new System.EventHandler(this.modelosDisponiblesToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(199, 6);
            // 
            // diseñosDisponiblesToolStripMenuItem
            // 
            this.diseñosDisponiblesToolStripMenuItem.Name = "diseñosDisponiblesToolStripMenuItem";
            this.diseñosDisponiblesToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.diseñosDisponiblesToolStripMenuItem.Text = "Diseños y Componentes";
            this.diseñosDisponiblesToolStripMenuItem.Click += new System.EventHandler(this.diseñosDisponiblesToolStripMenuItem_Click);
            // 
            // ejecutarToolStripMenuItem
            // 
            this.ejecutarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.planesDeVueloToolStripMenuItem,
            this.toolStripSeparator4,
            this.simuladoToolStripMenuItem,
            this.realToolStripMenuItem});
            this.ejecutarToolStripMenuItem.Name = "ejecutarToolStripMenuItem";
            this.ejecutarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.ejecutarToolStripMenuItem.Text = "Vuelo";
            // 
            // planesDeVueloToolStripMenuItem
            // 
            this.planesDeVueloToolStripMenuItem.Name = "planesDeVueloToolStripMenuItem";
            this.planesDeVueloToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.planesDeVueloToolStripMenuItem.Text = "Planes de Vuelo";
            this.planesDeVueloToolStripMenuItem.Click += new System.EventHandler(this.planesDeVueloToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(154, 6);
            // 
            // simuladoToolStripMenuItem
            // 
            this.simuladoToolStripMenuItem.Name = "simuladoToolStripMenuItem";
            this.simuladoToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.simuladoToolStripMenuItem.Text = "Simulado";
            // 
            // realToolStripMenuItem
            // 
            this.realToolStripMenuItem.Name = "realToolStripMenuItem";
            this.realToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.realToolStripMenuItem.Text = "Real";
            this.realToolStripMenuItem.Click += new System.EventHandler(this.realToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MAyudaAcerdaDe});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // MAyudaAcerdaDe
            // 
            this.MAyudaAcerdaDe.Image = ((System.Drawing.Image)(resources.GetObject("MAyudaAcerdaDe.Image")));
            this.MAyudaAcerdaDe.Name = "MAyudaAcerdaDe";
            this.MAyudaAcerdaDe.Size = new System.Drawing.Size(193, 22);
            this.MAyudaAcerdaDe.Text = "Acerca de DronSystem";
            this.MAyudaAcerdaDe.Click += new System.EventHandler(this.MAyudaAcerdaDe_Click);
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            // 
            // ModeloCom
            // 
            this.ModeloCom.HeaderText = "Modelo";
            this.ModeloCom.Name = "ModeloCom";
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(787, 569);
            this.Controls.Add(this.panelPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DroneSystem";
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridComponentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDrones)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label reloj;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cargarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MArchivoCerrar;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelosDisponiblesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem diseñosDisponiblesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MAyudaAcerdaDe;
        private System.Windows.Forms.Label lbComonentesDisp;
        private System.Windows.Forms.Label lbDronesDisp;
        private System.Windows.Forms.DataGridView dataGridComponentes;
        private System.Windows.Forms.DataGridView dataGridDrones;
        private System.Windows.Forms.ToolStripMenuItem ejecutarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simuladoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planesDeVueloToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModeloCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
    }
}

