using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApplication4
{
    internal class CSVReader
    {
        public void Read()
        {
            try
            {
                /*string inputClassAbbreviation = Console.ReadLine();
                string txtFilePath = string.Format(@"D:\Practice\Claim.csv",
                inputClassAbbreviation);*/

                //Console.WriteLine("Inside read function....");
                //var reader = new System.IO.StreamReader(File.OpenRead(string.Format(inputClassAbbreviation)));


                String filePath = @"D:\Practice\Claim.csv";
               // String inputClassAbbreviation = Console.ReadLine();
                var reader = new StreamReader(File.OpenRead(filePath));
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    string[] values = line.Split(',');
                    

                    ClaimValidator cv = new ClaimValidator();
                    Connection cnc = new Connection();
                    var ct = new Claimtable();
                    var array = new List<Claimtable>();

                    



                    if (values[2] != "Claim-Date")
                    {
                        //Console.WriteLine("Calling date validation");
                        String result = cv.ValidateClaimDate(values[2]);
                        //Console.WriteLine(result);
                        if (result == "Valid date")
                        {
                            if (values[3] != "")
                            {
                                String MBIResult = cv.ValidateMBI(values[3]);
                                if (MBIResult == "Valid")
                                {
                                    //Console.WriteLine("Calling email validation");
                                    String EmailResult = cv.ValidateEmail(values[4]);
                                    if (EmailResult == "Valid")
                                    {

                                        //Console.WriteLine(EmailResult);
                                        //Console.WriteLine("Calling connectora.." + values[4]);

                                        //cnc.Connectora(values[0], values[1], values[2], values[3], values[4]);
                                        ct.srno = Int32.Parse(values[0]);
                                        ct.claimid = Int32.Parse(values[1]);
                                        ct.claimdate = values[2];
                                        ct.mbi = Int32.Parse(values[3]);
                                        ct.email = values[4];
                                        array.Add(ct);
                                        //Console.WriteLine(ct.ToString());

                                    }
                                }
                            }
                        }
                    }
                        for(int i=0; i<array.Count; i++)
                          {
                            Console.WriteLine(array[i]);
                          }
                    cnc.Connectora(array);

                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }
}