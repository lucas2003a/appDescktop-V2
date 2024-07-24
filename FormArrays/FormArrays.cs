using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appDescktop_V2.FormArrays
{
    public partial class FormArrays : Form
    {
        public FormArrays()
        {
            InitializeComponent();
        }

        private void FormArrays_Load(object sender, EventArgs e)
        {
            //initializeArrayType1();
            //initializeArrayType2();
            IterateOverCourses();
        }

        private void initializeArrayType1()
        {
            string[] courses = new string[5]; //Cantidad de elementos del array

            try
            {
                //Agregando elementos
                courses[0] = "HTML";
                courses[1] = "CSS";
                courses[2] = "JavaScript";
                courses[3] = "Python";
                courses[4] = "PHP";
                //courses[5] = "C#"; //Esto lanzará una excepción ya que al inicializar el array indicamos que solo contendría 5 elementos

                LiCourses.Items.Clear(); //Limpia la lista

                LiCourses.Items.Add(courses[0]);
                LiCourses.Items.Add(courses[1]);
                LiCourses.Items.Add(courses[2]);
                LiCourses.Items.Add(courses[3]);
                LiCourses.Items.Add(courses[4]);
                //LiCourses.Items.Add(courses[5]);

            }
            catch(Exception error)
            {
                MessageBox.Show($"{error.Message}","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        } 
        private void initializeArrayType2()
        {
            string[] courses = {"HTML", "CSS", "JavaScript", "Python", "PHP"}; //Agregamos los elementos de forma directa

            try
            {
                LiCourses.Items.Clear(); //Limpia la lista

                LiCourses.Items.Add(courses[0]);
                LiCourses.Items.Add(courses[1]);
                LiCourses.Items.Add(courses[2]);
                LiCourses.Items.Add(courses[3]);
                LiCourses.Items.Add(courses[4]);
                //LiCourses.Items.Add(courses[5]);

            }
            catch(Exception error)
            {
                MessageBox.Show($"{error.Message}","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        //Renderiza la lista de courses con un bucle for
        private void IterateOverCourses()
        {
            string[] courses =
            {
                "HTML", 
                "CSS", 
                "JavaScript", 
                "Python", 
                "PHP"
            };

            LiCourses.Items.Clear();

            //El primer indice de un array inicia en 0, por lo tanto nuestro contador también
            for (int i = 0; i < courses.Length; i++)
            {
                LiCourses.Items.Add(courses[i]);
            }
        }
    }
}
