namespace GaboStore.UserControls
{
    partial class UC_Compras
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
            dgvCompras = new DataGridView();
            cmbProductos = new ComboBox();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            numericUpDown2 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvCompras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // dgvCompras
            // 
            dgvCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompras.Location = new Point(0, 105);
            dgvCompras.Name = "dgvCompras";
            dgvCompras.RowHeadersWidth = 51;
            dgvCompras.RowTemplate.Height = 29;
            dgvCompras.Size = new Size(846, 236);
            dgvCompras.TabIndex = 0;
            // 
            // cmbProductos
            // 
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Location = new Point(87, 13);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(307, 28);
            cmbProductos.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 2;
            label1.Text = "Producto";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(89, 63);
            numericUpDown1.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(110, 27);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 4;
            label2.Text = "Cantidad";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(531, 14);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(297, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(403, 16);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 6;
            label3.Text = "Fecha de Compra";
            // 
            // button1
            // 
            button1.Location = new Point(531, 61);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(683, 61);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 8;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(233, 65);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 10;
            label4.Text = "Precio Unitario";
            // 
            // numericUpDown2
            // 
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown2.Location = new Point(346, 63);
            numericUpDown2.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(110, 27);
            numericUpDown2.TabIndex = 9;
            numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // UC_Compras
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
            Controls.Add(dgvCompras);
            Name = "UC_Compras";
            Size = new Size(846, 341);
            Load += UC_Compras_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCompras).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCompras;
        private ComboBox cmbProductos;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Button button1;
        private Button button2;
        private Label label4;
        private NumericUpDown numericUpDown2;
    }
}
