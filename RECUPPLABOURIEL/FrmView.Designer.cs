namespace RECUPPLABOURIEL
{
    partial class FrmView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmView));
            lstVehiculos = new ListBox();
            pictureBox1 = new PictureBox();
            cmbTipo = new ComboBox();
            btnFabricar = new Button();
            btnEliminar = new Button();
            lblTipo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lstVehiculos
            // 
            lstVehiculos.FormattingEnabled = true;
            lstVehiculos.HorizontalScrollbar = true;
            lstVehiculos.ItemHeight = 15;
            lstVehiculos.Location = new Point(12, 12);
            lstVehiculos.Name = "lstVehiculos";
            lstVehiculos.Size = new Size(570, 424);
            lstVehiculos.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(685, 126);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 84);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(606, 71);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(217, 23);
            cmbTipo.TabIndex = 2;
            // 
            // btnFabricar
            // 
            btnFabricar.Location = new Point(620, 244);
            btnFabricar.Name = "btnFabricar";
            btnFabricar.Size = new Size(180, 70);
            btnFabricar.TabIndex = 3;
            btnFabricar.Text = "Fabricar";
            btnFabricar.UseVisualStyleBackColor = true;
            btnFabricar.Click += btnFabricar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(620, 338);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(180, 78);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(676, 34);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(94, 15);
            lblTipo.TabIndex = 5;
            lblTipo.Text = "Tipo de Vehiculo";
            // 
            // FrmView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 450);
            Controls.Add(lblTipo);
            Controls.Add(btnEliminar);
            Controls.Add(btnFabricar);
            Controls.Add(cmbTipo);
            Controls.Add(pictureBox1);
            Controls.Add(lstVehiculos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fabrica de Vehiculos";
            Load += FrmView_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstVehiculos;
        private PictureBox pictureBox1;
        private ComboBox cmbTipo;
        private Button btnFabricar;
        private Button btnEliminar;
        private Label lblTipo;
    }
}