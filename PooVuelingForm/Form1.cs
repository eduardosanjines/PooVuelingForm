using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PooVuelingForm
{
    public partial class Form1 : Form, IAlumno
    {
        Alumno alumno = new Alumno();
        public Form1()
        {
            InitializeComponent();
        }

        public string Add(Alumno alumno)
        {
            string curFile = @".\Alumno.json";
            string output = JsonConvert.SerializeObject(alumno);
            Alumno deserializedProduct = JsonConvert.DeserializeObject<Alumno>(output);

            if (File.Exists(curFile))
                Console.WriteLine(File.Exists(curFile) ? "File exists." : "File does not exist.");
            else
            { 
                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter("Alumno.json"))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {

                serializer.Serialize(writer, alumno);

                }
            }
            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            alumno.id = textID.Text;
            alumno.nombre = textNom.Text;
            alumno.apellido = textApellido.Text;
            alumno.dni = textDNI.Text;

            Add(alumno);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDNI_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
