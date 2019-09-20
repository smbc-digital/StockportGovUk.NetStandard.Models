using System;
using StockportGovUK.NetStandard.Models.Models.Verint;

namespace StockportGovUK.NetStandard.Models.Models.ComplimentsComplaints
{
    public class ComplaintDetails
    {
        public Guid Guid { get; set; }
        public string ComplainAbout { get; set; }

        public string CouncilDepartment { get; set; }

        public string CouncilDepartmentCouncilTax { get; set; }

        public string CouncilDepartmentPlanning { get; set; }
        
        public string CouncilDepartmentEnvironment { get; set; }

        public string OtherService { get; set; } 

        public string ComplainAboutService { get; set; }

        public string ComplainAboutDetails { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string EmailAddress { get; set; }

        public Address AddressFinder { get; set; }

        public string Complaint { get; set; }

        public string EventCode { get; set; }

        public string Name { get; set; }
    }
}
