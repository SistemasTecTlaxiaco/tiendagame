namespace Proyecto_Final
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.textCodigoo = new System.Windows.Forms.TextBox();
            this.tablaVentas = new System.Windows.Forms.DataGridView();
            this.codigoo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totallabel = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.buttonProducto = new System.Windows.Forms.Button();
            this.buttonRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código del producto:";
            // 
            // textCodigoo
            // 
            this.textCodigoo.Location = new System.Drawing.Point(16, 96);
            this.textCodigoo.Name = "textCodigoo";
            this.textCodigoo.Size = new System.Drawing.Size(278, 20);
            this.textCodigoo.TabIndex = 1;
            this.textCodigoo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textCodigoo_KeyUp);
            // 
            // tablaVentas
            // 
            this.tablaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoo,
            this.productoo,
            this.precioo,
            this.cantidadd,
            this.subtotall});
            this.tablaVentas.Location = new System.Drawing.Point(16, 151);
            this.tablaVentas.Name = "tablaVentas";
            this.tablaVentas.Size = new System.Drawing.Size(543, 206);
            this.tablaVentas.TabIndex = 2;
            this.tablaVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaVentas_CellContentClick);
            // 
            // codigoo
            // 
            this.codigoo.HeaderText = "Codigo";
            this.codigoo.Name = "codigoo";
            // 
            // productoo
            // 
            this.productoo.HeaderText = "Producto";
            this.productoo.Name = "productoo";
            // 
            // precioo
            // 
            this.precioo.HeaderText = "Precio";
            this.precioo.Name = "precioo";
            // 
            // cantidadd
            // 
            this.cantidadd.HeaderText = "Cantidad";
            this.cantidadd.Name = "cantidadd";
            // 
            // subtotall
            // 
            this.subtotall.HeaderText = "Subtotal";
            this.subtotall.Name = "subtotall";
            // 
            // totallabel
            // 
            this.totallabel.AutoSize = true;
            this.totallabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totallabel.Location = new System.Drawing.Point(388, 369);
            this.totallabel.Name = "totallabel";
            this.totallabel.Size = new System.Drawing.Size(56, 24);
            this.totallabel.TabIndex = 3;
            this.totallabel.Text = "Total:";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(469, 369);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(77, 29);
            this.total.TabIndex = 4;
            this.total.Text = "$ 0.00";
            // 
            // buttonProducto
            // 
            this.buttonProducto.Location = new System.Drawing.Point(430, 96);
            this.buttonProducto.Name = "buttonProducto";
            this.buttonProducto.Size = new System.Drawing.Size(115, 23);
            this.buttonProducto.TabIndex = 5;
            this.buttonProducto.Text = "Agregar producto";
            this.buttonProducto.UseVisualStyleBackColor = true;
            this.buttonProducto.Click += new System.EventHandler(this.buttonProducto_Click);
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.Location = new System.Drawing.Point(16, 464);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(75, 23);
            this.buttonRegresar.TabIndex = 6;
            this.buttonRegresar.Text = "Regresar";
            this.buttonRegresar.UseVisualStyleBackColor = true;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // Form3
            // 
            this.ClientSize = new System.Drawing.Size(578, 539);
            this.Controls.Add(this.buttonRegresar);
            this.Controls.Add(this.buttonProducto);
            this.Controls.Add(this.total);
            this.Controls.Add(this.totallabel);
            this.Controls.Add(this.tablaVentas);
            this.Controls.Add(this.textCodigoo);
            this.Controls.Add(this.label2);
            this.Name = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.tablaVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_TIENDA;
        private System.Windows.Forms.LinkLabel inicio_boton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button But_InicioPag;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button But_TopJPG;
        private System.Windows.Forms.Button But_TopJG;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button But_Noti;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.DataGridView tableProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCodigoo;
        private System.Windows.Forms.DataGridView tablaVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoo;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoo;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadd;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotall;
        private System.Windows.Forms.Label totallabel;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Button buttonProducto;
        private System.Windows.Forms.Button buttonRegresar;
    }
}