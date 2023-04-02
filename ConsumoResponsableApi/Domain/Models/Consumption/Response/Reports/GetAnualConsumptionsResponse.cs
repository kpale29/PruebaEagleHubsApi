namespace ConsumoResponsableApi.Domain.Models.Consumption.Response.Reports
{
    public class GetAnualConsumptionsResponse
    {
        public string LocationName { get; set; } = null!;
        public double Percentage { get; set; }
        public int Year { get; set; }
    }
}
