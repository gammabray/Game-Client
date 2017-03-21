using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;

namespace Client
{
    public partial class LoadGame : Form
    {
        int currentLevel;
        public LoadGame()
        {
            InitializeComponent();
            currentLevel = 1;
            
        }
        private void changeImageBox(int level)
        {
            string filepath = "";
            switch (level)
            {
                case 1:
                    break;
                case 2:
                    filepath = @"..\..\level2.png";
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                default:
                    filepath = "";
                    break;
            }
            Image levelImage = Image.FromFile(filepath);
            pb_levelPreview.Image = levelImage;
        }
       
     

       

        private void LoadGame_Load(object sender, EventArgs e)
        {
            cb_selectLevel.Items.Add("Level 1");
            cb_selectLevel.Items.Add("Level 2");
            cb_selectLevel.Items.Add("Level 3");
            cb_selectLevel.Items.Add("Level 4");
            cb_selectLevel.Items.Add("Level 5");
            cb_selectLevel.Items.Add("Level 6");
            cb_selectLevel.Items.Add("Level 7");
            cb_selectLevel.Items.Add("Level 8");
        }

      

        private void b_loadLevel_Click(object sender, EventArgs e)
        {
            //Create a new process to execute the game
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = @"C:\Users\James Bray\Documents\Visual Studio 2015\Projects\mario cplus school\Release\Game.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.Arguments = currentLevel.ToString();
            process.StartInfo.WorkingDirectory = @"C:\Users\James Bray\Documents\Visual Studio 2015\Projects\mario cplus school\mario cplus";
            process.Start();
            process.WaitForExit();
        }

        private void cb_selectLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                currentLevel = int.Parse(((string)(cb_selectLevel.SelectedItem))[6].ToString());
                changeImageBox(currentLevel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Unable to change level: Exception \"{0}\" was unhandled ", ex.Message),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
        }

        private void l_bestTimeValue_Click(object sender, EventArgs e)
        {

        }

        private void l_bestScoreValue_Click(object sender, EventArgs e)
        {

        }
    }
}
