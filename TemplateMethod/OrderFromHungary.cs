namespace TemplateMethod
{
    public class OrderFromHungary : Order
    {
        protected override void VatCalculation()
        {
            Vat = ExcludingTaxes * 0.27;
        }
    }
}