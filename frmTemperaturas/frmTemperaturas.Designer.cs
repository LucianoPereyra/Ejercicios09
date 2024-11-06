namespace frmTemperaturas
{
    partial class frmTemperaturas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTemperaturas));
            textBox1 = new TextBox();
            label1 = new Label();
            toolStrip1 = new ToolStrip();
            Agregar = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            tspEditar = new ToolStripButton();
            dgvDatos = new DataGridView();
            ColumnaGrados = new DataGridViewTextBoxColumn();
            ColumnaReaumur = new DataGridViewTextBoxColumn();
            ColumnaFahrenheit = new DataGridViewTextBoxColumn();
            label2 = new Label();
            txtCantidad = new TextBox();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(119, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(97, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-3, 69);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 1;
            label1.Text = "Ingrese temperatura ";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { Agregar, toolStripButton2, tspEditar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(659, 38);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // Agregar
            // 
            Agregar.Image = (Image)resources.GetObject("Agregar.Image");
            Agregar.ImageTransparentColor = Color.Magenta;
            Agregar.Name = "Agregar";
            Agregar.Size = new Size(53, 35);
            Agregar.Text = "Agregar";
            Agregar.TextImageRelation = TextImageRelation.ImageAboveText;
            Agregar.ToolTipText = "tspAgregar";
            Agregar.Click += Agregar_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(54, 35);
            toolStripButton2.Text = "Eliminar";
            toolStripButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton2.ToolTipText = "tsbEliminar";
            // 
            // tspEditar
            // 
            tspEditar.Image = (Image)resources.GetObject("tspEditar.Image");
            tspEditar.ImageTransparentColor = Color.Magenta;
            tspEditar.Name = "tspEditar";
            tspEditar.Size = new Size(41, 35);
            tspEditar.Text = "Editar";
            tspEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { ColumnaGrados, ColumnaReaumur, ColumnaFahrenheit });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 38);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.Size = new Size(659, 317);
            dgvDatos.TabIndex = 3;
            // 
            // ColumnaGrados
            // 
            ColumnaGrados.HeaderText = "Grados Celsius";
            ColumnaGrados.Name = "ColumnaGrados";
            ColumnaGrados.ReadOnly = true;
            // 
            // ColumnaReaumur
            // 
            ColumnaReaumur.HeaderText = "Grados Reaumur";
            ColumnaReaumur.Name = "ColumnaReaumur";
            ColumnaReaumur.ReadOnly = true;
            // 
            // ColumnaFahrenheit
            // 
            ColumnaFahrenheit.HeaderText = "Grados Fahrenheit";
            ColumnaFahrenheit.Name = "ColumnaFahrenheit";
            ColumnaFahrenheit.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 329);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 4;
            label2.Text = "Cantidad de registros";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(137, 326);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 5;
            // 
            // frmTemperaturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 355);
            Controls.Add(txtCantidad);
            Controls.Add(label2);
            Controls.Add(dgvDatos);
            Controls.Add(toolStrip1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "frmTemperaturas";
            Text = "Form1";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private ToolStrip toolStrip1;
        private ToolStripButton Agregar;
        private ToolStripButton toolStripButton2;
        private ToolStripButton tspEditar;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn ColumnaGrados;
        private DataGridViewTextBoxColumn ColumnaReaumur;
        private DataGridViewTextBoxColumn ColumnaFahrenheit;
        private Label label2;
        private TextBox txtCantidad;
    }
}
