using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_MVP_PATTERN.Presenter
{
    public class CirclePresenter : Object
    {
        public CirclePresenter(View.IView view) : base()
        {
            View = view;
        }

        public View.IView View { get; set; }


        public string CalculateCircleArea()
        {
            Models.ICircleModel model =
                new Models.CircleModel();

            View.ResultText =
                model.GetArea(double.Parse(View.RadiusText)).ToString();

            return View.ResultText.ToString();
        }
    }
}
