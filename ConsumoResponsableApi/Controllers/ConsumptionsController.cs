using ConsumoResponsableApi.Application.Services.Interface.Base;
using ConsumoResponsableApi.Domain.Models.Consumption.Request;
using ConsumoResponsableApi.Domain.Models.Consumption.Response;
using ConsumoResponsableApi.Utils.Responses;
using Microsoft.AspNetCore.Mvc;

namespace ConsumoResponsableApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsumptionsController : ControllerBase
    {
        private readonly IServicePost<PostFuelConsumptionRequest, PostDefaultConsumptionResponse> _fuelConsumptionService;
        private readonly IServicePost<PostEnergyConsumptionRequest, PostDefaultConsumptionResponse> _energyConsumptionService;
        private readonly IServicePost<PostOtherConsumptionRequest, PostDefaultConsumptionResponse> _otherConsumptionService;
        private readonly IServicePost<PostTravelConsumptionRequest, PostDefaultConsumptionResponse> _travelConsumptinoService;
        public ConsumptionsController(IServicePost<PostFuelConsumptionRequest, PostDefaultConsumptionResponse> fuelConsumptionService,
        IServicePost<PostEnergyConsumptionRequest, PostDefaultConsumptionResponse> energyConsumptionService,
        IServicePost<PostOtherConsumptionRequest, PostDefaultConsumptionResponse> otherConsumptionService,
        IServicePost<PostTravelConsumptionRequest, PostDefaultConsumptionResponse> travelConsumptinoService)
        {
            _energyConsumptionService = energyConsumptionService;
            _fuelConsumptionService = fuelConsumptionService;
            _otherConsumptionService = otherConsumptionService;
            _travelConsumptinoService = travelConsumptinoService;
        }


        [HttpPost("[action]")]
        public async Task<IActionResult> FuelConsumption(PostFuelConsumptionRequest request)
        {
            return Ok(await _fuelConsumptionService.PostAsync(request));
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> EnergyConsumption(PostEnergyConsumptionRequest request)
        {
            return Ok(await _energyConsumptionService.PostAsync(request));
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> OtherConsumption(PostOtherConsumptionRequest request)
        {
            return Ok(await _otherConsumptionService.PostAsync(request));
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> TravelConsumption(PostTravelConsumptionRequest request)
        {
            return Ok(await _travelConsumptinoService.PostAsync(request));
        }
    }
}
