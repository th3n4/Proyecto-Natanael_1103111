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
    public partial class CreacionMusica : Form
    {
        NataMusicEntities1 db = new NataMusicEntities1();
        public CreacionMusica()
        {
            InitializeComponent();
        }

        private void txtGuardar_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            var musica = new Musics();
            musica.Titulo = txtTitulo.Text;
            musica.Artista = txtArtista.Text;
            musica.Album = txtAlbum.Text;
            musica.Fecha_Creación = dtpFechaMusica.Value;
            musica.Calificación = txtCalificacion.Text;
            musica.Genero = txtGenero.Text;
            musica.Fecha_Agregación = DateTime.Now;
            if (string.IsNullOrEmpty(txtGenero.Text) || string.IsNullOrEmpty(txtArtista.Text) || string.IsNullOrEmpty(txtGenero.Text))
            {
                MessageBox.Show("Faltan datos requeridos.");
                return;
            }


            db.Musics.Add(musica);
            var agregado = db.SaveChanges() > 0;
            if (agregado)
            {
                MessageBox.Show($"La musica {txtTitulo.Text} se ha agregado satisfactoriamente");
                ClearText();
            }
        }

        private void ClearText()
        {
            txtTitulo.Text = string.Empty;
            txtArtista.Text = string.Empty;
            txtAlbum.Text = string.Empty;
            txtGenero.Text = string.Empty;
            dtpFechaMusica.Value = DateTime.Now;
            txtCalificacion.Text = string.Empty;
        }

        private void txtCancelar_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
