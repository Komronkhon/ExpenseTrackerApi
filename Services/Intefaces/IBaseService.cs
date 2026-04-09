namespace ExpenseTracker.Services.Intefaces
{
    public interface IBaseService<TResponse, TCreateDto>
    {
        List<TResponse> GetAll();
        TResponse? GetById(int id);
        TResponse Create(TCreateDto entity);
        TResponse? Update(int id, TCreateDto entity);
        bool Delete(int id);
    }
}
