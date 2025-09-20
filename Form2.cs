using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBS
{
    public partial class Form2 : Form
    {
        private Client _c;
        private Room _r;
        private Reservation _res;
        public Form2(Client c, Room r, Reservation res)
        {
            InitializeComponent();
            _c = c;
            _r = r;
            _res = res;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            // Set text with emojis
            Info.Text =
                $"👤 Client Name: {_c.Name}\n" +
                $"📧 Email: {_c.Email}\n" +
                $"🏨 Room Number: {_r.Number}\n" +
                $"🛏️ Room Type: {_r.Type}\n" +
                $"📅 Check-In: {_res.CheckIn:dd/MM/yyyy}\n" +
                $"📅 Check-Out: {_res.CheckOut:dd/MM/yyyy}\n" +
                $"💰 Total Price: {_res.total}$";

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using our application! Goodbye! 👋");
            System.Environment.Exit(0);
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {


            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Fichier texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            saveFileDialog.FileName = "Facture.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Écrire le contenu du Label dans le fichier
                    System.IO.File.WriteAllText(saveFileDialog.FileName, Info.Text);
                    MessageBox.Show("Facture téléchargée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'enregistrement : " + ex.Message);
                }
            }
        }
    }
}
