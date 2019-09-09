using StockportGovUK.NetStandard.Models.Models.Verint;

namespace StockportGovUK.NetStandard.Models.Models.ComplimentsComplaints
{
    public class ComplaintDetails
    {
        public string CouncilDepartment { get; set; }

        public string CouncilDepartmentOther { get; set; }

        public string CouncilDepartmentSub { get; set; }

        public string ComplaintType { get; set; }

        public string StaffName { get; set; }

        public string Complaint { get; set; }

        public string EventCode { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string EmailAddress { get; set; }

        public Address Address { get; set; }

    }
}
