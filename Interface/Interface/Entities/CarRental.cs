

namespace Interface.Entities
{
    class CarRental
    {
        public DateTime start { get; set; }
        public DateTime Finish { get; set; }
        public Vehicle Vehicle { get; set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime start, DateTime finish, Vehicle vehicle)
        {
            this.start = start;
            Finish = finish;
            Vehicle = vehicle;
            Invoice = null;
        }
    }
}
