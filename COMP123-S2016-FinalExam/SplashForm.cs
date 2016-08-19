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
/// Git Hub : Dhruti15
/// Class : Splash Form
/// 
/// </summary>
namespace COMP123_S2016_FinalExam
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {

        }
      /*
       *@method : Timer Click
       * @object : form
       *     
      */
        private void Timer_Tick(object sender, EventArgs e)
        {
            Timer.Enabled = false;
            this.Hide();
            GenerateNameForm form = new GenerateNameForm();
            form.Show();
        }
    }
}
