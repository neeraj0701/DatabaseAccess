//namespace EventHandling
//{
//    public class Product
//    {
//        public string Name { get; set; }
//        public long Price { get; set; }
//    }
//    public class Program
//    {
//        public static void Main()
//        {
//            Publisher publisher = new Publisher();
//            Subscriber subcriber = new Subscriber(publisher);
//            publisher.Add(new Product
//            {
//                Name = "Redmi Note 9",
//                Price = 28000
//            });
//            publisher.Add(new Product
//            {
//                Name = "Lenovo Ideapad 3",
//                Price = 40000
//            });
//            publisher.Add(new Product
//            {
//                Name = "Iqoo Neo 7",
//                Price = 31000
//            });
//        }
//    }
//    public delegate void Notify(Product product);
//    public class Publisher
//    {
//        public event Notify ProductAdded;
//        protected virtual void OnAdded(Product product)
//        {
//            if (ProductAdded != null) ProductAdded(product);
//        }
//        public void Add(Product product)
//        {
//            List<Product> list = new List<Product>();
//            OnAdded(product);
//        }
//    }
//    public class Subscriber
//    {
//        public Subscriber(Publisher publisher)
//        {
//            publisher.ProductAdded += ProductAddedInfo;
//        }
//        public void ProductAddedInfo(Product product)
//        {
//            Console.WriteLine(product.Name + " has added");
//            Console.WriteLine("Price : " + product.Price);
//        }
//    }
//}
