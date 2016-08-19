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
/// 
/// Name : Dhrutiben Patel
/// Student Id : 300857555
/// Date : 19 August 2016
/// class name : GenerateNameForm
/// Githb : dhruti15
/// </summary>
namespace COMP123_S2016_FinalExam
{
    public partial class GenerateNameForm : Form
    {
        public GenerateNameForm()
        {
            InitializeComponent();

        }

        private void FirstNameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /*
       *@method : GenerateNames
       * @object : random
       *
       * setting character to string reprenstation
       *     
      */
        public void GenerateNames()
        {
            Random random = new Random();
            FirstNameListBox.SelectedIndex = random.Next(0, FirstNameListBox.Items.Count);
            LastNameListBox.SelectedIndex = random.Next(0, LastNameListBox.Items.Count);

            Program.character.FirstName = Convert.ToString(FirstNameListBox.SelectedItem);
            Program.character.LastName = Convert.ToString(LastNameListBox.SelectedItem);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateNames();
        }
        /*
       *@method : GenerateNameForm_Load
       * @call : Generate Names
       *     
      */
        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            GenerateNames();
        }
        /*
       *@method : NextButton_Click
       * @event : Hide and show
       *     
      */
        private void NextButton_Click(object sender, EventArgs e)
        {
            AbilityGeneratorForm form = new AbilityGeneratorForm();
            form.Show();
            this.Hide();
            

        }
    }
}
