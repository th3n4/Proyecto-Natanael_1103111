using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primer_Asunto
{
    public partial class MainForm : Form
    {
        NataMusicEntities1 db = new NataMusicEntities1();
        public MainForm()
        {
            InitializeComponent();

            GetRecords();
        }

        private void GetRecords()
        {
            var musica = db.Musics.ToList();
            if (!string.IsNullOrEmpty(txtTitulo.Text.ToUpper()))
            {
                musica = musica.Where(x=> x.Titulo.ToUpper().Contains(txtTitulo.Text.ToUpper())).ToList();
            }
            if (!string.IsNullOrEmpty(txtGenero.Text.ToUpper()))
            {
                musica = musica.Where(x => x.Genero.ToUpper().Contains(txtGenero.Text.ToUpper())).ToList();
            }
            if (!string.IsNullOrEmpty(txtArtista.Text.ToUpper()))
            {
                musica = musica.Where(x => x.Artista.ToUpper().Contains(txtArtista.Text.ToUpper())).ToList();
            }
            if (!string.IsNullOrEmpty(txtCalificacion.Text.ToUpper()))
            {
                musica = musica.Where(x => x.Calificación.ToUpper().Contains(txtCalificacion.Text.ToUpper())).ToList();
            }
            if (!string.IsNullOrEmpty(txtAlbum.Text.ToUpper()))
            {
                musica = musica.Where(x => x.Album.ToUpper().Contains(txtAlbum.Text.ToUpper())).ToList();
            }
            dataGridView1.DataSource = musica;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var VeteA = new CreacionMusica();
            VeteA.Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtCalificacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGenero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAlbum_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtFechaMusica_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtArtista_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetRecords();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtpFechaMusica_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
