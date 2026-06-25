namespace PL
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.Buscar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnFin = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Longitud = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Latitud = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Op2 = new System.Windows.Forms.RadioButton();
            this.Op1 = new System.Windows.Forms.RadioButton();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.Mapa = new GMap.NET.WindowsForms.GMapControl();
            this.BtnInformacion = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnGuardar,
            this.toolStripSeparator1,
            this.BtnModificar,
            this.toolStripSeparator2,
            this.BtnEliminar,
            this.toolStripSeparator3,
            this.BtnInformacion,
            this.toolStripSeparator5,
            this.toolStripLabel1,
            this.Buscar,
            this.toolStripSeparator4,
            this.BtnFin});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1370, 44);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(91, 41);
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 44);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificar.Image")));
            this.BtnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(102, 41);
            this.BtnModificar.Text = "MODIFICAR";
            this.BtnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 44);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(90, 41);
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 44);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(60, 41);
            this.toolStripLabel1.Text = "Buscar";
            // 
            // Buscar
            // 
            this.Buscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(200, 44);
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            this.Buscar.TextChanged += new System.EventHandler(this.Buscar_TextChanged);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 44);
            // 
            // BtnFin
            // 
            this.BtnFin.Image = ((System.Drawing.Image)(resources.GetObject("BtnFin.Image")));
            this.BtnFin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnFin.Name = "BtnFin";
            this.BtnFin.Size = new System.Drawing.Size(40, 41);
            this.BtnFin.Text = "FIN";
            this.BtnFin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnFin.Click += new System.EventHandler(this.BtnFin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "GESTION DE CLIENTES";
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo.Location = new System.Drawing.Point(547, 106);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(92, 31);
            this.Codigo.TabIndex = 2;
            this.Codigo.Text = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.Longitud);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Latitud);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.Nombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(50, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 320);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DE 1 CLIENTE";
            // 
            // Longitud
            // 
            this.Longitud.Location = new System.Drawing.Point(144, 254);
            this.Longitud.Name = "Longitud";
            this.Longitud.Size = new System.Drawing.Size(165, 27);
            this.Longitud.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "LONGITUD";
            // 
            // Latitud
            // 
            this.Latitud.Location = new System.Drawing.Point(144, 203);
            this.Latitud.Name = "Latitud";
            this.Latitud.Size = new System.Drawing.Size(165, 27);
            this.Latitud.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "LATITUD";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.Op2);
            this.groupBox2.Controls.Add(this.Op1);
            this.groupBox2.Location = new System.Drawing.Point(24, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 99);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GENERO";
            // 
            // Op2
            // 
            this.Op2.AutoSize = true;
            this.Op2.Location = new System.Drawing.Point(26, 56);
            this.Op2.Name = "Op2";
            this.Op2.Size = new System.Drawing.Size(94, 26);
            this.Op2.TabIndex = 1;
            this.Op2.TabStop = true;
            this.Op2.Text = "MUJER";
            this.Op2.UseVisualStyleBackColor = true;
            // 
            // Op1
            // 
            this.Op1.AutoSize = true;
            this.Op1.Checked = true;
            this.Op1.Location = new System.Drawing.Point(26, 24);
            this.Op1.Name = "Op1";
            this.Op1.Size = new System.Drawing.Size(112, 26);
            this.Op1.TabIndex = 0;
            this.Op1.TabStop = true;
            this.Op1.Text = "HOMBRE";
            this.Op1.UseVisualStyleBackColor = true;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(144, 32);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(165, 27);
            this.Nombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "NOMBRE";
            // 
            // Dgv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv.Location = new System.Drawing.Point(49, 527);
            this.Dgv.Name = "Dgv";
            this.Dgv.Size = new System.Drawing.Size(1165, 180);
            this.Dgv.TabIndex = 4;
            this.Dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellClick);
            this.Dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellContentClick);
            // 
            // Mapa
            // 
            this.Mapa.Bearing = 0F;
            this.Mapa.CanDragMap = true;
            this.Mapa.EmptyTileColor = System.Drawing.Color.Navy;
            this.Mapa.GrayScaleMode = false;
            this.Mapa.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.Mapa.LevelsKeepInMemmory = 5;
            this.Mapa.Location = new System.Drawing.Point(619, 174);
            this.Mapa.MarkersEnabled = true;
            this.Mapa.MaxZoom = 2;
            this.Mapa.MinZoom = 2;
            this.Mapa.MouseWheelZoomEnabled = true;
            this.Mapa.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.Mapa.Name = "Mapa";
            this.Mapa.NegativeMode = false;
            this.Mapa.PolygonsEnabled = true;
            this.Mapa.RetryLoadTile = 0;
            this.Mapa.RoutesEnabled = true;
            this.Mapa.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.Mapa.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.Mapa.ShowTileGridLines = false;
            this.Mapa.Size = new System.Drawing.Size(505, 320);
            this.Mapa.TabIndex = 5;
            this.Mapa.Zoom = 0D;
            // 
            // BtnInformacion
            // 
            this.BtnInformacion.Image = ((System.Drawing.Image)(resources.GetObject("BtnInformacion.Image")));
            this.BtnInformacion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnInformacion.Name = "BtnInformacion";
            this.BtnInformacion.Size = new System.Drawing.Size(128, 41);
            this.BtnInformacion.Text = "INFORMACION";
            this.BtnInformacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnInformacion.Click += new System.EventHandler(this.BtnInformacion_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 44);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.Mapa);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BtnModificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton BtnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox Buscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton BtnFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Op1;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Longitud;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Latitud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton Op2;
        private System.Windows.Forms.DataGridView Dgv;
        private GMap.NET.WindowsForms.GMapControl Mapa;
        private System.Windows.Forms.ToolStripButton BtnInformacion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}

