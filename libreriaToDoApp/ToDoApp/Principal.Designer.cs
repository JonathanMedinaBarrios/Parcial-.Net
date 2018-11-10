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
            this.btnAgregarNodo = new System.Windows.Forms.Button();
            this.tvGrupos = new System.Windows.Forms.TreeView();
            this.gvTareas = new System.Windows.Forms.DataGridView();
            this.ColumnIDTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ddlPorcentaje = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarFila = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTareas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(787, 434);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(779, 408);
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
            this.splitContainer1.Panel1.Controls.Add(this.btnAgregarNodo);
            this.splitContainer1.Panel1.Controls.Add(this.tvGrupos);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gvTareas);
            this.splitContainer1.Panel2.Controls.Add(this.ddlPorcentaje);
            this.splitContainer1.Panel2.Controls.Add(this.numericUpDown1);
            this.splitContainer1.Panel2.Controls.Add(this.btnAgregarFila);
            this.splitContainer1.Size = new System.Drawing.Size(773, 402);
            this.splitContainer1.SplitterDistance = 256;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnAgregarNodo
            // 
            this.btnAgregarNodo.Location = new System.Drawing.Point(147, 3);
            this.btnAgregarNodo.Name = "btnAgregarNodo";
            this.btnAgregarNodo.Size = new System.Drawing.Size(39, 36);
            this.btnAgregarNodo.TabIndex = 0;
            this.btnAgregarNodo.UseVisualStyleBackColor = true;
            this.btnAgregarNodo.Click += new System.EventHandler(this.btnAgregarNodo_Click);
            // 
            // tvGrupos
            // 
            this.tvGrupos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvGrupos.Location = new System.Drawing.Point(0, 0);
            this.tvGrupos.Name = "tvGrupos";
            this.tvGrupos.Size = new System.Drawing.Size(256, 402);
            this.tvGrupos.TabIndex = 0;
            // 
            // gvTareas
            // 
            this.gvTareas.AllowUserToAddRows = false;
            this.gvTareas.AllowUserToDeleteRows = false;
            this.gvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIDTarea,
            this.ColumnNombre});
            this.gvTareas.Location = new System.Drawing.Point(3, 116);
            this.gvTareas.Name = "gvTareas";
            this.gvTareas.ReadOnly = true;
            this.gvTareas.Size = new System.Drawing.Size(505, 281);
            this.gvTareas.TabIndex = 0;
            // 
            // ColumnIDTarea
            // 
            this.ColumnIDTarea.HeaderText = "ID Tarea";
            this.ColumnIDTarea.Name = "ColumnIDTarea";
            this.ColumnIDTarea.ReadOnly = true;
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.HeaderText = "Nombre";
            this.ColumnNombre.Name = "ColumnNombre";
            this.ColumnNombre.ReadOnly = true;
            // 
            // ddlPorcentaje
            // 
            this.ddlPorcentaje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlPorcentaje.FormattingEnabled = true;
            this.ddlPorcentaje.Items.AddRange(new object[] {
            "0",
            "10",
            "20",
            "50",
            "70",
            "100"});
            this.ddlPorcentaje.Location = new System.Drawing.Point(128, 54);
            this.ddlPorcentaje.Name = "ddlPorcentaje";
            this.ddlPorcentaje.Size = new System.Drawing.Size(121, 21);
            this.ddlPorcentaje.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(278, 55);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 2;
            // 
            // btnAgregarFila
            // 
            this.btnAgregarFila.Location = new System.Drawing.Point(27, 52);
            this.btnAgregarFila.Name = "btnAgregarFila";
            this.btnAgregarFila.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarFila.TabIndex = 1;
            this.btnAgregarFila.Text = "button1";
            this.btnAgregarFila.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 434);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnAgregarNodo;
        private System.Windows.Forms.TreeView tvGrupos;
        private System.Windows.Forms.DataGridView gvTareas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIDTarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.ComboBox ddlPorcentaje;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnAgregarFila;
    }
}