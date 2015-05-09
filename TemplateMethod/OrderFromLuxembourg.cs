namespace TemplateMethod
{
    public class OrderFromLuxembourg : Order
    {
        protected override void VatCalculation()
        {
            Vat = ExcludingTaxes * 0.17;
        }
    }
}