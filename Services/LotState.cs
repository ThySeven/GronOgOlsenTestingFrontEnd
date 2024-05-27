using GronOgOlsenFrontEnd.Models;

namespace GronOgOlsenFrontEnd.Services
{
    public class LotState
    {
        private LotModel _lot = new LotModel();

        public LotModel Lot
        {
            get => _lot;
            set
            {
                if (_lot != value)
                {
                    _lot = value;
                    OnLotChanged();
                }
            }
        }

        public event Action LotChanged;

        public virtual void OnLotChanged()
        {
            LotChanged?.Invoke();
        }
    }
}
