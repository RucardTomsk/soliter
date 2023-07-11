using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soliter
{
    public partial class EndGame : Form
    {
        DateTime date;
        string userName;
        Game game;
        public EndGame(DateTime date, string userName, Game game)
        {
            InitializeComponent();

            this.date = date;
            this.userName = userName;

            labelName.Text = userName + ", ваше время " + date.ToString("mm:ss");
            this.game = game;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(@"record.txt", true);
            writer.WriteLine(userName + "," + date.ToString("mm:ss") + ";");
            writer.Close();
            Menu formMenu = new Menu();
            formMenu.Show();
            this.Close();
            game.Close();
        }
    }
}
