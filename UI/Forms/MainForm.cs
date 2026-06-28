using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToeGame.UI.Forms;

namespace TicTacToeGame
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayForm playForm = new PlayForm();
            playForm.ShowDialog();
            this.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


    }
}
