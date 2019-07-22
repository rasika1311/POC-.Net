//using Oracle.DataAccess.Client;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication4
{

    internal class Connection
    {
        public void Connectora(List<Claimtable> validlist)
        {
            
            string oradb = "Data Source=(DESCRIPTION =" +
                    "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
                    "(CONNECT_DATA =" + "(SERVER = DEDICATED)" +
                    "(SERVICE_NAME = orcl)));" + "User Id= testdb;Password=test;";
            OracleConnection conn = new OracleConnection(oradb);


            Console.Write("Connected to Oracle\n");
            //ClaimWriter cw = new ClaimWriter();
           
            
                String sql = "SELECT MBI from Claim_Menber";

                OracleCommand command = new OracleCommand(sql, conn);
                conn.Open();

                OracleDataReader reader = command.ExecuteReader();
                var cols = reader.FieldCount;
           
               // Console.WriteLine(tablembi);
                ArrayList tableList = new ArrayList();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    for (int i = 0; i < cols; i++)
                    {
                        int tablembi = Int32.Parse(reader.GetValue(i).ToString());
                        tableList.Add(tablembi);
                    }
                    
                }
            }
            
            else
            {
                Console.WriteLine("No rows found.");
            }
            //for (int j = 0; j < validlist.Count; j++)
            //{
            //    Console.WriteLine("From Array : " + validlist[j].srno);
            //}

            for (int j = 0; j < validlist.Count; j++)
            {

                if (tableList.Contains(validlist[j].mbi))
                {
                    
                    OracleDataAdapter adapter = new OracleDataAdapter();
                    int srno = validlist[j].srno;
                    int claimid = validlist[j].claimid;
                    String claimdate = validlist[j].claimdate;
                    int mbi = validlist[j].mbi;
                    String email = validlist[j].email;
                    String sql1 = "insert into claim(srno,claimid,claimdate,MBI,Email) values(" + srno + "," + claimid + ",'" + claimdate + "'," + mbi + ",'" + email + "')";
                    Console.WriteLine(sql1);
                    OracleCommand command1 = new OracleCommand(sql1, conn);
                    adapter.InsertCommand = new OracleCommand(sql1, conn);
                    try
                    {
                        adapter.InsertCommand.ExecuteNonQuery();
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    Console.WriteLine("1 row inserted");
                    command.Dispose();
                }
            }

            conn.Close();
    }
   }
 }
            


