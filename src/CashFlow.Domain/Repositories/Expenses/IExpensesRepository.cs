using CashFlow.Domain.Entidades;

namespace CashFlow.Domain.Repositories.Expenses;
public interface IExpensesRepository
{
   Task Add(Expense expense);
}
