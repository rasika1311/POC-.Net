using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ConsoleApplication4
{
    internal class ClaimValidator
    {
        public String ValidateClaimDate(String InputDate)
        {
            String result = null;

            DateTime fromDate = DateTime.Now;
            fromDate = fromDate.Date;
            DateTime IDate = DateTime.Parse(InputDate);
            //String Currentdate = fromDate.ToString("d/M/yyyy");

            int value = DateTime.Compare(IDate, fromDate);

            // checking 
            if (value > 0)
                result = "Invalid date";
            else if (value < 0)
                result = "Valid date";
            else
                result = "Both are same";


            return result;
        }   
        public String ValidateEmail(String EmailResult)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(EmailResult);
            if (match.Success)
                EmailResult = "Valid";
            else
                EmailResult = "Invalid";
            return EmailResult;
        }
        public String ValidateMBI(String InputMBI)
        {
            String MBIResult = null;
            Regex regex = new Regex(@"^\d+$");
            Match match = regex.Match(InputMBI);
            if (match.Success)
                MBIResult = "Valid";
            else
                MBIResult = "Invalid";
            return MBIResult;
        }

    }
}