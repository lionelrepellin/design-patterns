namespace TemplateMethod
{
    public class OrderFromFrance : Order
    {
        protected override void VatCalculation()
        {
            Vat = ExcludingTaxes * 0.2;
        }
    }
}