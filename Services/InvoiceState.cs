using GronOgOlsenFrontEnd.Models;

namespace GronOgOlsenFrontEnd.Services
{
    public class InvoiceState
    {
        private InvoiceModel _invoice = new InvoiceModel();

        public InvoiceModel Invoice
        {
            get => _invoice;
            set
            {
                if (_invoice != value)
                {
                    _invoice = value;
                    OnInvoiceChanged();
                }
            }
        }

        public event Action InvoiceChanged;

        public virtual void OnInvoiceChanged()
        {
            InvoiceChanged?.Invoke();
        }
    }
}
