using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Client
{
    public partial class High_Scores : Form
    {
        public High_Scores()
        {
            InitializeComponent();
           
        }
        

        private void High_Scores_Load(object sender, EventArgs e)
        {
            highScoresTable.Hide();
           //The below is to make sure the user cannot add/edit any entries
            highScoresTable.AllowUserToResizeColumns = false;
            highScoresTable.AllowUserToResizeRows = false;
            highScoresTable.AllowDrop = false;
            highScoresTable.AllowUserToOrderColumns = false;
            highScoresTable.AllowUserToAddRows = false;
            highScoresTable.AllowUserToDeleteRows = false;
        }
        private void High_Scores_Closing(object sender, EventArgs e)
        {
            //not initially in view
            highScoresTable.Hide();
        }
        private DataTable loadTable(string query)
            ///<summary>
            ///Creates a new DataTable object based on the given SELECT query
            ///<param name="query">
            ///The SQL query used to filter the data returned
            /// </param>
            /// </summary>
        {
            DataTable table = new DataTable();
            string connstring =
                @"Provider=Microsoft.ACE.OLEDB.12.0;Data" //How the data will be accessed
                + @" Source= ..\..\profiles.accdb"; //Filepath
            string tableName = "TBL_SCORES";
           
            DataSet data = new DataSet();
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, connection);//return data matching query
                dataAdapter.Fill(data, tableName);//add data to dataset
                
                table = data.Tables[0];//return first table (only one in this case)
        
               

             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }finally
            {
                connection.Close();
            }

            return table;
        }

        private void b_loadHighScores_Click(object sender, EventArgs e)
        {
            var hsTable = loadTable("select UserName,Score1,Time1 from TBL_SCORES");
            highScoresTable.DataSource = hsTable;
            hsTable.Columns["Time1"].ColumnName = "Time (s)";
            hsTable.Columns["Score1"].ColumnName = "Score for Level 1";
            highScoresTable.Show();
            highScoresTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;//Fit size of data
            highScoresTable.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;//Fit size of data
            highScoresTable.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//Formatting so fills rest of width of DataGridView


        }

        private void b_Find_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(t_SearchUser.Text))//string is blank
            {
                MessageBox.Show("Please enter a Username in the search box","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
               try
                {
                    var userTable = loadTable("select * from TBL_SCORES where UserName ='" + t_SearchUser.Text + "'");
                    if(userTable == null || userTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Name not found in database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    highScoresTable.DataSource = userTable;
                    foreach(DataGridViewColumn dc in highScoresTable.Columns)
                    {
                        dc.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells; //always correctly format cells                        
                    }
                    
                    highScoresTable.Show();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              
            }

        }
         
    }
}
