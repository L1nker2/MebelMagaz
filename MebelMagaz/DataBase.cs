using Microsoft.EntityFrameworkCore;

namespace MebelMagaz
{
    internal class DataBase : DbContext
    {
        public static string sqlstr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Mebel.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";
        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(sqlstr);
        }
        public static void AddClient(string fName, string sName, string Phone)
        {
            using (DataBase db = new())
            {
                Client client = new()
                {
                    FirstName = fName,
                    SecondName = sName,
                    Phone = Phone
                };
                db.Clients.Add(client);
                db.SaveChanges();
            }
        }
        public static void RemoveClient(int Id)
        {
            using (DataBase db = new())
            {
                var client = db.Clients.FirstOrDefault(el => el.Id == Id);
                db.Clients.Remove(client);
                db.SaveChanges();
            }
        }
        public static void AddProduct(string name, string desc, int price)
        {
            using (DataBase db = new())
            {
                Product product = new()
                {
                    Name = name,
                    Description = desc,
                    Price = price
                };
                db.Products.Add(product);
                db.SaveChanges();
            }
        }
        public static void RemoveProduct(int id)
        {
            using (DataBase db = new())
            {
                Product product = db.Products.FirstOrDefault(el => el.Id == id);
                db.Products.Remove(product);
                db.SaveChanges();
            }
        }
        public static void AddService(string name, string desc, int price)
        {
            using (DataBase db = new())
            {
                Service service = new()
                {
                    Name = name,
                    Description = desc,
                    Price = price
                };
                db.Services.Add(service);
                db.SaveChanges();
            }
        }
        public static void RemoveService(int id)
        {
            using (DataBase db = new())
            {
                Service service = db.Services.FirstOrDefault(el => el.Id == id);
                db.Services.Remove(service);
                db.SaveChanges();
            }
        }
        public static void AddContract(int productid, int clientid, int serviceid)
        {
            using (DataBase db = new())
            {
                Contract contract = new()
                {
                    ProductId = productid,
                    ClientId = clientid,
                    ServiceId = serviceid
                };
                db.Contracts.Add(contract);
                db.SaveChanges();
            }
        }
        public static void AddContract(int productid, int clientid)
        {
            using (DataBase db = new())
            {
                Contract contract = new()
                {
                    ProductId = productid,
                    ClientId = clientid,
                };
                db.Contracts.Add(contract);
                db.SaveChanges();
            }
        }
        public static void RemoveContract(int id)
        {
            using (DataBase db = new())
            {
                Contract contract = db.Contracts.FirstOrDefault(el => el.Id == id);
                db.Contracts.Remove(contract);
                db.SaveChanges();
            }
        }
    }
}
