using System;

namespace Decorator
{
    public class RibbonOption : PhotoBookOptionDecorator
    {
        public RibbonOption(BasePhotoBook book, double optionPrice)
            : base(book, optionPrice)
        {
        }

        public override string Description
        {
            get
            {
                return Book.Description + "- with a ribbon => " + Book.Price + " + " + OptionPrice + " = " + Price + " Euros" + Environment.NewLine;
            }
        }
    }
}