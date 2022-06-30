using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio
{
    public partial class Form1 : Form
    {
        List<Civilian> Civiles = new List<Civilian>();
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
        }
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            Guardar();
            btn_Crear.Enabled = true;
            btn_Guardar.Enabled = true;
            btn_Cancelar.Enabled = false;
            gb_Cedula.Enabled = false;
        }
        private void Guardar()
        {


            var civilian = new Civilian
            {
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
                Foto = new Bitmap(pbx_Foto.Image)

            };
            Civiles.Add(civilian);

            MessageBox.Show("Civil Agregado");

            EmptyControls();
            ConseguirCIviles();

            btn_Crear.Enabled = true;
            btn_Guardar.Enabled = false;
            btn_Cancelar.Enabled = false;
            gb_Cedula.Enabled = false;

        }
        private void ConseguirCIviles()
        {
            dgv_Civiles.DataSource = null;
            dgv_Civiles.DataSource = Civiles;
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
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbx_Foto.Image = new Bitmap(openFileDialog.FileName);
            }
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

        private void cb_TipoSangre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pbx_Foto_Click(object sender, EventArgs e)
        {

        }
    }
    public class Civilian
    {
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Cedula { get; set; }
    public string Sangre { get; set; }
    public string LugarNacimiento { get; set; }
    public string EstadoCivil { get; set; }
    public string Nacionalidad { get; set; }
    public string Sexo{ get; set; }

    public DateTime Nacimiento { get; set; }
    public DateTime Expiracion { get; set; }

    public string Telefono { get; set; }
    public Image Foto { get; set; }
    }
}
