using System;

namespace Decorator
{
    public class ModernPhotoBook : BasePhotoBook
    {
        public override string Description
        {
            get { return "Modern photo book" + Environment.NewLine; }
        }

        public override double Price
        {
            get { return 30.95; }
        }
    }
}