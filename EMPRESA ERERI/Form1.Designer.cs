namespace EMPRESA_ERERI
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnagregar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btnseleccionar = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.TextBox();
            this.celular = new System.Windows.Forms.TextBox();
            this.telefono = new System.Windows.Forms.TextBox();
            this.correo = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.Nmbre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnconectar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(12, 435);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(126, 39);
            this.btnagregar.TabIndex = 0;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(158, 435);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(126, 39);
            this.btneliminar.TabIndex = 1;
            this.btneliminar.Text = "ELeminiar";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(305, 435);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(126, 39);
            this.btnactualizar.TabIndex = 2;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.Location = new System.Drawing.Point(440, 435);
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.Size = new System.Drawing.Size(126, 39);
            this.btnseleccionar.TabIndex = 3;
            this.btnseleccionar.Text = "Seleccionar";
            this.btnseleccionar.UseVisualStyleBackColor = true;
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(661, 86);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(105, 20);
            this.codigo.TabIndex = 4;
            this.codigo.TextChanged += new System.EventHandler(this.codigo_TextChanged);
            // 
            // celular
            // 
            this.celular.Location = new System.Drawing.Point(661, 279);
            this.celular.Name = "celular";
            this.celular.Size = new System.Drawing.Size(105, 20);
            this.celular.TabIndex = 5;
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(661, 240);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(105, 20);
            this.telefono.TabIndex = 6;
            // 
            // correo
            // 
            this.correo.Location = new System.Drawing.Point(661, 198);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(105, 20);
            this.correo.TabIndex = 7;
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(661, 160);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(105, 20);
            this.apellido.TabIndex = 8;
            this.apellido.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(661, 123);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(105, 20);
            this.nombre.TabIndex = 9;
            // 
            // Nmbre
            // 
            this.Nmbre.AutoSize = true;
            this.Nmbre.Location = new System.Drawing.Point(584, 90);
            this.Nmbre.Name = "Nmbre";
            this.Nmbre.Size = new System.Drawing.Size(40, 13);
            this.Nmbre.TabIndex = 10;
            this.Nmbre.Text = "Código";
            this.Nmbre.Click += new System.EventHandler(this.Nmbre_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(584, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre(s)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(584, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(584, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Correo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(584, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(584, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Celular";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(530, 275);
            this.dataGridView1.TabIndex = 16;
            // 
            // btnconectar
            // 
            this.btnconectar.Location = new System.Drawing.Point(397, 28);
            this.btnconectar.Name = "btnconectar";
            this.btnconectar.Size = new System.Drawing.Size(113, 24);
            this.btnconectar.TabIndex = 17;
            this.btnconectar.Text = "conectar";
            this.btnconectar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(791, 500);
            this.Controls.Add(this.btnconectar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nmbre);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.celular);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.btnseleccionar);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnagregar);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btnseleccionar;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.TextBox celular;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.TextBox correo;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label Nmbre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnconectar;
    }
}

