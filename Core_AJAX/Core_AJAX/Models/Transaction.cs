using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Core_AJAX.Models
{
    public class Transaction
    {

        public Transaction()
        {
            Date = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is Required!")]
        [DisplayName("Account Number")]
        public string AccountNumber { get; set; } = string.Empty;

        [Required(ErrorMessage ="This field is Required!")]
        [DisplayName("Beneficiary Name")]
        public string BeneficiaryName { get; set; } = string.Empty;

        [Required(ErrorMessage = "This field is Required!")]
        [DisplayName("Bank Name")]
        public string BankName { get; set; } = string.Empty;

        [Required(ErrorMessage = "This field is Required!")]
        [DisplayName("SWIFT Code")]
        public string SWIFTCode { get; set; } = string.Empty;

        public int Amount { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Date { get; set; }
    }
}
