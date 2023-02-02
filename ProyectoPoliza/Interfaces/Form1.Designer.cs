
namespace ProyectoPoliza.Interfaces
{
    partial class PolizaForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIdPoliza = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tablaAsegurados = new System.Windows.Forms.DataGridView();
            this.IdAsegurado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelProducto = new System.Windows.Forms.Label();
            this.labelTipoProducto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NombreProductoTxt = new System.Windows.Forms.Label();
            this.NombreTipoTxt = new System.Windows.Forms.Label();
            this.estadoTxt = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtNoHayAsegurados = new System.Windows.Forms.Label();
            this.alertTxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAsegurados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Poliza id";
            // 
            // textBoxIdPoliza
            // 
            this.textBoxIdPoliza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdPoliza.Location = new System.Drawing.Point(167, 61);
            this.textBoxIdPoliza.Name = "textBoxIdPoliza";
            this.textBoxIdPoliza.Size = new System.Drawing.Size(114, 22);
            this.textBoxIdPoliza.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(301, 53);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(97, 38);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "POLIZA";
            // 
            // tablaAsegurados
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tablaAsegurados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.tablaAsegurados.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaAsegurados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.tablaAsegurados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaAsegurados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAsegurado,
            this.Dni,
            this.Nombre,
            this.Edad});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaAsegurados.DefaultCellStyle = dataGridViewCellStyle15;
            this.tablaAsegurados.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.tablaAsegurados.Location = new System.Drawing.Point(72, 216);
            this.tablaAsegurados.Name = "tablaAsegurados";
            this.tablaAsegurados.Size = new System.Drawing.Size(447, 150);
            this.tablaAsegurados.TabIndex = 4;
            // 
            // IdAsegurado
            // 
            this.IdAsegurado.HeaderText = "Id";
            this.IdAsegurado.Name = "IdAsegurado";
            // 
            // Dni
            // 
            this.Dni.HeaderText = "Dni";
            this.Dni.Name = "Dni";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            // 
            // labelProducto
            // 
            this.labelProducto.AutoSize = true;
            this.labelProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProducto.Location = new System.Drawing.Point(69, 108);
            this.labelProducto.Name = "labelProducto";
            this.labelProducto.Size = new System.Drawing.Size(74, 16);
            this.labelProducto.TabIndex = 5;
            this.labelProducto.Text = "Producto:";
            // 
            // labelTipoProducto
            // 
            this.labelTipoProducto.AutoSize = true;
            this.labelTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoProducto.Location = new System.Drawing.Point(69, 134);
            this.labelTipoProducto.Name = "labelTipoProducto";
            this.labelTipoProducto.Size = new System.Drawing.Size(44, 16);
            this.labelTipoProducto.TabIndex = 6;
            this.labelTipoProducto.Text = "Tipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Estado:";
            // 
            // NombreProductoTxt
            // 
            this.NombreProductoTxt.AutoSize = true;
            this.NombreProductoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreProductoTxt.Location = new System.Drawing.Point(153, 107);
            this.NombreProductoTxt.Name = "NombreProductoTxt";
            this.NombreProductoTxt.Size = new System.Drawing.Size(0, 15);
            this.NombreProductoTxt.TabIndex = 8;
            // 
            // NombreTipoTxt
            // 
            this.NombreTipoTxt.AutoSize = true;
            this.NombreTipoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTipoTxt.Location = new System.Drawing.Point(153, 134);
            this.NombreTipoTxt.Name = "NombreTipoTxt";
            this.NombreTipoTxt.Size = new System.Drawing.Size(0, 15);
            this.NombreTipoTxt.TabIndex = 9;
            // 
            // estadoTxt
            // 
            this.estadoTxt.AutoSize = true;
            this.estadoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoTxt.Location = new System.Drawing.Point(150, 161);
            this.estadoTxt.Name = "estadoTxt";
            this.estadoTxt.Size = new System.Drawing.Size(0, 15);
            this.estadoTxt.TabIndex = 10;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(420, 372);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(99, 38);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar ";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtNoHayAsegurados
            // 
            this.txtNoHayAsegurados.AutoSize = true;
            this.txtNoHayAsegurados.Location = new System.Drawing.Point(269, 284);
            this.txtNoHayAsegurados.Name = "txtNoHayAsegurados";
            this.txtNoHayAsegurados.Size = new System.Drawing.Size(0, 13);
            this.txtNoHayAsegurados.TabIndex = 12;
            this.txtNoHayAsegurados.Visible = false;
            // 
            // alertTxt
            // 
            this.alertTxt.AutoSize = true;
            this.alertTxt.Location = new System.Drawing.Point(72, 190);
            this.alertTxt.Name = "alertTxt";
            this.alertTxt.Size = new System.Drawing.Size(660, 13);
            this.alertTxt.TabIndex = 13;
            this.alertTxt.Text = "Para eliminar debe seleccionar una fila desde la columa del lado izquierdo de ld," +
    "debe verse toda la fila seleccionada de COLOR NARANJA";
            // 
            // PolizaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.alertTxt);
            this.Controls.Add(this.txtNoHayAsegurados);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.estadoTxt);
            this.Controls.Add(this.NombreTipoTxt);
            this.Controls.Add(this.NombreProductoTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTipoProducto);
            this.Controls.Add(this.labelProducto);
            this.Controls.Add(this.tablaAsegurados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.textBoxIdPoliza);
            this.Controls.Add(this.label1);
            this.Name = "PolizaForm";
            this.Text = "Poliza";
            ((System.ComponentModel.ISupportInitialize)(this.tablaAsegurados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIdPoliza;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tablaAsegurados;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAsegurado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.Label labelProducto;
        private System.Windows.Forms.Label labelTipoProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NombreProductoTxt;
        private System.Windows.Forms.Label NombreTipoTxt;
        private System.Windows.Forms.Label estadoTxt;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label txtNoHayAsegurados;
        private System.Windows.Forms.Label alertTxt;
    }
}