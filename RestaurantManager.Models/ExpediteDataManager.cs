using System.Collections.Generic;

namespace RestaurantManager.Models
{
    public class ExpediteDataManager : DataManager
    {
        protected override void OnDataLoaded()
        {
            this.OrderItems = base.Repository.Orders;
        }

        private List<Order> _orderItems;

        public List<Order> OrderItems
        {
            get { return base.Repository.Orders; }
            set
            {
                if(value != this._orderItems)
                {
                    this._orderItems = value;
                    this.OnPropertyChanged();
                }
            }
        }

    }
}
