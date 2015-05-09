using System;

namespace Decorator
{
    public abstract class PhotoBookOptionDecorator : BasePhotoBook
    {
        protected BasePhotoBook Book;
        protected double OptionPrice;

        public override string Description
        {
            get { throw new NotImplementedException(); }
        }

        public override double Price
        {
            get { return Book.Price + OptionPrice; }
        }

        public PhotoBookOptionDecorator(BasePhotoBook book, double optionPrice)
        {
            Book = book;
            OptionPrice = optionPrice;
        }
    }
}
