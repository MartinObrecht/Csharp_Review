using System.Globalization;

namespace Interfaces.Entities
{
    class Invoice
    {
        public double BasciPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basciPayment, double tax)
        {
            BasciPayment = basciPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasciPayment + Tax; }
        }

        public override string ToString()
        {
            return "Basic Paymente: "
                + BasciPayment.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTax: "
                + Tax.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotal Payment: "
                + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
