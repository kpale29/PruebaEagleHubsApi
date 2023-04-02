namespace ConsumoResponsableApi.Domain.Models.Consumption.Response.Reports
{
    public class GetMontlyFuelConsumptionsResponse
    {
        public int Year { get; set; }

        public int Month { get; set; }

        public double AverageAmount { get; set; }
    }
}
