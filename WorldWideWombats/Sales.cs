namespace WorldWideWombats
{
    /// <summary>
    /// Sales: Holds the Commision and GrossSales for a Sales Rep.
    /// </summary>
    public class Sales : Salary
    {
        public double Commission { get; set; }
        public double GrossSales { get; set; }

        public Sales()
        {

        }
    }
}