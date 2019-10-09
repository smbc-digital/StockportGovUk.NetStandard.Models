using StockportGovUK.NetStandard.Models.Models.Mail;

namespace StockportGovUK.NetStandard.Models.Models.ComplimentsComplaints
{
   public  class ComplaintsMailModel : BaseMailModel
   {
       public string FirstName { get; set; }

       public string LastName { get; set; }

       public string Reference { get; set; }
   }
}
