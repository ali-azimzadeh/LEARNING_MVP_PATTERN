using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEARNING_MVP_PATTERN.View
{
    public partial class SampleForm : Form, IView
    {
        public SampleForm()
        {
            InitializeComponent();
        }

        public string RadiusText
        {
            get
            {
                return radiusTextBox.Text; 
            }
            set 
            {
                radiusTextBox.Text = value; 
            }
        }
        public string ResultText
        {
            get
            {
                return resultLabel.Text; 
            }
            set 
            {
                resultLabel.Text = value; 
            }
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            //Solution1
            //var circleModel = 
            //    new Models.CircleModel();

            //resultLabel.Text = 
            //    circleModel.GetArea(
            //        radius: double.Parse(radiusTextBox.Text))
            //    .ToString();
            //Solution1

            //Solution2

            var circlePresenter =
                new Presenter.CirclePresenter(this);

            circlePresenter.CalculateCircleArea();

            //Solution1

        }
    }
}
