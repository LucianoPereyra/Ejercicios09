namespace Ejercio5.Windows
{
    partial class frmTemperaturasAE
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtTemperatura = new TextBox();
            btnOK = new Button();
            btnCancel = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 15);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Agregar";
            // 
            // txtTemperatura
            // 
            txtTemperatura.Location = new Point(59, 12);
            txtTemperatura.Name = "txtTemperatura";
            txtTemperatura.Size = new Size(100, 23);
            txtTemperatura.TabIndex = 1;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(12, 87);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(68, 34);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += button1_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(101, 85);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(76, 35);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmTemperaturasAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 266);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(txtTemperatura);
            Controls.Add(label1);
            Name = "frmTemperaturasAE";
            Text = "frmTemperaturasAE";
            Load += frmTemperaturasAE_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTemperatura;
        private Button btnOK;
        private Button btnCancel;
        private ErrorProvider errorProvider1;
    }
}