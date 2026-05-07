using AutoMapper;
using ExpenseTracker.Entities.DTOs.Request;
using ExpenseTracker.Entities.DTOs.Response;
using ExpenseTracker.Entities.Models;
using ExpenseTracker.Repositories.Interfaces;
using ExpenseTracker.Services.Interfaces;

public class ReportService : IReportService
{
    private readonly IReportRepository _reportRepository;
    private readonly IExpenseRepository _expenseRepository;
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public ReportService(
        IReportRepository reportRepository,
        IExpenseRepository expenseRepository,
        IUserRepository userRepository,
        IMapper mapper)
    {
        _reportRepository = reportRepository;
        _expenseRepository = expenseRepository;
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task<ReportResponseDto> GenerateReport(CreateReportDto dto)
    {
        var user = await _userRepository.GetById(dto.UserId);

        if (user == null)
            throw new Exception("User not found");

        var expenses = (await _expenseRepository.GetAll())
            .Where(x => x.UserId == dto.UserId &&
                        x.CreatedAt >= dto.StartDate &&
                        x.CreatedAt <= dto.EndDate)
            .ToList();

        var total = expenses.Sum(x => x.Amount);

        var report = new Report
        {
            Title = dto.Title,
            StartDate = dto.StartDate,
            EndDate = dto.EndDate,
            TotalAmount = total,
            UserId = dto.UserId
        };

        var created = await _reportRepository.Create(report);

        return _mapper.Map<ReportResponseDto>(created);
    }

    public async Task<List<ReportResponseDto>> GetAll()
    {
        var reports = await _reportRepository.GetAll();

        return _mapper.Map<List<ReportResponseDto>>(reports);
    }
}