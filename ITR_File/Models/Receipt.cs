namespace ITR_File.Models
{
    public class Receipt
    {
        public int Id { get; set; }
        public string PAN_Number { get; set; }

        public decimal PayableTax { get; set; }
        public decimal CalculatedTax { get; set; }

        public decimal EducationCess { get; set; }

    }
}
