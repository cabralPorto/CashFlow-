using CashFlow.Domain.Entidades;

namespace CashFlow.Domain.Repositories.Expenses;
public interface IExpensesRepository
{
    public void Add(Expense expense);
}
