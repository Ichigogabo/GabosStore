namespace GaboStore.UserControls
{
    partial class UC_Productos
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
            dGVProductos = new DataGridView();
            Descripcion = new TextBox();
            lblDescripcion = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dGVProductos).BeginInit();
            SuspendLayout();
            // 
            // dGVProductos
            // 
            dGVProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVProductos.Location = new Point(0, 105);
            dGVProductos.Name = "dGVProductos";
            dGVProductos.RowHeadersWidth = 51;
            dGVProductos.RowTemplate.Height = 29;
            dGVProductos.Size = new Size(846, 236);
            dGVProductos.TabIndex = 0;
            // 
            // Descripcion
            // 
            Descripcion.Location = new Point(172, 36);
            Descripcion.Name = "Descripcion";
            Descripcion.Size = new Size(322, 27);
            Descripcion.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(61, 39);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(87, 20);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Descripciòn";
            // 
            // button1
            // 
            button1.Location = new Point(522, 34);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(651, 34);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // UC_Productos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblDescripcion);
            Controls.Add(Descripcion);
            Controls.Add(dGVProductos);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_Productos";
            Size = new Size(846, 341);
            Load += UC_Productos_Load;
            ((System.ComponentModel.ISupportInitialize)dGVProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dGVProductos;
        private TextBox Descripcion;
        private Label lblDescripcion;
        private Button button1;
        private Button button2;
    }
}
