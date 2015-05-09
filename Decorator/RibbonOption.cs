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
                return Book.Description + "- with a ribbon => " + this.Book.Price + " + " + this.OptionPrice + " = " + this.Price + " Euros" + Environment.NewLine;
            }
        }
    }
}