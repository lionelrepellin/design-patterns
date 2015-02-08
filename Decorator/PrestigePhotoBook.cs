using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class PrestigePhotoBook : BasePhotoBook
    {
        public override string Description
        {
            get { return "Prestige photo book" + Environment.NewLine; }
        }

        public override double Price
        {
            get { return 29.95; }
        }
    }
}
