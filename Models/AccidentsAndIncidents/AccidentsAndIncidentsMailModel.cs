using StockportGovUK.NetStandard.Models.Mail;

namespace StockportGovUK.NetStandard.Models.AccidentsAndIncidents
{
   public  class AccidentsAndIncidentsMailModel : BaseMailModel
   {
       public string FirstName { get; set; }

       public string LastName { get; set; }

       public string Reference { get; set; }
   }
}
