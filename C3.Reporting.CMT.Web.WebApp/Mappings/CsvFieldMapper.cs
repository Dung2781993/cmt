using C3.Reporting.CMT.Web.WebApp.Models;
using CsvHelper.Configuration;

namespace C3.Reporting.CMT.Web.WebApp.Mappings
{
    public sealed class CsvFieldMapper : CsvClassMap<UploadCustomerModel>
    {
        public CsvFieldMapper()
        {
            Map(m => m.CustomerSid).Name("Customer SID");
        }
    }
}