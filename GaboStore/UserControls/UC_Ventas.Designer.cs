namespace GaboStore.UserControls
{
    partial class UC_Ventas
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            dgvVentas = new DataGridView();
            label4 = new Label();
            numericUpDown2 = new NumericUpDown();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            cmbProductos = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(0, 105);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.RowTemplate.Height = 29;
            dgvVentas.Size = new Size(846, 236);
            dgvVentas.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(226, 70);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 20;
            label4.Text = "Precio Unitario";
            // 
            // numericUpDown2
            // 
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown2.Location = new Point(339, 68);
            numericUpDown2.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(110, 27);
            numericUpDown2.TabIndex = 19;
            numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // button2
            // 
            button2.Location = new Point(676, 66);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 18;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(524, 66);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 17;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(396, 21);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 16;
            label3.Text = "Fecha de Venta";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(524, 19);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(297, 27);
            dateTimePicker1.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 70);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 14;
            label2.Text = "Cantidad";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(82, 68);
            numericUpDown1.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(110, 27);
            numericUpDown1.TabIndex = 13;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 21);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 12;
            label1.Text = "Producto";
            // 
            // cmbProductos
            // 
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Location = new Point(80, 18);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(307, 28);
            cmbProductos.TabIndex = 11;
            // 
            // UC_Ventas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(numericUpDown2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Controls.Add(cmbProductos);
            Controls.Add(dgvVentas);
            Name = "UC_Ventas";
            Size = new Size(846, 341);
            Load += UC_Ventas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVentas;
        private Label label4;
        private NumericUpDown numericUpDown2;
        private Button button2;
        private Button button1;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private ComboBox cmbProductos;
    }
}
