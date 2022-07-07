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
            EmptyControls();
            GetRecords();
            btn_Crear.Enabled = true;
            btn_Guardar.Enabled = false;
            btn_Cancelar.Enabled = false;
            btn_Actualizar.Enabled = false;
            btn_Borrar.Enabled = false;
            gb_Cedula.Enabled = false;
            btn_Modificar.Enabled = true;
        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {
            btn_Crear.Enabled = false;
            btn_Guardar.Enabled = true;
            btn_Cancelar.Enabled = true;
            btn_Actualizar.Enabled = false;
            btn_Borrar.Enabled = false;
            gb_Cedula.Enabled = true;
            btn_Modificar.Enabled = false;

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
                    Sexo = cb_Sexo.Text,
                    Nacimiento = dtp_FechaNacimiento.Value,
                    Expiracion = dtp_FechaExp.Value,
                    Telefono = tbx_Telefono.Text,
                    Foto = pbx_Foto.ImageLocation,

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
                    civilian.Sexo = cb_Sexo.Text;
                    civilian.Nacimiento = dtp_FechaNacimiento.Value;
                    civilian.Expiracion = dtp_FechaExp.Value;
                    civilian.Telefono = tbx_Telefono.Text;
                    civilian.Foto = pbx_Foto.ImageLocation;
                }

            }

        civilianList.Add(civilian);

            json = JsonConvert.SerializeObject(civilianList);

            var sw = new StreamWriter(pathFile, false, Encoding.UTF8);
            sw.Write(json);
            sw.Close();

            MessageBox.Show("Registro Almacenado", "INTEC", MessageBoxButtons.OK, MessageBoxIcon.Information);


            gb_Cedula.Enabled = true;
            btn_Crear.Enabled = true;
            btn_Guardar.Enabled = false;
            btn_Cancelar.Enabled = true;
            btn_Actualizar.Enabled = false;
            btn_Borrar.Enabled = false;
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
            pbx_Foto.Image = null;
            dtp_FechaExp.Value = DateTime.Today;
            dtp_FechaNacimiento.Value = DateTime.Today;

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

        private void dgv_Civiles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            gb_Cedula.Enabled = true;
            if (e.RowIndex > -1)
            {
                var listado = (List<Civilian>)dgv_Civiles.DataSource;
                var objeto = (Civilian)listado[e.RowIndex];
                tbx_ID.Text = objeto.ID.ToString();
                tbx_Nombre.Text = objeto.Nombre.ToString();
                tbx_Apellido.Text = objeto.Apellido.ToString();
                tbx_Cedula.Text = objeto.Cedula.ToString();
                cb_TipoSangre.Text = objeto.Sangre.ToString();
                tbx_LugarNacimiento.Text = objeto.LugarNacimiento.ToString();
                cb_EstadoCivil.Text = objeto.EstadoCivil.ToString();
                tbx_Nacionalidad.Text = objeto.Nacionalidad.ToString();
                dtp_FechaNacimiento.Text = objeto.Nacimiento.ToString();
                dtp_FechaExp.Text = objeto.Expiracion.ToString();
                tbx_Telefono.Text = objeto.Telefono.ToString();
                cb_Sexo.Text = objeto.Sexo.ToString();
                pbx_Foto.ImageLocation = objeto.Foto.ToString();
            }


        }

        private void rbtn_Masculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            UpdateRecords();
            EmptyControls();

        }

        private void UpdateRecords()
        {
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Civilian.json";
            var json = String.Empty;
            var civilianList = new List<Civilian>();

            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                civilianList = JsonConvert.DeserializeObject<List<Civilian>>(json);

            }
            var objeto = civilianList.FirstOrDefault(x => x.ID.ToString() == tbx_ID.Text);
            civilianList[civilianList.IndexOf(objeto)].Nombre = tbx_Nombre.Text;
            civilianList[civilianList.IndexOf(objeto)].Apellido = tbx_Apellido.Text;
            civilianList[civilianList.IndexOf(objeto)].Cedula = tbx_Cedula.Text;
            civilianList[civilianList.IndexOf(objeto)].Sangre = cb_TipoSangre.Text;
            civilianList[civilianList.IndexOf(objeto)].LugarNacimiento = tbx_LugarNacimiento.Text;
            civilianList[civilianList.IndexOf(objeto)].EstadoCivil = cb_EstadoCivil.Text;
            civilianList[civilianList.IndexOf(objeto)].Nacionalidad = tbx_Nacionalidad.Text;
            civilianList[civilianList.IndexOf(objeto)].Nacimiento = dtp_FechaNacimiento.Value;
            civilianList[civilianList.IndexOf(objeto)].Expiracion = dtp_FechaExp.Value;
            civilianList[civilianList.IndexOf(objeto)].Telefono = tbx_Telefono.Text;
            civilianList[civilianList.IndexOf(objeto)].Sexo = cb_Sexo.Text;
            civilianList[civilianList.IndexOf(objeto)].Foto = pbx_Foto.ImageLocation;

            json = JsonConvert.SerializeObject(civilianList);
            var sw = new StreamWriter(pathFile, false, Encoding.UTF8);
            sw.Write(json);
            sw.Close();
            GetRecords();

            MessageBox.Show("Usuario Actualizado", "INTEC", MessageBoxButtons.OK, MessageBoxIcon.Information);


            gb_Cedula.Enabled = false;
            btn_Crear.Enabled = true;
            btn_Guardar.Enabled = false;
            btn_Cancelar.Enabled = true;
            btn_Actualizar.Enabled = true;
            btn_Borrar.Enabled = true;
        }

        private void btn_Borrar_Click(object sender, EventArgs e)
        {
            DeleteRecords();
            EmptyControls();
            GetRecords();
        }

        private void DeleteRecords()
        {
                var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Civilian.json";
                var json = String.Empty;
                var civilianList = new List<Civilian>();

                if (File.Exists(pathFile))
                {
                    json = File.ReadAllText(pathFile, Encoding.UTF8);
                    civilianList = JsonConvert.DeserializeObject<List<Civilian>>(json);

                }
                var objeto = civilianList.FirstOrDefault(x => x.ID.ToString() == tbx_ID.Text);
                civilianList.Remove(objeto);
                json = JsonConvert.SerializeObject(civilianList);
                var sw = new StreamWriter(pathFile, false, Encoding.UTF8);
                sw.Write(json);
                sw.Close();
                GetRecords();

            MessageBox.Show("Usuario Eliminado", "INTEC", MessageBoxButtons.OK, MessageBoxIcon.Information);


            gb_Cedula.Enabled = false;
            btn_Crear.Enabled = true;
            btn_Guardar.Enabled = false;
            btn_Cancelar.Enabled = true;
            btn_Actualizar.Enabled = true;
            btn_Borrar.Enabled = true;
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            GetRecords();
            gb_Cedula.Enabled = false;
            btn_Crear.Enabled = false;
            btn_Guardar.Enabled = false;
            btn_Cancelar.Enabled = true;
            btn_Actualizar.Enabled = true;
            btn_Borrar.Enabled = true;
            btn_Modificar.Enabled = false;
        }

        private void btn_SubirFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbx_Foto.ImageLocation = openFileDialog.FileName;
            }
        }
    }
    }
    
