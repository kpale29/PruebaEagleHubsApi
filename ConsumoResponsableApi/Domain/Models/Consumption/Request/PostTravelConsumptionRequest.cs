namespace ConsumoResponsableApi.Domain.Models.Consumption.Request
{
    public class PostTravelConsumptionRequest
    {
        public int Quantity { get; set; }
        public int LocationId { get; set; }
        public DateTime ExecutedAt { get; set; }
    }
}
