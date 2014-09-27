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
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ediciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MArchivoCerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MAyudaAcerdaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.componentesDisponblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dronesDisponiblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.diseñosDisponiblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dronesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.componentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelosDisponiblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dronesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.componentesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.droneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.componenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.ediciónToolStripMenuItem,
            this.verToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(760, 24);
            this.Menu.TabIndex = 0;
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
            // 
            // ediciónToolStripMenuItem
            // 
            this.ediciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrarToolStripMenuItem});
            this.ediciónToolStripMenuItem.Name = "ediciónToolStripMenuItem";
            this.ediciónToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ediciónToolStripMenuItem.Text = "Edición";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dronesDisponiblesToolStripMenuItem,
            this.componentesDisponblesToolStripMenuItem,
            this.toolStripSeparator2,
            this.modelosDisponiblesToolStripMenuItem,
            this.toolStripSeparator3,
            this.diseñosDisponiblesToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // MArchivoCerrar
            // 
            this.MArchivoCerrar.Name = "MArchivoCerrar";
            this.MArchivoCerrar.Size = new System.Drawing.Size(152, 22);
            this.MArchivoCerrar.Text = "Cerrar";
            this.MArchivoCerrar.Click += new System.EventHandler(this.MArchivoCerrar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
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
            // componentesDisponblesToolStripMenuItem
            // 
            this.componentesDisponblesToolStripMenuItem.Name = "componentesDisponblesToolStripMenuItem";
            this.componentesDisponblesToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.componentesDisponblesToolStripMenuItem.Text = "Componentes Disponbles";
            // 
            // dronesDisponiblesToolStripMenuItem
            // 
            this.dronesDisponiblesToolStripMenuItem.Name = "dronesDisponiblesToolStripMenuItem";
            this.dronesDisponiblesToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.dronesDisponiblesToolStripMenuItem.Text = "Drones Disponibles";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(207, 6);
            // 
            // diseñosDisponiblesToolStripMenuItem
            // 
            this.diseñosDisponiblesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dronesToolStripMenuItem,
            this.componentesToolStripMenuItem});
            this.diseñosDisponiblesToolStripMenuItem.Name = "diseñosDisponiblesToolStripMenuItem";
            this.diseñosDisponiblesToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.diseñosDisponiblesToolStripMenuItem.Text = "Diseños Disponibles";
            // 
            // dronesToolStripMenuItem
            // 
            this.dronesToolStripMenuItem.Name = "dronesToolStripMenuItem";
            this.dronesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dronesToolStripMenuItem.Text = "Drones";
            // 
            // componentesToolStripMenuItem
            // 
            this.componentesToolStripMenuItem.Name = "componentesToolStripMenuItem";
            this.componentesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.componentesToolStripMenuItem.Text = "Componentes";
            // 
            // modelosDisponiblesToolStripMenuItem
            // 
            this.modelosDisponiblesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dronesToolStripMenuItem1,
            this.componentesToolStripMenuItem1});
            this.modelosDisponiblesToolStripMenuItem.Name = "modelosDisponiblesToolStripMenuItem";
            this.modelosDisponiblesToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.modelosDisponiblesToolStripMenuItem.Text = "Modelos Disponibles";
            // 
            // dronesToolStripMenuItem1
            // 
            this.dronesToolStripMenuItem1.Name = "dronesToolStripMenuItem1";
            this.dronesToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.dronesToolStripMenuItem1.Text = "Drones";
            // 
            // componentesToolStripMenuItem1
            // 
            this.componentesToolStripMenuItem1.Name = "componentesToolStripMenuItem1";
            this.componentesToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.componentesToolStripMenuItem1.Text = "Componentes";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(207, 6);
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.droneToolStripMenuItem,
            this.componenteToolStripMenuItem});
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.borrarToolStripMenuItem.Text = "Borrar";
            // 
            // droneToolStripMenuItem
            // 
            this.droneToolStripMenuItem.Name = "droneToolStripMenuItem";
            this.droneToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.droneToolStripMenuItem.Text = "Drone";
            // 
            // componenteToolStripMenuItem
            // 
            this.componenteToolStripMenuItem.Name = "componenteToolStripMenuItem";
            this.componenteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.componenteToolStripMenuItem.Text = "Componente";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(760, 569);
            this.Controls.Add(this.Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DroneSystem";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cargarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MArchivoCerrar;
        private System.Windows.Forms.ToolStripMenuItem ediciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MAyudaAcerdaDe;
        private System.Windows.Forms.ToolStripMenuItem dronesDisponiblesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem componentesDisponblesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem modelosDisponiblesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dronesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem componentesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem diseñosDisponiblesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dronesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem componentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem droneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem componenteToolStripMenuItem;
    }
}

