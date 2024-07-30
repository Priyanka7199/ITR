using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace ITR_File.Models
{
    public class FormDetails
    {
        public int FormNumber { get; set; }

        [Key]
        public string PAN_Number { get; set; }

        public string Details { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
    [XmlRoot("FormDetails")]
    public class FormDetailsXML
    {
        public ProfileInfo ProfileInfo { get; set; }

        public IncomeInfo IncomeInfo { get; set; }


    }
}
