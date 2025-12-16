namespace FINAL_CAR
{
    public class BookingRecord
    {
        public string CustomerName { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public string CarType { get; set; }
        public int RentedDays { get; set; }
        public string PickupDate { get; set; }
        public string PickupTime { get; set; }

        public decimal TotalAmount { get; set; }
        public string Status { get; set; }
    }
}
