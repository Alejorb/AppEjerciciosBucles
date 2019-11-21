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
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }

        private long btnCalcular_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            this.LstNotas.Items.Clear(); //vaciar lista
            long suma=0, promedio=0;
            for (int i = 0; i < 30; i++)
            {
                int num = r.Next(20, 50);
                this.LstNotas.Items.Add(num);
                suma = suma + num;
                promedio = suma / 30;
            }
            suma=int.Parse
            return suma;
        }
    }
}
