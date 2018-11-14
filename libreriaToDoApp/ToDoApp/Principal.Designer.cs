namespace ToDoApp
{
    partial class Principal
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvGrupos = new System.Windows.Forms.TreeView();
            this.btnAgregarNodo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gvTareas = new System.Windows.Forms.DataGridView();
            this.IdTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarFila = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(888, 434);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(880, 408);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tareas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightGray;
            this.splitContainer1.Panel1.Controls.Add(this.tvGrupos);
            this.splitContainer1.Panel1.Controls.Add(this.btnAgregarNodo);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.gvTareas);
            this.splitContainer1.Panel2.Controls.Add(this.btnAgregarFila);
            this.splitContainer1.Size = new System.Drawing.Size(874, 402);
            this.splitContainer1.SplitterDistance = 204;
            this.splitContainer1.TabIndex = 0;
            // 
            // tvGrupos
            // 
            this.tvGrupos.Location = new System.Drawing.Point(5, 45);
            this.tvGrupos.Name = "tvGrupos";
            this.tvGrupos.Size = new System.Drawing.Size(198, 352);
            this.tvGrupos.TabIndex = 3;
            this.tvGrupos.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.VerTareas);
            // 
            // btnAgregarNodo
            // 
            this.btnAgregarNodo.Image = global::ToDoApp.Properties.Resources.new_add_insert_file_13948;
            this.btnAgregarNodo.Location = new System.Drawing.Point(5, 3);
            this.btnAgregarNodo.Name = "btnAgregarNodo";
            this.btnAgregarNodo.Size = new System.Drawing.Size(39, 36);
            this.btnAgregarNodo.TabIndex = 0;
            this.btnAgregarNodo.UseVisualStyleBackColor = true;
            this.btnAgregarNodo.Click += new System.EventHandler(this.btnAgregarNodo_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Image = global::ToDoApp.Properties.Resources.eliminar_2;
            this.button2.Location = new System.Drawing.Point(50, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 36);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Remover tarea";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnRemoverTareas);
            // 
            // gvTareas
            // 
            this.gvTareas.AllowUserToAddRows = false;
            this.gvTareas.AllowUserToDeleteRows = false;
            this.gvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTarea,
            this.Nombre,
            this.Prioridad,
            this.Porcentaje,
            this.FechaInicio,
            this.FechaFinal});
            this.gvTareas.Location = new System.Drawing.Point(16, 45);
            this.gvTareas.Name = "gvTareas";
            this.gvTareas.ReadOnly = true;
            this.gvTareas.Size = new System.Drawing.Size(645, 352);
            this.gvTareas.TabIndex = 0;
            // 
            // IdTarea
            // 
            this.IdTarea.HeaderText = "ID Tarea";
            this.IdTarea.Name = "IdTarea";
            this.IdTarea.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Prioridad
            // 
            this.Prioridad.HeaderText = "Prioridad";
            this.Prioridad.Name = "Prioridad";
            this.Prioridad.ReadOnly = true;
            // 
            // Porcentaje
            // 
            this.Porcentaje.HeaderText = "Porcentaje";
            this.Porcentaje.Name = "Porcentaje";
            this.Porcentaje.ReadOnly = true;
            // 
            // FechaInicio
            // 
            this.FechaInicio.HeaderText = "Fecha de inicio";
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            // 
            // FechaFinal
            // 
            this.FechaFinal.HeaderText = "Fecha de finalizacion";
            this.FechaFinal.Name = "FechaFinal";
            this.FechaFinal.ReadOnly = true;
            // 
            // btnAgregarFila
            // 
            this.btnAgregarFila.Location = new System.Drawing.Point(21, 16);
            this.btnAgregarFila.Name = "btnAgregarFila";
            this.btnAgregarFila.Size = new System.Drawing.Size(95, 23);
            this.btnAgregarFila.TabIndex = 1;
            this.btnAgregarFila.Text = "Agregar tarea";
            this.btnAgregarFila.UseVisualStyleBackColor = true;
            this.btnAgregarFila.Click += new System.EventHandler(this.btnAgregarFila_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 434);
            this.Controls.Add(this.tabControl1);
            this.Name = "Principal";
            this.Text = "Principal";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvTareas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnAgregarNodo;
        private System.Windows.Forms.DataGridView gvTareas;
        private System.Windows.Forms.Button btnAgregarFila;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TreeView tvGrupos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prioridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFinal;
    }
}