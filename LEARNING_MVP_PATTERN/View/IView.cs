using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_MVP_PATTERN.View
{
    public interface IView
    {
        string RadiusText { get; set; }
        string ResultText { get; set; }
    }
}
