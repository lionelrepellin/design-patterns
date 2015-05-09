using System;

namespace Decorator
{
    public class GlossPaperOption : PhotoBookOptionDecorator
    {
        public GlossPaperOption(BasePhotoBook book, double optionPrice)
            : base(book, optionPrice)
        {
        }

        public override string Description
        {
            get
            {
                return Book.Description + "- with gloss paper => " + this.Book.Price + " + " + this.OptionPrice + " = " + this.Price + " Euros" + Environment.NewLine;
            }
        }
    }
}