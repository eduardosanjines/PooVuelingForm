using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;
using System.Windows.Forms;

namespace PooVuelingForm
{
    public partial class Form1 : Form, IAlumno
    {
        Alumno alumno = new Alumno();
        //IAlumno iAlumno;
        JavaScriptSerializer ser = new JavaScriptSerializer();
                
        public Form1()
        {
            InitializeComponent();
        }

        public string Add(Alumno alumno)
        {
            string outputJSON = ser.Serialize(alumno);
            File.WriteAllText("Alumno.json", outputJSON);

           // Console.WriteLine(alumno.ToString());
           // Console.ReadLine();

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
