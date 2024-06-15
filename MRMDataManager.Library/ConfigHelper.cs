using System;
using System.Configuration;

namespace MRMDataManager.Library
{
    public class ConfigHelper
    {
        //TODO: move this from config to the API
        public static decimal GetTaxRate()
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