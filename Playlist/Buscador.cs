using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playlist
{
    public partial class Buscador : Form
    {
        public Buscador()
        {
            InitializeComponent();
        }
        

        private void hacerBusqueda_Click(object sender, EventArgs e)
        {
           
            string data = busqueda.Text;




            busqueda.Text = "";
        }
    }
}
