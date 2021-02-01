using System;
using System.Collections.Generic;

namespace TaxDictionary
{
    public class TaxBracket
    {
        public static Dictionary<string, double> TaxBrackets() 
        {
            var taxes = new Dictionary<string, double>();
            taxes.Add("AL", GetTaxNum());
            taxes.Add("AK", GetTaxNum());
            taxes.Add("AZ", GetTaxNum());
            taxes.Add("AR", GetTaxNum());
            taxes.Add("CA", GetTaxNum());
            taxes.Add("CO", GetTaxNum());
            taxes.Add("CT", GetTaxNum());
            taxes.Add("DE", GetTaxNum());
            taxes.Add("DC", GetTaxNum());
            taxes.Add("FL", GetTaxNum());
            taxes.Add("GA", GetTaxNum());
            taxes.Add("HI", GetTaxNum());
            taxes.Add("ID", GetTaxNum());
            taxes.Add("IL", GetTaxNum());
            taxes.Add("IN", GetTaxNum());
            taxes.Add("IA", GetTaxNum());
            taxes.Add("KS", GetTaxNum());
            taxes.Add("KY", GetTaxNum());
            taxes.Add("LA", GetTaxNum());
            taxes.Add("ME", GetTaxNum());
            taxes.Add("MD", GetTaxNum());
            taxes.Add("MA", GetTaxNum());
            taxes.Add("MI", GetTaxNum());
            taxes.Add("MN", GetTaxNum());
            taxes.Add("MS", GetTaxNum());
            taxes.Add("MO", GetTaxNum());
            taxes.Add("MT", GetTaxNum());
            taxes.Add("NE", GetTaxNum());
            taxes.Add("NV", GetTaxNum());
            taxes.Add("NH", GetTaxNum());
            taxes.Add("NJ", GetTaxNum());
            taxes.Add("NM", GetTaxNum());
            taxes.Add("NY", GetTaxNum());
            taxes.Add("NC", GetTaxNum());
            taxes.Add("ND", GetTaxNum());
            taxes.Add("OH", GetTaxNum());
            taxes.Add("OK", GetTaxNum());
            taxes.Add("OR", GetTaxNum());
            taxes.Add("PA", GetTaxNum());
            taxes.Add("RI", GetTaxNum());
            taxes.Add("SC", GetTaxNum());
            taxes.Add("SD", GetTaxNum());
            taxes.Add("TN", GetTaxNum());
            taxes.Add("TX", GetTaxNum());
            taxes.Add("UT", GetTaxNum());
            taxes.Add("VT", GetTaxNum());
            taxes.Add("VA", GetTaxNum());
            taxes.Add("WA", GetTaxNum());
            taxes.Add("WV", GetTaxNum());
            taxes.Add("WI", GetTaxNum());
            taxes.Add("WY", GetTaxNum());

            return taxes;
        }
        public static double GetTaxNum()
        {
            Random rand = new Random();
            return rand.Next(8) * .01;
        }
    }
}
