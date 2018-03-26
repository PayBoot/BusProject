namespace DataLibrary.Models
{
    public class TbBus
    {
        public int Id { get; set; }
        public TbBusType Type { get; set; }
        public string Name { get; set; }
        public string PlateNumber { get; set; }
        public TbLocation Location { get; set; }
        public double SeatCapacity { get; set; }
        public TbBusStatus Status { get; set; }
    }
}
