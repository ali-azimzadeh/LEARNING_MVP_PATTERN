using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_MVP_PATTERN.Models
{
    public class CircleModel : ICircleModel
    {
        public CircleModel() : base()
        {
        }
        public double GetArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
