using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRMDesktopUI.Library.Helpers
{
    public class ConfigHelper : IConfigHelper
    {
        //TODO: move this from config to the API
        public decimal GetTaxRate()
        {
            string rateText = ConfigurationManager.AppSettings["taxRate"];

            bool isValidTaxRate = Decimal.TryParse(rateText, out decimal output);

            if (isValidTaxRate == false)
            {
                throw new ConfigurationErrorsException("Tax rate is not working correctly");
            }

            return output;
        }
    }
}
