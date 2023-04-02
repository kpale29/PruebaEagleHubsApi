namespace ConsumoResponsableApi.Domain.Models.Consumption.Request
{
    public class PostFuelConsumptionRequest
    {
        public int Quantity { get; set; }
        public int LocationId { get; set; }
        public DateTime ExecutedAt { get; set; }

    }
}
