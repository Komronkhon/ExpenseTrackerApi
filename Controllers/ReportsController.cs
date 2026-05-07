using ExpenseTracker.Entities.DTOs.Request;
using ExpenseTracker.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReportsController : ControllerBase
    {
        private readonly IReportService _reportService;

        public ReportsController(IReportService reportService)
        {
            _reportService = reportService;
        }

        [HttpPost("generate")]
        public async Task<IActionResult> Generate(CreateReportDto dto)
        {
            var report = await _reportService.GenerateReport(dto);

            return Ok(report);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var reports = await _reportService.GetAll();

            return Ok(reports);
        }
    }
}