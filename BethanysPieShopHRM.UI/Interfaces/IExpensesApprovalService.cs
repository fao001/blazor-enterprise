using BethanysPieShopHRM.Shared;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.UI.Services {
    public interface IExpensesApprovalService {
        Task<ExpenseStatus> GetApprovalExpense(Expense expense);
    }
}