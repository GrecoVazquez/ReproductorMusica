using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Playlist
{
    public partial class Form1 : Form
    {
        string [] listCanciones = new string [16];
        string[] infoData = new string[8];
        WindowsMediaPlayer wplayer = new WindowsMediaPlayer();
        int contador = 0;
        public void ListCanciones()
        {        
            //Canciones
            listCanciones[0] = "Tu sin mi";
            listCanciones[2] = "Pumped up";
            listCanciones[4] = "We are young";
            listCanciones[6] = "Lost";
            listCanciones[8] = "Asi fue";
            listCanciones[10] = "Ghetto music";
            listCanciones[12] = "Te amo";
            listCanciones[14] = "Fue en un cafe";
            //Duracion
            listCanciones[1] = "03:25";
            listCanciones[3] = "02:48";
            listCanciones[5] = "03:52";
            listCanciones[7] = "04:14";
            listCanciones[9] = "02:28";
            listCanciones[11] = "04:58";
            listCanciones[13] = "01:55";
            listCanciones[15] = "02:37";
        }
        public Form1()
        {
            InitializeComponent();
            cargarCanciones();           
            Inicio.Enabled = false;
            Anterior.Enabled = false;
            Canciones.SelectedIndex = 0;        
            metadatos();
        }

        public void cargarCanciones()
        {
            ListCanciones();
            foreach (string cancion in listCanciones)
            {
                Canciones.Items.Add(cancion);                                                              
            }          
        }
        
        public void metadatos()
        {

            infoData[0] = "Tu sin mi - Dread Mar I - Gira internacional";
            infoData[1] = "Pumped up - Foster the people - xx años";
            infoData[2] = "We are young - Fun  - sad\n";
            infoData[3] = "Lost -  Gorillaz - Tour mexico\n";
            infoData[4] = "Asi fue - Dread Mar I - se fue\n";
            infoData[5] = "Ghetto music - liquits - Gira internacional\n";
            infoData[6] = "Te amo -  Franco de vita - Love\n";
            infoData[7] = "Fue en un cafe - Acurrucar - Fresca vida\n";

          //  String lst = Canciones.GetItemText(Canciones.SelectedItem);
            for (int i = 0; i < 8; i++)
            {
                if (infoData[i].Contains(Canciones.GetItemText(Canciones.SelectedItem)))
                {
                    Metadatos1.Text = infoData[i];
                }
            }
            
        }     

            public void cancionInicio()
        {
            Canciones.SelectedIndex = 0;
            metadatos();
            Inicio.Enabled = false;
            Anterior.Enabled = false;
            Siguiente.Enabled = true;
            contador = 0;

        }

        public void cancionAnterior()
        {
            Canciones.SelectedIndex = contador - 2;
            contador = contador - 2;
            metadatos();
            if (contador == 0)
            {
                Inicio.Enabled = false;
                Anterior.Enabled = false;
                Siguiente.Enabled = true;
                Fin.Enabled = true;
            }

        }
        public void cancionSiguiente()
        {
            Inicio.Enabled = true;
            Anterior.Enabled = true;

            //contador = Convert.ToInt32(Canciones.GetItemText(Canciones.Items.Count));           
            Canciones.SelectedIndex = contador + 2;
            contador = contador + 2;                
            metadatos();
            if (contador == 14)
            {
                Siguiente.Enabled = false;
                Fin.Enabled = false;
            }

        }

        public void cancionFin()
        {
            Canciones.SelectedIndex = Canciones.Items.Count - 2;
            metadatos();
            Siguiente.Enabled = false;
            Inicio.Enabled = true;
            Anterior.Enabled = true;
            contador = 14;
        }



        private void Inicio_Click(object sender, EventArgs e)
        {
            cancionInicio();
        }

        private void Anterior_Click(object sender, EventArgs e)
        {
            cancionAnterior();
        }

        private void Siguiente_Click(object sender, EventArgs e)
        {
            cancionSiguiente();
        }

        private void Fin_Click(object sender, EventArgs e)
        {
            cancionFin();
        }        
        public void reproduccion()
        {
            string rola = Canciones.GetItemText(Canciones.SelectedItem);
            wplayer.URL = @"E:\Playlist\Music\" + rola + ".mp3";
        }
        bool bandera=true;
        private void button1_Click(object sender, EventArgs e)
        {
            if (bandera == false)
            {
                wplayer.controls.play();
            }
            else
            {
                reproduccion();
                wplayer.controls.play();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
                bandera = false;
                wplayer.controls.pause();                   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            wplayer.controls.stop();
        }

        private void buscaCanciones_Click(object sender, EventArgs e)
        {
            Buscador search = new Buscador();
            search.Visible = true;
        }
    }
}
