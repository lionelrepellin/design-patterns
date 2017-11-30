using System;

namespace Decorator
{
    public class GlossCoverOption : PhotoBookOptionDecorator
    {
        public GlossCoverOption(BasePhotoBook book, double optionPrice)
            : base(book, optionPrice)
        {
        }

        public override string Description
        {
            get
            {
                return Book.Description + "- with a gloss-finish cover => " + Book.Price + " + " + OptionPrice + " = " + Price + " Euros" + Environment.NewLine;
            }
        }
    }
}