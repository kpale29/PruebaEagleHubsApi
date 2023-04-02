using ConsumoResponsableApi.Application.Services.Implementation;
using ConsumoResponsableApi.Application.Services.Interface.Custom;
using ConsumoResponsableApi.Domain.Models.Consumption.Request;
using Microsoft.AspNetCore.Mvc;

namespace ConsumoResponsableApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ReportsController : ControllerBase
{
    private readonly IConsumptionsReport _consumptionsReportService;
    public ReportsController(IConsumptionsReport consumptionsReportService)
    {
        _consumptionsReportService = consumptionsReportService;
    }

    [HttpGet("[action]")]
    public async Task<IActionResult> AnualConsumptions()
    {
        return Ok(await _consumptionsReportService.GetAnualConsumptionsAsync());
    }

    [HttpGet("[action]")]
    public async Task<IActionResult> MontlyFuelConsumptions()
    {
        return Ok(await _consumptionsReportService.GetMontlyFuelAsync());
    }

    [HttpGet("[action]")]
    public async Task<IActionResult> MontlyImpact()
    {
        return Ok(await _consumptionsReportService.GetMontlyImpactAsync());
    }

    [HttpGet("[action]")]
    public async Task<IActionResult> MontlyEnergyConsumptionsFactory()
    {
        return Ok(await _consumptionsReportService.GetMontlyEnergyAsync());
    }

    [HttpGet("[action]")]
    public async Task<IActionResult> MontlyEnergyFuelComparison()
    {
        return Ok(await _consumptionsReportService.GetMontlyComparisonAsync());
    }

    [HttpGet("[action]")]
    public async Task<IActionResult> ComparisonPetroleumDerivativeConsumptions()
    {
        return Ok(await _consumptionsReportService.GetPetroleumDerivativeAsync());
    }


}

