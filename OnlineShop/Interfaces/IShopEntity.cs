using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Interfaces
{
    interface IShopEntity<T, U, V>
    {
        IEnumerable<T> GetItems();

        void AddItem(T item);

        T GetItem(U key);

        void UpdateItem(U key, T updatedItem);

        void DeleteItem(U key);

        V CustomerAlreadyInDb(T item);

    }
}
