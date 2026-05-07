using ExpenseTracker.Entities.DTOs.Request;
using ExpenseTracker.Entities.DTOs.Response;

namespace ExpenseTracker.Services.Interfaces
{
    public interface IReportService
    {
        Task<ReportResponseDto> GenerateReport(CreateReportDto dto);
        Task<List<ReportResponseDto>> GetAll();
    }
}
