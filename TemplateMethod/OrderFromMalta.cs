namespace TemplateMethod
{
    public class OrderFromMalta : Order
    {
        protected override void VatCalculation()
        {
            Vat = ExcludingTaxes * 0.18;
        }
    }
}