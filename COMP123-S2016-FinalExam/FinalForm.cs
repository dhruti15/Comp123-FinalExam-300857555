using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Name : Dhruti Ben Patel
/// Student Id : 300857555
/// Github : dhruti15
/// 
/// class name : Final Formss
/// 
/// </summary>
namespace COMP123_S2016_FinalExam
{
    public partial class FinalForm : Form
    {
        public RaceAndClassForm previousForm { get; set; }

        public FinalForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Step 1 - instantiate an object of the AboutBox form
            AboutBox aboutBox = new AboutBox();

            // Step 2 - use the ShowDialog method of the aboutbox
            aboutBox.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FinalForm_Load(object sender, EventArgs e)
        {
            StrengthTextBox.Text = Program.character.Strength.ToString();
            DexterityTextBox.Text = Program.character.Strength.ToString();
            ConstitutionTextBox.Text = Program.character.Strength.ToString();
            IntelligenceTextBox.Text = Program.character.Strength.ToString();
            WisdomTextBox.Text = Program.character.Strength.ToString();
            CharismaTextBox.Text = Program.character.Strength.ToString();
            RaceLabel.Text = Program.character.Strength.ToString();
            FirstNameLabel2.Text = Program.character.Strength.ToString();
            LastNameTextBox.Text = Program.character.Strength.ToString();
            
        }
    }
}
