using BIT_ClassWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT_ClassWork.Interfaces
{
    public interface IBasket
    {
        int Id { get; set; }
        int UserId { get; set; }
        List<ItemModel> Items { get; set; }

        List<ItemModel> Clear(List<ItemModel> itemList);
        List<ItemModel> Add(List<ItemModel> itemList, int itemId);
        List<ItemModel> Remove(List<ItemModel> itemList, int itemId);
        double GetBasketPrice(List<ItemModel> itemList);
    }
}
