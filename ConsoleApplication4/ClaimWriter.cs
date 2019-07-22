//using Oracle.ManagedDataAccess.Client;
//using System;
//using System.Collections.Generic;
//using System.IO;

//namespace ConsoleApplication4
//{
//    internal class ClaimWriter
//    {
//            public void DatabaseQuery(String mbi)
//        {

//        //    try
//        //    {
//        //        String sql = "SELECT MBI from Claim_Menber";

//        //        OracleCommand command = new OracleCommand(sql, conn);
//        //        conn.Open();

//        //        OracleDataReader reader = command.ExecuteReader();
//        //        var cols = reader.FieldCount;


//        //        if (reader.HasRows)
//        //        {
//        //            while (reader.Read())
//        //            {
//        //                for (int i = 0; i < cols; i++)
//        //                {
//        //                    Console.WriteLine("\n{0}: {1}", reader.GetName(i), reader.GetValue(i));
//        //                }
//        //                // Console.WriteLine("\n{0}\t{1}\t{2}", reader.GetInt32(0),
//        //                //   reader.GetString(1), reader.GetString(2));
//        //            }
//        //        }
//        //        else
//        //        {
//        //            Console.WriteLine("No rows found.");
//        //        }
//        //        reader.Close();
//        //        //OracleCommand command;
//        //        //OracleDataAdapter adapter = new OracleDataAdapter();
//        //        //String sql = "insert into claim_menber(MBI,CLAIMDATE,CNAME) values(12345,'12-07-2019','Akash')";
//        //        //command = new OracleCommand(sql, conn);
//        //        //adapter.InsertCommand = new OracleCommand(sql, conn);
//        //        //adapter.InsertCommand.ExecuteNonQuery();
//        //        //Console.WriteLine("1 row inserted");

//        //        //command.Dispose(); 
//        //        conn.Close();
//        //    }
//        //    catch (Exception e)
//        //    {
//        //        Console.WriteLine(e);
//        //    }
//        //    Console.ReadLine();
//        //}

//        //public void Write(String Str1, String Str2, String Str3, String Str4, String Str5)
//        //{
//        //    //var csv = new StringBuilder();
//        //    string ClaimDetails = Str1 + "," + Str2 + "," + Str3 + "," + Str4 + "," + Str5;
//        //    List<string> newLines = new List<string>();
//        //    newLines.Add(ClaimDetails);
//        //    File.AppendAllLines(@"D:\Practice\ClaimToProcess2.csv", newLines);



//        /*csv.AppendLine(ClaimDetails);
//        File.WriteAllText(@"D:\Practice\ClaimToProcess.csv", csv.ToString());*/


//    }
//    }


