namespace ConsoleApplication4
{
    internal class Claimtable
    {
        public int srno { get; set; }
        public int claimid { get; set; }
        public string claimdate { get; set; }
        public int mbi { get; set; }
        public string email { get; set; }

        public override string ToString()
        {
            return "Claimtable: " + srno + " " + claimid + " " + claimdate + " " + mbi + " " + email;
        }
    }
}