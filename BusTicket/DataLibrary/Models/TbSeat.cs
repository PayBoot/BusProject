namespace DataLibrary.Models
{
    public class TbSeat
    {
        public int Id { get; set; }
        public int SeatName { get; set; }
        public TbBus Bus { get; set; }
    }
}
