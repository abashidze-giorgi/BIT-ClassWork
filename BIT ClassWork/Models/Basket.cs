using BIT_ClassWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT_ClassWork.Models
{
    public class Basket : IBasket
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public List<ItemModel> Items { get; set; }

        public Basket(int id, int userId, List<ItemModel> items)
        {
            Id = id;
            UserId = userId;
            Items = items;
        }

        public List<ItemModel> Add(List<ItemModel> itemList, int itemId)
        {
            var item = itemList.FirstOrDefault(x => x.Id == itemId);
            if (item != null)
            {
                Items.Add(item);
            }
            return itemList;
        }

        public List<ItemModel> Remove(List<ItemModel> itemList, int itemId)
        {
            var item = Items.FirstOrDefault(x => x.Id == itemId);
            if (item != null)
            {
                Items.Remove(item);
            }
            return itemList;
        }

        public List<ItemModel> Clear(List<ItemModel> itemList)
        {
            Items.Clear();
            return itemList;
        }

        public double GetBasketPrice(List<ItemModel> itemList)
        {
            return Items.Sum(x => x.Price);
        }
    }
}
