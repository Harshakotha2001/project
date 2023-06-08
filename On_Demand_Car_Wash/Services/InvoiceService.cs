using On_Demand_Car_Wash.IRepository;
using On_Demand_Car_Wash.Models;

namespace On_Demand_Car_Wash.Services
{
    public class InvoiceService
    {
        private IInvoice _repository;
        public InvoiceService(IInvoice repository)
        {
            _repository = repository;
        }
        public async Task<Invoice> ViewInvoiceById(int id)
        {
            return await _repository.ViewInvoiceById(id);
        }
        public async Task<List<Invoice>> ViewAllInvoices()
        {
            return await _repository.ViewAllInvoices();
        }



    }
}
