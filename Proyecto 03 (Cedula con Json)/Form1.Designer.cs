namespace Consultorio
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgv_Civiles = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Crear = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tbx_Cedula = new System.Windows.Forms.TextBox();
            this.lbl_Cedula = new System.Windows.Forms.Label();
            this.tbx_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.tbx_Apellido = new System.Windows.Forms.TextBox();
            this.dtp_FechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtn_Masculino = new System.Windows.Forms.RadioButton();
            this.rbtn_Femenino = new System.Windows.Forms.RadioButton();
            this.lbl_Sexo = new System.Windows.Forms.Label();
            this.lbl_LugardeNacimiento = new System.Windows.Forms.Label();
            this.tbx_LugarNacimiento = new System.Windows.Forms.TextBox();
            this.cb_EstadoCivil = new System.Windows.Forms.ComboBox();
            this.lbl_EstadoCIvil = new System.Windows.Forms.Label();
            this.dtp_FechaExp = new System.Windows.Forms.DateTimePicker();
            this.lbl_FechaExp = new System.Windows.Forms.Label();
            this.cb_TipoSangre = new System.Windows.Forms.ComboBox();
            this.lbl_ = new System.Windows.Forms.Label();
            this.tbx_Nacionalidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_Telefono = new System.Windows.Forms.TextBox();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.gb_Cedula = new System.Windows.Forms.GroupBox();
            this.tbx_ID = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Civiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStripContainer1.SuspendLayout();
            this.gb_Cedula.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(106, 31);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(863, 53);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Instituto Tecnologico de Santo Domingo";
            // 
            // dgv_Civiles
            // 
            this.dgv_Civiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Civiles.Location = new System.Drawing.Point(784, 137);
            this.dgv_Civiles.Name = "dgv_Civiles";
            this.dgv_Civiles.RowHeadersWidth = 62;
            this.dgv_Civiles.RowTemplate.Height = 28;
            this.dgv_Civiles.Size = new System.Drawing.Size(843, 482);
            this.dgv_Civiles.TabIndex = 5;
            this.dgv_Civiles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Civiles_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Consultorio.Properties.Resources.profile;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Crear
            // 
            this.btn_Crear.BackColor = System.Drawing.Color.Blue;
            this.btn_Crear.Location = new System.Drawing.Point(20, 625);
            this.btn_Crear.Name = "btn_Crear";
            this.btn_Crear.Size = new System.Drawing.Size(153, 40);
            this.btn_Crear.TabIndex = 6;
            this.btn_Crear.Text = "Crear";
            this.btn_Crear.UseVisualStyleBackColor = false;
            this.btn_Crear.Click += new System.EventHandler(this.btn_Crear_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.Lime;
            this.btn_Guardar.Enabled = false;
            this.btn_Guardar.Location = new System.Drawing.Point(201, 625);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(152, 40);
            this.btn_Guardar.TabIndex = 7;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.Red;
            this.btn_Cancelar.Enabled = false;
            this.btn_Cancelar.Location = new System.Drawing.Point(612, 625);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(152, 40);
            this.btn_Cancelar.TabIndex = 8;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(150, 150);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 718);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(150, 175);
            this.toolStripContainer1.TabIndex = 9;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // tbx_Cedula
            // 
            this.tbx_Cedula.Location = new System.Drawing.Point(6, 143);
            this.tbx_Cedula.Name = "tbx_Cedula";
            this.tbx_Cedula.Size = new System.Drawing.Size(271, 26);
            this.tbx_Cedula.TabIndex = 0;
            this.tbx_Cedula.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lbl_Cedula
            // 
            this.lbl_Cedula.AutoSize = true;
            this.lbl_Cedula.Location = new System.Drawing.Point(6, 120);
            this.lbl_Cedula.Name = "lbl_Cedula";
            this.lbl_Cedula.Size = new System.Drawing.Size(63, 20);
            this.lbl_Cedula.TabIndex = 1;
            this.lbl_Cedula.Text = "Cedula:";
            this.lbl_Cedula.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbx_Nombre
            // 
            this.tbx_Nombre.Location = new System.Drawing.Point(6, 68);
            this.tbx_Nombre.Name = "tbx_Nombre";
            this.tbx_Nombre.Size = new System.Drawing.Size(271, 26);
            this.tbx_Nombre.TabIndex = 2;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(6, 45);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(69, 20);
            this.lbl_Nombre.TabIndex = 3;
            this.lbl_Nombre.Text = "Nombre:";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Location = new System.Drawing.Point(298, 45);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(69, 20);
            this.lbl_Apellido.TabIndex = 4;
            this.lbl_Apellido.Text = "Apellido:";
            this.lbl_Apellido.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // tbx_Apellido
            // 
            this.tbx_Apellido.Location = new System.Drawing.Point(303, 68);
            this.tbx_Apellido.Name = "tbx_Apellido";
            this.tbx_Apellido.Size = new System.Drawing.Size(271, 26);
            this.tbx_Apellido.TabIndex = 5;
            // 
            // dtp_FechaNacimiento
            // 
            this.dtp_FechaNacimiento.Location = new System.Drawing.Point(303, 143);
            this.dtp_FechaNacimiento.Name = "dtp_FechaNacimiento";
            this.dtp_FechaNacimiento.Size = new System.Drawing.Size(306, 26);
            this.dtp_FechaNacimiento.TabIndex = 6;
            this.dtp_FechaNacimiento.ValueChanged += new System.EventHandler(this.dtp_FechaNacimiento_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fecha de Nacimiento:";
            // 
            // rbtn_Masculino
            // 
            this.rbtn_Masculino.AutoSize = true;
            this.rbtn_Masculino.Location = new System.Drawing.Point(298, 222);
            this.rbtn_Masculino.Name = "rbtn_Masculino";
            this.rbtn_Masculino.Size = new System.Drawing.Size(47, 24);
            this.rbtn_Masculino.TabIndex = 10;
            this.rbtn_Masculino.TabStop = true;
            this.rbtn_Masculino.Text = "M";
            this.rbtn_Masculino.UseVisualStyleBackColor = true;
            // 
            // rbtn_Femenino
            // 
            this.rbtn_Femenino.AutoSize = true;
            this.rbtn_Femenino.Location = new System.Drawing.Point(352, 222);
            this.rbtn_Femenino.Name = "rbtn_Femenino";
            this.rbtn_Femenino.Size = new System.Drawing.Size(44, 24);
            this.rbtn_Femenino.TabIndex = 11;
            this.rbtn_Femenino.TabStop = true;
            this.rbtn_Femenino.Text = "F";
            this.rbtn_Femenino.UseVisualStyleBackColor = true;
            // 
            // lbl_Sexo
            // 
            this.lbl_Sexo.AutoSize = true;
            this.lbl_Sexo.Location = new System.Drawing.Point(298, 198);
            this.lbl_Sexo.Name = "lbl_Sexo";
            this.lbl_Sexo.Size = new System.Drawing.Size(49, 20);
            this.lbl_Sexo.TabIndex = 12;
            this.lbl_Sexo.Text = "Sexo:";
            // 
            // lbl_LugardeNacimiento
            // 
            this.lbl_LugardeNacimiento.AutoSize = true;
            this.lbl_LugardeNacimiento.Location = new System.Drawing.Point(6, 198);
            this.lbl_LugardeNacimiento.Name = "lbl_LugardeNacimiento";
            this.lbl_LugardeNacimiento.Size = new System.Drawing.Size(159, 20);
            this.lbl_LugardeNacimiento.TabIndex = 13;
            this.lbl_LugardeNacimiento.Text = "Lugar de Nacimiento:";
            // 
            // tbx_LugarNacimiento
            // 
            this.tbx_LugarNacimiento.Location = new System.Drawing.Point(6, 222);
            this.tbx_LugarNacimiento.Name = "tbx_LugarNacimiento";
            this.tbx_LugarNacimiento.Size = new System.Drawing.Size(271, 26);
            this.tbx_LugarNacimiento.TabIndex = 14;
            // 
            // cb_EstadoCivil
            // 
            this.cb_EstadoCivil.FormattingEnabled = true;
            this.cb_EstadoCivil.Items.AddRange(new object[] {
            "Soltero",
            "Casado",
            "Fallecido"});
            this.cb_EstadoCivil.Location = new System.Drawing.Point(6, 295);
            this.cb_EstadoCivil.Name = "cb_EstadoCivil";
            this.cb_EstadoCivil.Size = new System.Drawing.Size(271, 28);
            this.cb_EstadoCivil.TabIndex = 15;
            // 
            // lbl_EstadoCIvil
            // 
            this.lbl_EstadoCIvil.AutoSize = true;
            this.lbl_EstadoCIvil.Location = new System.Drawing.Point(6, 272);
            this.lbl_EstadoCIvil.Name = "lbl_EstadoCIvil";
            this.lbl_EstadoCIvil.Size = new System.Drawing.Size(95, 20);
            this.lbl_EstadoCIvil.TabIndex = 16;
            this.lbl_EstadoCIvil.Text = "Estado Civil:";
            this.lbl_EstadoCIvil.Click += new System.EventHandler(this.label4_Click);
            // 
            // dtp_FechaExp
            // 
            this.dtp_FechaExp.Location = new System.Drawing.Point(303, 372);
            this.dtp_FechaExp.Name = "dtp_FechaExp";
            this.dtp_FechaExp.Size = new System.Drawing.Size(306, 26);
            this.dtp_FechaExp.TabIndex = 17;
            // 
            // lbl_FechaExp
            // 
            this.lbl_FechaExp.AutoSize = true;
            this.lbl_FechaExp.Location = new System.Drawing.Point(304, 348);
            this.lbl_FechaExp.Name = "lbl_FechaExp";
            this.lbl_FechaExp.Size = new System.Drawing.Size(157, 20);
            this.lbl_FechaExp.TabIndex = 18;
            this.lbl_FechaExp.Text = "Fecha de Expiracion:";
            // 
            // cb_TipoSangre
            // 
            this.cb_TipoSangre.FormattingEnabled = true;
            this.cb_TipoSangre.Items.AddRange(new object[] {
            "O+",
            "O-",
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-"});
            this.cb_TipoSangre.Location = new System.Drawing.Point(6, 371);
            this.cb_TipoSangre.Name = "cb_TipoSangre";
            this.cb_TipoSangre.Size = new System.Drawing.Size(271, 28);
            this.cb_TipoSangre.TabIndex = 19;
            // 
            // lbl_
            // 
            this.lbl_.AutoSize = true;
            this.lbl_.Location = new System.Drawing.Point(6, 348);
            this.lbl_.Name = "lbl_";
            this.lbl_.Size = new System.Drawing.Size(121, 20);
            this.lbl_.TabIndex = 20;
            this.lbl_.Text = "Tipo de Sangre:";
            // 
            // tbx_Nacionalidad
            // 
            this.tbx_Nacionalidad.Location = new System.Drawing.Point(309, 295);
            this.tbx_Nacionalidad.Name = "tbx_Nacionalidad";
            this.tbx_Nacionalidad.Size = new System.Drawing.Size(271, 26);
            this.tbx_Nacionalidad.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nacionalidad:";
            // 
            // tbx_Telefono
            // 
            this.tbx_Telefono.Location = new System.Drawing.Point(6, 440);
            this.tbx_Telefono.Name = "tbx_Telefono";
            this.tbx_Telefono.Size = new System.Drawing.Size(271, 26);
            this.tbx_Telefono.TabIndex = 23;
            this.tbx_Telefono.TextChanged += new System.EventHandler(this.tbx_Telefono_TextChanged);
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.Location = new System.Drawing.Point(6, 417);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(75, 20);
            this.lbl_Telefono.TabIndex = 24;
            this.lbl_Telefono.Text = "Telefono:";
            // 
            // gb_Cedula
            // 
            this.gb_Cedula.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gb_Cedula.Controls.Add(this.tbx_ID);
            this.gb_Cedula.Controls.Add(this.lbl_ID);
            this.gb_Cedula.Controls.Add(this.lbl_Telefono);
            this.gb_Cedula.Controls.Add(this.tbx_Telefono);
            this.gb_Cedula.Controls.Add(this.label1);
            this.gb_Cedula.Controls.Add(this.tbx_Nacionalidad);
            this.gb_Cedula.Controls.Add(this.lbl_);
            this.gb_Cedula.Controls.Add(this.cb_TipoSangre);
            this.gb_Cedula.Controls.Add(this.lbl_FechaExp);
            this.gb_Cedula.Controls.Add(this.dtp_FechaExp);
            this.gb_Cedula.Controls.Add(this.lbl_EstadoCIvil);
            this.gb_Cedula.Controls.Add(this.cb_EstadoCivil);
            this.gb_Cedula.Controls.Add(this.tbx_LugarNacimiento);
            this.gb_Cedula.Controls.Add(this.lbl_LugardeNacimiento);
            this.gb_Cedula.Controls.Add(this.lbl_Sexo);
            this.gb_Cedula.Controls.Add(this.rbtn_Femenino);
            this.gb_Cedula.Controls.Add(this.rbtn_Masculino);
            this.gb_Cedula.Controls.Add(this.label2);
            this.gb_Cedula.Controls.Add(this.dtp_FechaNacimiento);
            this.gb_Cedula.Controls.Add(this.tbx_Apellido);
            this.gb_Cedula.Controls.Add(this.lbl_Apellido);
            this.gb_Cedula.Controls.Add(this.lbl_Nombre);
            this.gb_Cedula.Controls.Add(this.tbx_Nombre);
            this.gb_Cedula.Controls.Add(this.lbl_Cedula);
            this.gb_Cedula.Controls.Add(this.tbx_Cedula);
            this.gb_Cedula.Enabled = false;
            this.gb_Cedula.Location = new System.Drawing.Point(20, 137);
            this.gb_Cedula.Name = "gb_Cedula";
            this.gb_Cedula.Size = new System.Drawing.Size(744, 482);
            this.gb_Cedula.TabIndex = 4;
            this.gb_Cedula.TabStop = false;
            this.gb_Cedula.Text = "Formulario de Cedula";
            this.gb_Cedula.Enter += new System.EventHandler(this.gb_Cedula_Enter);
            // 
            // tbx_ID
            // 
            this.tbx_ID.Location = new System.Drawing.Point(641, 45);
            this.tbx_ID.Name = "tbx_ID";
            this.tbx_ID.ReadOnly = true;
            this.tbx_ID.Size = new System.Drawing.Size(53, 26);
            this.tbx_ID.TabIndex = 26;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(659, 22);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(30, 20);
            this.lbl_ID.TabIndex = 25;
            this.lbl_ID.Text = "ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1644, 715);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Crear);
            this.Controls.Add(this.dgv_Civiles);
            this.Controls.Add(this.gb_Cedula);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Sistema de Cedula";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Civiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.gb_Cedula.ResumeLayout(false);
            this.gb_Cedula.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgv_Civiles;
        private System.Windows.Forms.Button btn_Crear;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TextBox tbx_Cedula;
        private System.Windows.Forms.Label lbl_Cedula;
        private System.Windows.Forms.TextBox tbx_Nombre;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.TextBox tbx_Apellido;
        private System.Windows.Forms.DateTimePicker dtp_FechaNacimiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtn_Masculino;
        private System.Windows.Forms.RadioButton rbtn_Femenino;
        private System.Windows.Forms.Label lbl_Sexo;
        private System.Windows.Forms.Label lbl_LugardeNacimiento;
        private System.Windows.Forms.TextBox tbx_LugarNacimiento;
        private System.Windows.Forms.ComboBox cb_EstadoCivil;
        private System.Windows.Forms.Label lbl_EstadoCIvil;
        private System.Windows.Forms.DateTimePicker dtp_FechaExp;
        private System.Windows.Forms.Label lbl_FechaExp;
        private System.Windows.Forms.ComboBox cb_TipoSangre;
        private System.Windows.Forms.Label lbl_;
        private System.Windows.Forms.TextBox tbx_Nacionalidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_Telefono;
        private System.Windows.Forms.Label lbl_Telefono;
        private System.Windows.Forms.GroupBox gb_Cedula;
        private System.Windows.Forms.TextBox tbx_ID;
        private System.Windows.Forms.Label lbl_ID;
    }
}

