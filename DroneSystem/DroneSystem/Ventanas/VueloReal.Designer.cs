namespace DroneSystem.Ventanas
{
    partial class VueloReal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VueloReal));
            this.dataGridPlan = new System.Windows.Forms.DataGridView();
            this.nombrePlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ModeloDron = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPlan
            // 
            this.dataGridPlan.AllowUserToAddRows = false;
            this.dataGridPlan.AllowUserToDeleteRows = false;
            this.dataGridPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombrePlan});
            this.dataGridPlan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridPlan.Location = new System.Drawing.Point(12, 55);
            this.dataGridPlan.Name = "dataGridPlan";
            this.dataGridPlan.Size = new System.Drawing.Size(240, 150);
            this.dataGridPlan.TabIndex = 0;
            // 
            // nombrePlan
            // 
            this.nombrePlan.HeaderText = "Nombre";
            this.nombrePlan.Name = "nombrePlan";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ModeloDron});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(415, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(332, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // ModeloDron
            // 
            this.ModeloDron.HeaderText = "Modelo";
            this.ModeloDron.Name = "ModeloDron";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(299, 248);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // VueloReal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 283);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridPlan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VueloReal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vuelo Real";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePlan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModeloDron;
        private System.Windows.Forms.Button btnIniciar;
    }
}