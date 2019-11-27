using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEjerciciosBucles
{
    public partial class frmNotasE : Form
    {
        public frmNotasE()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            long nota = notas();
        }

        private long notas()
        {

            Random r = new Random();//generar números aleatorios
            this.LstNotas.Items.Clear(); //vaciar lista
            this.LstNotas.Sorted = false;
            long suma = 0, promedio = 0;
            for (int i = 0; i< 30; i++)
            {
                int num = r.Next(20, 50);
                this.LstNotas.Items.Add(num);
                suma = suma + num;
            }
            promedio = suma / 30;
            this.txtPromedio.Text = promedio.ToString();
            this.txtSuma.Text = suma.ToString();
            return 0;
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            this.LstNotas.Sorted = true;
        }
        
    }
}
