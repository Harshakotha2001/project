using On_Demand_Car_Wash.Models;

namespace On_Demand_Car_Wash.IRepository
{
    public interface IInvoice
    {
        Task<Invoice> ViewInvoiceById(int id);
        Task<List<Invoice>> ViewAllInvoices();
    }
}
