using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Model
{
    public class Buyers
    {
       

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       
        public int BuyerId { get; set; }

        public string UserName { get; set; }

        public string Location { get; set; }

        public string EmailAddress { get; set; }  
        public string PhoneNumber { get; set; }

        public ICollection<Invoice> Invoices { get; set; }
    }

    public class Invoice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       
        public int InvoiceId { get; set; } 
        
        public DateTime PaymentDate { get; set; }

        public int BuyerId { get; set; }

        public PaymentType PymntType { get; set; }
        public decimal Amount { get; set; }


        [ForeignKey("BuyerId")]
        public Buyers Buyer { get; set; } 

    }

    public enum PaymentType
    {
        Cash,
        Transfer        
    }
}

  
    

