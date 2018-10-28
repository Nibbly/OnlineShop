using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Interfaces
{
    interface IShopEntity<T, TKey>
    {
        IEnumerable<T> GetItems();

        void AddItem(T item);

        T GetItem(TKey key);

        void UpdateItem(TKey key, T updatedItem);

        void DeleteItem(TKey key);

    }
}
