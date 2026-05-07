using AutoMapper;
using ExpenseTracker.Entities.DTOs.Request;
using ExpenseTracker.Entities.DTOs.Response;
using ExpenseTracker.Entities.Models;
using ExpenseTracker.Repositories.Interfaces;
using ExpenseTracker.Services;
using ExpenseTracker.Services.Interfaces;

public class PaymentMethodService
    : BaseService<PaymentMethod, PaymentMethodResponseDto, CreatePaymentMethodDto>,
      IPaymentMethodService
{
    public PaymentMethodService(
        IPaymentMethodRepository repository,
        IMapper mapper
    ) : base(repository, mapper)
    { }
}