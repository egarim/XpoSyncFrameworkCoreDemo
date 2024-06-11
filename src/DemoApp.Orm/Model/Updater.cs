using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;

namespace DemoApp.Orm.Model
{
    public class Updater
    {
        public Updater()
        {
            
        }

        public void GenerateData(IDataLayer Dal)
        {
            var UoW = new UnitOfWork(Dal);
            GenerateData(UoW);
        }

        public void GenerateData(UnitOfWork UoW)
        {
            var JoseManuel = CreateCustomer(UoW, "001", "Jose Manuel Ojeda Melgar", "joche@bitframeworks.com", "Saint Petersburg Russia",
                 true);

            //UoW.CommitChanges();
            //return;


            var Oscar = CreateCustomer(UoW, "002", "Oscar Ojeda Melgar", "oscar@bitframeworks.com", "San Salvador,El Salvador",
                true);
            CreateCustomer(UoW, "003", "Miguel Antonio Melgar Deras", "miguel@bitframeworks.com",
                "Suchitoto,El Salvador", true);
            CreateCustomer(UoW, "004", "Douglas Coto", "douglas@bitframeworks.com", "San Salvador,El Salvador", true);
            CreateCustomer(UoW, "005", "Voldemar Skola", "voldemar@bitframeworks.com", "Tallinn,Estonia", true);
            CreateCustomer(UoW, "006", "Jaime Macias", "jaime@bitframeworks.com", "San Salvador,El Salvador", true);
            CreateCustomer(UoW, "007", "Jose Javier Columbie", "javier@bitframeworks.com", "La Habana,Cuba", true);
            CreateCustomer(UoW, "008", "Luis Alarcon", "luis@bitframeworks.com", "Santiago,Chile", true);
            CreateCustomer(UoW, "009", "Pedro Hernandez", "perdro@bitframeworks.com", "Santiago,Republica Dominicana",
                true);
            CreateCustomer(UoW, "010", "Carlos Melgar", "carlos@bitframeworks.com", "Ciudad de Guatemala,Guatemala",
                true);

            List<Product> Products = new List<Product>();
            Products.Add(CreateProduct(UoW, "001", "Coffe", "Salvadoran Coffee", 15, false));
            Products.Add(CreateProduct(UoW, "002", "Vodka", "Russian Vodka", 95, false));
            Products.Add(CreateProduct(UoW, "003", "Bread", "Estonian bread", 25, false));
            Products.Add(CreateProduct(UoW, "004", "Sobreasada", "Spanish sobreasada", 25, false));
            Products.Add(CreateProduct(UoW, "005", "Empanadas", "Chilean Empanada", 15, false));
            Products.Add(CreateProduct(UoW, "006", "Pupusas", "Salvadorean pupusas", 15, false));


            CreateInvoie(UoW, JoseManuel, Products);
            CreateInvoie(UoW, Oscar, Products);
            UoW.CommitChanges();
        }

        public void CreateInvoie(UnitOfWork UoW, Customer Customer, List<Product> Products)
        {
            var Invoice = new Invoice(UoW);
            Invoice.Date = DateTime.Now;
            Invoice.Customer = Customer;
            foreach (Product product in Products)
            {
                Invoice.InvoiceDetails.Add(new InvoiceDetail(UoW) { Invoice = Invoice, Product = product, Quatity = 10, UnitPrice = product.UnitPrice });
            }
        }

        public Customer CreateCustomer(UnitOfWork UoW, string code, string name, string email, string address, bool Active)
        {

            Customer Customer = UoW.FindObject<Customer>(new BinaryOperator("Code", code));
            if (Customer == null)
            {
                Customer = new Customer(UoW);
                Customer.Code = code;
                Customer.Name = name;
                Customer.Email = email;
                Customer.Address = address;
                Customer.Active = Active;
            }

            return Customer;
        }

        public Product CreateProduct(UnitOfWork UoW, string code, string name, string description, int UnitPrice,
            bool Discontinued)
        {
            var Product = new Product(UoW);
            Product.Name = name;
            Product.UnitPrice = UnitPrice;
            Product.Code = code;
            Product.Description = description;
            Product.Discontinued = Discontinued;
            return Product;
        }
    }
}