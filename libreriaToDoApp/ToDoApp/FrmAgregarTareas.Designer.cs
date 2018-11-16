namespace ToDoApp
{
    partial class FrmAgregarTareas
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
            System.Windows.Forms.DateTimePicker dateFinal;
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.textTarea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateInicial = new System.Windows.Forms.DateTimePicker();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            dateFinal = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(181, 188);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnGuardar.Location = new System.Drawing.Point(86, 188);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // textTarea
            // 
            this.textTarea.Location = new System.Drawing.Point(86, 39);
            this.textTarea.Name = "textTarea";
            this.textTarea.Size = new System.Drawing.Size(88, 20);
            this.textTarea.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Prioridad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Fecha de inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Fecha de final";
            // 
            // dateFinal
            // 
            dateFinal.CustomFormat = "";
            dateFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateFinal.Location = new System.Drawing.Point(214, 127);
            dateFinal.Name = "dateFinal";
            dateFinal.Size = new System.Drawing.Size(153, 20);
            dateFinal.TabIndex = 25;
            dateFinal.Value = new System.DateTime(2018, 11, 14, 21, 14, 42, 0);
            dateFinal.ValueChanged += new System.EventHandler(this.dateFinal_ValueChanged);
            // 
            // dateInicial
            // 
            this.dateInicial.CustomFormat = "";
            this.dateInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateInicial.Location = new System.Drawing.Point(8, 127);
            this.dateInicial.Name = "dateInicial";
            this.dateInicial.Size = new System.Drawing.Size(153, 20);
            this.dateInicial.TabIndex = 26;
            this.dateInicial.Value = new System.DateTime(2018, 11, 14, 21, 4, 28, 0);
            this.dateInicial.ValueChanged += new System.EventHandler(this.dateInicial_ValueChanged);
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.FormattingEnabled = true;
            this.cmbPrioridad.Items.AddRange(new object[] {
            "Alta ",
            "Media ",
            "Baja"});
            this.cmbPrioridad.Location = new System.Drawing.Point(262, 36);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(76, 21);
            this.cmbPrioridad.TabIndex = 27;
            // 
            // FrmAgregarTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 241);
            this.Controls.Add(this.cmbPrioridad);
            this.Controls.Add(this.dateInicial);
            this.Controls.Add(dateFinal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.textTarea);
            this.Controls.Add(this.label3);
            this.Name = "FrmAgregarTareas";
            this.Text = "FrmAgregarTareas";
            this.Load += new System.EventHandler(this.FrmAgregarTareas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox textTarea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateInicial;
        private System.Windows.Forms.ComboBox cmbPrioridad;
    }
}