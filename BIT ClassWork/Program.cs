// See https://aka.ms/new-console-template for more information
using BIT_ClassWork.Models;

Console.WriteLine("Hello, World!");

var i = new Start();
public class Start
{
    private List<User> users = new List<User>();
    private List<ItemModel> itemList = new List<ItemModel>();
    public Start()
    {
        CreateUser();
        CreateComputers();
        CreatePhones(); 
        AddItemToUserBasket();
    }


    private void CreateComputers()
    {
        itemList.Add(new ComputerModel { 
            Id = itemList.Count + 1, 
            Name = "Computer 1", 
            Price = 1000, 
            Raiting = 4.5, 
            GPU = "Nvidia GTX 1070", 
            CPU = "Intel i7-8700k", 
            Producer = "Asus" 
        });
        itemList.Add(new ComputerModel { 
            Id = itemList.Count + 1, 
            Name = "Computer 2", 
            Price = 1500, 
            Raiting = 4.8, 
            GPU = "Nvidia RTX 2080 Ti", 
            CPU = "AMD Ryzen 9 5900X", 
            Producer = "MSI" 
        });
        itemList.Add(new ComputerModel { 
            Id = itemList.Count + 1, 
            Name = "Computer 3", 
            Price = 2000, 
            Raiting = 5, 
            GPU = "Nvidia RTX 3090", 
            CPU = "Intel i9-11900k", 
            Producer = "Dell" 
        });
        itemList.Add(new ComputerModel { 
            Id = itemList.Count + 1, 
            Name = "Computer 1", 
            Price = 1000, 
            GPU = "Nvidia", 
            CPU = "Intel", 
            Producer = "Dell"
        });
        itemList.Add(new ComputerModel { 
            Id = itemList.Count + 1,
            Name = "Computer 2", 
            Price = 1500, 
            GPU = "AMD", 
            CPU = "AMD Ryzen", 
            Producer = "Lenovo"
        });
        itemList.Add(new ComputerModel { 
            Id = itemList.Count + 1, 
            Name = "Computer 3", 
            Price = 800, 
            GPU = "Nvidia", 
            CPU = "Intel", 
            Producer = "Asus"
        });
    }

    private void CreatePhones()
    {
        itemList.Add(new PhoneModel
        {
            Id = itemList.Count + 1,
            Name = "Phone 1",
            Price = 699.99,
            Raiting = 4.7,
            Display = "6.5 inches, OLED",
            Battery = "4500 mAh",
            Model = "Samsung Galaxy S21"
        });
        itemList.Add(new PhoneModel
        {
            Id = itemList.Count + 1,
            Name = "Phone 2",
            Price = 599.99,
            Raiting = 4.3,
            Display = "6.1 inches, IPS LCD",
            Battery = "4000 mAh",
            Model = "Google Pixel 5"
        });
        itemList.Add(new PhoneModel
        {
            Id = itemList.Count + 1,
            Name = "Phone 3",
            Price = 799.99,
            Raiting = 4.9,
            Display = "6.7 inches, Super Retina XDR",
            Battery = "3687 mAh",
            Model = "Apple iPhone 12 Pro Max"
        });
        itemList.Add(new PhoneModel { 
            Id = itemList.Count + 1,
            Name = "Phone 1",
            Price = 500,
            Display = "AMOLED",
            Battery = "5000mAh",
            Model = "Samsung"
        });
        itemList.Add(new PhoneModel { 
            Id = itemList.Count + 1,
            Name = "Phone 2",
            Price = 700,
            Display = "LCD",
            Battery = "4500mAh",
            Model = "Apple"
        });
        itemList.Add(new PhoneModel
        {
            Id = itemList.Count + 1,
            Name = "Phone 3",
            Price = 300,
            Display = "OLED",
            Battery = "4000mAh",
            Model = "OnePlus"
        });
    }

    private void CreateUser()
    {
        int id = users.Count() + 1;
        User user = new User
        {
            Id = id,
            userName = "favaz",
            password = "1",
            basket = new Basket(id, id, new List<ItemModel>())
        };
        users.Add(user);
    }
    private void AddItemToUserBasket()
    {
        users[0].basket.Add(itemList, 1);
        users[0].basket.Add(itemList, 3);
        foreach(var i in users[0].basket.Items) 
        {
            Console.WriteLine(i);
        }
    }
}
