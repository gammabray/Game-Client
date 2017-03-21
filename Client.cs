using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Client
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void l_gameTitle_Click(object sender, EventArgs e)
        {

        }

        private void b_loadGame_Click(object sender, EventArgs e)
        {


            this.Hide();
            LoadGame newWindow = new LoadGame();
            newWindow.ShowDialog();
            this.Show();



            
        }

        private void Client_Load(object sender, EventArgs e)
        { 
            b_newGame.Enabled = false;
           
        }

        private void b_newGame_Click(object sender, EventArgs e)
        {

        }

        private void b_highscores_Click(object sender, EventArgs e)
        {
            
            
                this.Hide();
                High_Scores newWindow = new High_Scores();
                newWindow.ShowDialog();
                this.Show();
            
           
        }

        

        private void b_Exit_Click(object sender, EventArgs e)
        {

        }
    }
}
