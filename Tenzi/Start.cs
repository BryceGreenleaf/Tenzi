using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tenzi
{
    public partial class Start : Form
    {

        private int counter;

        public Start()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of the SelectPlayers form
            SelectPlayers selectPlayersForm = new SelectPlayers();

            // Show the SelectPlayers form
            selectPlayersForm.Show();

            // Optionally, hide or close the current form
            this.Hide(); // or this.Close() to close the current form
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }
    }
}
