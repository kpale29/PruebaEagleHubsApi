namespace ConsumoResponsableApi.Domain.Models.Consumption.Request
{
    public class PostOtherConsumptionRequest
    {
        public int Quantity { get; set; }
        public int LocationId { get; set; }
        public int ConsumptionTypeId { get; set; }
        public DateTime ExecutedAt { get; set; }

    }
}
