namespace ExpenseTracker.Services.Intefaces
{
    public interface IBaseService<TResponse, TCreateDto>
    {
        Task<List<TResponse>> GetAll();
        Task<TResponse?> GetById(int id);
        Task<TResponse> Create(TCreateDto entity);
        Task<TResponse?> Update(int id, TCreateDto entity);
        Task<bool> Delete(int id);
    }
}
