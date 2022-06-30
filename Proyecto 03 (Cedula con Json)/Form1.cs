using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio
{
    public partial class Form1 : Form
    {
        public bool Agregar { get; set; } = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {
            btn_Crear.Enabled = false;
            btn_Guardar.Enabled = true;
            btn_Cancelar.Enabled = true;
            gb_Cedula.Enabled = true;

            GenerateNewID();
            GetRecords();
        }

        private void GenerateNewID()
        {
            EmptyControls();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            SaveRecord();            
        }
        private void SaveRecord()
        {
            var json = string.Empty;
            var civilianList = new List<Civilian>();
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Civilian.json";

            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                civilianList = JsonConvert.DeserializeObject<List<Civilian>>(json);
            }

            var civilian = new Civilian();
            if (Agregar)
            {
                civilian = new Civilian
                {
                    ID = int.Parse(tbx_ID.Text),
                    Nombre = tbx_Nombre.Text,
                    Apellido = tbx_Apellido.Text,
                    Cedula = tbx_Cedula.Text,
                    LugarNacimiento = tbx_LugarNacimiento.Text,
                    EstadoCivil = cb_EstadoCivil.Text,
                    Sangre = cb_TipoSangre.Text,
                    Nacionalidad = tbx_Nacionalidad.Text,
                    Sexo = rbtn_Femenino.Checked ? "F" : "M",
                    Nacimiento = dtp_FechaNacimiento.Value,
                    Expiracion = dtp_FechaExp.Value,
                    Telefono = tbx_Telefono.Text,
                };
            }
            else
            {
                var Id = int.Parse(tbx_ID.Text);
                civilian = civilianList.FirstOrDefault(x => x.ID == Id);

                if (civilian != null)
                {
                    civilianList.Remove(civilian);

                    civilian.ID = int.Parse(tbx_ID.Text);
                    civilian.Nombre = tbx_Nombre.Text;
                    civilian.Apellido = tbx_Apellido.Text;
                    civilian.Cedula = tbx_Cedula.Text;
                    civilian.LugarNacimiento = tbx_LugarNacimiento.Text;
                    civilian.EstadoCivil = cb_EstadoCivil.Text;
                    civilian.Sangre = cb_TipoSangre.Text;
                    civilian.Nacionalidad = tbx_Nacionalidad.Text;
                    civilian.Sexo = rbtn_Femenino.Checked ? "F" : "M";
                    civilian.Nacimiento = dtp_FechaNacimiento.Value;
                    civilian.Expiracion = dtp_FechaExp.Value;
                    civilian.Telefono = tbx_Telefono.Text;
                }

            }

        civilianList.Add(civilian);

            json = JsonConvert.SerializeObject(civilianList);

            var sw = new StreamWriter(pathFile, false, Encoding.UTF8);
            sw.Write(json);
            sw.Close();

            MessageBox.Show("Registro Almacenado", "INTEC", MessageBoxButtons.OK, MessageBoxIcon.Information);


            gb_Cedula.Enabled = false;
            btn_Crear.Enabled = true;
            btn_Guardar.Enabled = false;
            btn_Cancelar.Enabled = false;

            EmptyControls();
            GetRecords();
        }

        private void GetRecords()
        {
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Civilian.json";

            var civilianList = new List<Civilian>();

            if (File.Exists(pathFile))
            {
                var json = File.ReadAllText(pathFile, Encoding.UTF8);
                civilianList = JsonConvert.DeserializeObject<List<Civilian>>(json);

            }
            tbx_ID.Text = (civilianList.Count + 1).ToString();
            dgv_Civiles.DataSource = civilianList;
          
           

        

        }
        private void EmptyControls()
        {
            foreach (Control c in gb_Cedula.Controls)
            {
                if (c is TextBox) 
                {
                    c.Text = String.Empty;
                }
            }
        }

        private void tbx_Telefono_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void dgv_Civiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void gb_Cedula_Enter(object sender, EventArgs e)
        {

        }

        private void dtp_FechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            int edad = DateTime.Now.Year- dtp_FechaNacimiento.Value.Year;
            this.BackColor = edad == 18 ? Color.DarkSeaGreen : Color.Blue; 
        }
    }
    
}
