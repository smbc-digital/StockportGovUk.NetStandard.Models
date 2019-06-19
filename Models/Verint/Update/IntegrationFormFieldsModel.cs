using System.Collections.Generic;

namespace StockportGovUK.NetStandard.Models.Models.Verint.Update
{
    public class IntegrationFormFieldsUpdateModel
    {
        public string CaseReference { get; set; }

        public string IntegrationFormName { get; set; }

        public List<IntegrationFormField> IntegrationFormFields { get; set; }
    }
}