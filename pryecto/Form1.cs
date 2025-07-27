using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

namespace pryecto
{
    public partial class Form1 : Form
    {

        //creamos la ruta de donde se almacenaran todas las canciones
        string ruta = "canciones.txt";
        //creamos la ruta donde se pondra las canciones para pinchar
        string admin = "admin.txt";
      
        public Form1()
        {
            InitializeComponent();

                                                                //pasar el contenido del txt a una listbox

            
            //creamos un lector que nos permitira leer linea a linea poniendo el contenido que encuentre en la listbox
         using (StreamReader lector = new StreamReader(ruta,true))
            {
                //creamos la variable que almacenara el contenido que encuentre lector
                //creamos un bucle que almacenara lo que encuentre lector en contenido, leyendo todas las lineas escritas
                string contenido;
                while ((contenido = lector.ReadLine()) != null) 
                {
                listcanciones.Items.Add(contenido);
                }
            }
        }



        public void btnenviar_Click(object sender, EventArgs e)
        {
                                             //pasar el contenido de una textbox a un txt-pasar el contenido del txt a una listbox


            //creamos un escritor que recogera el texto de la textbox y lo almacenara en el documento
            using (StreamWriter escritor = new StreamWriter(ruta,true))
            {
                escritor.WriteLine(txtcancion.Text);
            }
            
            //ponemos la textbox vacia
            txtcancion.Text = "";
         
            //vaciamos la lista para que no se duplique el contenido
            listcanciones.Items.Clear();
           
            //creamos la variable que almacenara el contenido que encuentre lector
            //creamos un bucle que almacenara lo que encuentre lector en contenido, leyendo todas las lineas escritas
            using (StreamReader lector = new StreamReader(ruta, true))
            {
                string contenido;
                while ((contenido = lector.ReadLine()) != null)
                {
                    listcanciones.Items.Add(contenido);
                }
            }




        }

        private void listcanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            //obtenemos la cancion 
            string cancionlista = listcanciones.Text;

            //mostramos una messagebox que almacenara el resultado (yes-no) en resultado, preguntando si es correcta la cancion
            DialogResult resultado = MessageBox.Show(
            "quieres que suene "+ cancionlista+"?",
            cancionlista,
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );


            //escribimos la cancion en un txt a parte que lo podra ver el administrador del programa
            if (resultado == DialogResult.Yes)
            {
                using (StreamWriter escritor = new StreamWriter(admin,true))
                {
                   escritor.WriteLine(cancionlista);
                }

                MessageBox.Show("Gracias, nos aseguramos de poner tu cancion");

            }

        }
    }
}
