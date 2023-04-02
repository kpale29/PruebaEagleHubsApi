namespace ConsumoResponsableApi.Domain.Models.Consumption.Response.Reports
{
    public class GetMontlyImpactResponse
    {
        public int Year { get; set; }

        public int Month { get; set; }
        public string LocationName { get; set; } = null!;
        public double Percentaje { get; set; }
    }
}
