namespace Conexion_con__bases_de_datos_y_entity_framework__Brithany_Hidalgo
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
            this.Productos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IDbox = new System.Windows.Forms.TextBox();
            this.Nombrebox = new System.Windows.Forms.TextBox();
            this.Preciobox = new System.Windows.Forms.TextBox();
            this.Stockbox = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.Read = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Productos
            // 
            this.Productos.AutoSize = true;
            this.Productos.Font = new System.Drawing.Font("Valentina", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Productos.ForeColor = System.Drawing.Color.Maroon;
            this.Productos.Location = new System.Drawing.Point(325, 24);
            this.Productos.Name = "Productos";
            this.Productos.Size = new System.Drawing.Size(186, 65);
            this.Productos.TabIndex = 0;
            this.Productos.Text = "Productos ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Pastel Orange", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(44, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Pastel Orange", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.ForeColor = System.Drawing.Color.Maroon;
            this.Nombre.Location = new System.Drawing.Point(44, 180);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(91, 29);
            this.Nombre.TabIndex = 3;
            this.Nombre.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Pastel Orange", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(44, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Precio ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Pastel Orange", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(44, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Stock ";
            // 
            // IDbox
            // 
            this.IDbox.Location = new System.Drawing.Point(156, 129);
            this.IDbox.Name = "IDbox";
            this.IDbox.Size = new System.Drawing.Size(116, 22);
            this.IDbox.TabIndex = 6;
            // 
            // Nombrebox
            // 
            this.Nombrebox.Location = new System.Drawing.Point(156, 187);
            this.Nombrebox.Name = "Nombrebox";
            this.Nombrebox.Size = new System.Drawing.Size(116, 22);
            this.Nombrebox.TabIndex = 7;
            // 
            // Preciobox
            // 
            this.Preciobox.Location = new System.Drawing.Point(156, 247);
            this.Preciobox.Name = "Preciobox";
            this.Preciobox.Size = new System.Drawing.Size(116, 22);
            this.Preciobox.TabIndex = 8;
            // 
            // Stockbox
            // 
            this.Stockbox.Location = new System.Drawing.Point(156, 307);
            this.Stockbox.Name = "Stockbox";
            this.Stockbox.Size = new System.Drawing.Size(116, 22);
            this.Stockbox.TabIndex = 9;
            // 
            // Create
            // 
            this.Create.ForeColor = System.Drawing.Color.Maroon;
            this.Create.Location = new System.Drawing.Point(49, 398);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(100, 38);
            this.Create.TabIndex = 10;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Read
            // 
            this.Read.ForeColor = System.Drawing.Color.Maroon;
            this.Read.Location = new System.Drawing.Point(201, 398);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(100, 38);
            this.Read.TabIndex = 11;
            this.Read.Text = "Read";
            this.Read.UseVisualStyleBackColor = true;
            this.Read.Click += new System.EventHandler(this.Read_Click);
            // 
            // Update
            // 
            this.Update.ForeColor = System.Drawing.Color.Maroon;
            this.Update.Location = new System.Drawing.Point(370, 398);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(100, 38);
            this.Update.TabIndex = 12;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.ForeColor = System.Drawing.Color.Maroon;
            this.Delete.Location = new System.Drawing.Point(533, 398);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(100, 38);
            this.Delete.TabIndex = 13;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(318, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(493, 227);
            this.dataGridView1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 478);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Read);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Stockbox);
            this.Controls.Add(this.Preciobox);
            this.Controls.Add(this.Nombrebox);
            this.Controls.Add(this.IDbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Productos);
            this.ForeColor = System.Drawing.Color.LavenderBlush;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Productos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IDbox;
        private System.Windows.Forms.TextBox Nombrebox;
        private System.Windows.Forms.TextBox Preciobox;
        private System.Windows.Forms.TextBox Stockbox;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

