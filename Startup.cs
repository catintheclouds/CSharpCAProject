using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualBasic.CompilerServices;
using ShoppingCart.DB;
using ShoppingCart.Models;

namespace ShoppingCart
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            // This is the line you're interested in
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSession();
            services.AddDbContext<MyDbContext>
                (opt => opt.UseLazyLoadingProxies()
            .UseSqlServer(Configuration.GetConnectionString("DbConn"))
            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, MyDbContext dbcontext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseSession();
            app.UseAuthorization();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute(
            //        name: "default",
            //        pattern: "{controller=Purchase}/{action=Index}/{id?}");
            //});

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            dbcontext.Database.EnsureDeleted(); 
            dbcontext.Database.EnsureCreated();

            // Add customers
            // Add Encrption
            static string Encrypt(string value)
            {
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    UTF8Encoding utf8 = new UTF8Encoding();
                    byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                    return Convert.ToBase64String(data);
                }
            }

            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Tim";
            customer.LastName = "Cook";
            customer.DateOfBirth = new DateTime(1994, 5, 4, 00, 00, 00).ToUniversalTime();
            customer.Address = "Apple";
            customer.Email = "TimCook@apple.com";
            customer.Password = Encrypt("TimCookisthebest");
            //customer.Password = "TimCookIsTheBest";



            Customer customer1 = new Customer();
            customer1.Id = 2;
            customer1.FirstName = "Steve";
            customer1.LastName = "Jobs";
            customer1.DateOfBirth = new DateTime(1991, 1, 28, 00, 00, 00).ToUniversalTime();
            customer1.Address = "Apple";
            customer1.Email = "SteveJobs@apple.com";
            customer1.Password = Encrypt("SteveJobsisthebest");
           
            //customer1.Password = "SteveJobsIsTheBest";

            dbcontext.Add(customer);
            dbcontext.Add(customer1);

            //Add Card details
            CardDetail cardDetail = new CardDetail();
            cardDetail.Id = 1;
            cardDetail.Name = Encrypt("Ben");
            cardDetail.ExD = Encrypt("0623");
            cardDetail.Code = Encrypt("1111222233334444");
            cardDetail.CCV = Encrypt("666");
            cardDetail.Address = Encrypt("NUS");

            CardDetail cardDetail1 = new CardDetail();
            cardDetail1.Id = 2;
            cardDetail1.Name = Encrypt("Jan");
            cardDetail1.ExD = Encrypt("0522");
            cardDetail1.Code = Encrypt("5555666677778888");
            cardDetail1.CCV = Encrypt("555");
            cardDetail1.Address = Encrypt("NUS");

            dbcontext.Add(cardDetail);
            dbcontext.Add(cardDetail1);

            //Add product
            Product product = new Product();
            product.Id = 1;
            product.Name = "Photoshop";
            product.Description = "Design and edit nice photos.";
            product.Price = 150;
            product.Category = "Photo";
            product.Brand = "Adobe";
            product.ImageURL = "https://www.cia.edu/files/blog/full/image238.jpg";

            Product product1 = new Product();
            product1.Id = 2;
            product1.Name = "Lightroom";
            product1.Description = "Edit nice photos.";
            product1.Price = 110;
            product1.Category = "Photo";
            product1.Brand = "Adobe";
            product1.ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/56/Adobe_Photoshop_Lightroom_Classic_CC_icon.svg/1200px-Adobe_Photoshop_Lightroom_Classic_CC_icon.svg.png";

            Product product2 = new Product();
            product2.Id = 3;
            product2.Name = "Acrobat";
            product2.Description = "The complete PDF solution for today's mobile connected world.";
            product2.Price = 50;
            product2.Category = "Productivity";
            product2.Brand = "Adobe";
            product2.ImageURL = "https://upload.wikimedia.org/wikipedia/en/thumb/4/4c/Acrobat_Pro_CC_icon.svg/1200px-Acrobat_Pro_CC_icon.svg.png";

            Product product3 = new Product();
            product3.Id = 4;
            product3.Name = "Atom";
            product3.Description = "Create new HTML code.";
            product3.Price = 15;
            product3.Category = "Coding";
            product3.Brand = "Atom";
            product3.ImageURL = "https://cdn.freebiesupply.com/logos/large/2x/atom-4-logo-png-transparent.png";

            Product product4 = new Product();
            product4.Id = 5;
            product4.Name = "Visual Studio";
            product4.Description = "Create new C# Code.";
            product4.Price = 30;
            product4.Category = "Coding";
            product4.Brand = "Microsoft";
            product4.ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cd/Visual_Studio_2017_Logo.svg/1200px-Visual_Studio_2017_Logo.svg.png";

            Product product5 = new Product();
            product5.Id = 6;
            product5.Name = "AfterEffects";
            product5.Description = "Create motion graphics and visual effects for film, TV, video, and web.";
            product5.Price = 240;
            product5.Category = "Design";
            product5.Brand = "Adobe";
            product5.ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cb/Adobe_After_Effects_CC_icon.svg/1200px-Adobe_After_Effects_CC_icon.svg.png";

            Product product6 = new Product();
            product6.Id = 7;
            product6.Name = "PremierPro";
            product6.Description = "Edit and craft polished films and video.";
            product6.Price = 400;
            product6.Category = "Video";
            product6.Brand = "Adobe";
            product6.ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f2/Adobe_Premiere_Pro_Logo.svg/1200px-Adobe_Premiere_Pro_Logo.svg.png";

            Product product7 = new Product();
            product7.Id = 8;
            product7.Name = "PremierRush";
            product7.Description = "Create and share online videos anywhere.";
            product7.Price = 35;
            product7.Category = "Video";
            product7.Brand = "Adobe";
            product7.ImageURL = "https://3.bp.blogspot.com/-bZA1tGKkVsg/XIIzvphJcYI/AAAAAAAAM_8/acxj8DWFA5EI75nZcYHw7Th9MmytqTCCQCLcBGAs/s1600/aru.png";

            Product product8 = new Product();
            product8.Id = 9;
            product8.Name = "InDesign";
            product8.Description = "Craft elegant layouts at your desk or on the go.";
            product8.Price = 80;
            product8.Category = "Design";
            product8.Brand = "Adobe";
            product8.ImageURL = "https://cdn.freebiesupply.com/logos/large/2x/adobe-indesign-cs6-logo-png-transparent.png";

            Product product9 = new Product();
            product9.Id = 10;
            product9.Name = "DreamWeaver";
            product9.Description = "Design and develop modern, responsive websites.";
            product9.Price = 190;
            product9.Category = "Design";
            product9.Brand = "Adobe";
            product9.ImageURL = "https://cdn1.iconfinder.com/data/icons/adobe-3/512/Dreamweaver.png";

            Product product10 = new Product();
            product10.Id = 11;
            product10.Name = "Illustrator";
            product10.Description = "Create beautiful vector art and illustrations.";
            product10.Price = 110;
            product10.Category = "Design";
            product10.Brand = "Adobe";
            product10.ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fb/Adobe_Illustrator_CC_icon.svg/1200px-Adobe_Illustrator_CC_icon.svg.png";

            
            dbcontext.Add(product);
            dbcontext.Add(product1);
            dbcontext.Add(product2);
            dbcontext.Add(product3);
            dbcontext.Add(product4);
            dbcontext.Add(product5);
            dbcontext.Add(product6);
            dbcontext.Add(product7);
            dbcontext.Add(product8);
            dbcontext.Add(product9);
            dbcontext.Add(product10);

            ProductComments pc = new ProductComments();
            pc.Id = "1";
            pc.ProductId = 1;
            pc.Rating = 5;
            pc.ThisDateTime = DateTime.Now;
            pc.Comments = "Test WPP";
            dbcontext.Add(pc);

            ProductComments pc1 = new ProductComments();
            pc1.Id = "2";
            pc1.ProductId = 2;
            pc1.Rating = 2;
            pc1.ThisDateTime = DateTime.Now;
            pc1.Comments = "Test WPP";
            dbcontext.Add(pc1);

            ProductComments pc2 = new ProductComments();
            pc2.Id = "3";
            pc2.ProductId = 3;
            pc2.Rating = 5;
            pc2.ThisDateTime = DateTime.Now;
            pc2.Comments = "Test WPP";
            dbcontext.Add(pc2);

            ProductComments pc3 = new ProductComments();
            pc3.Id = "4";
            pc3.ProductId = 4;
            pc3.Rating = 3;
            pc3.ThisDateTime = DateTime.Now;
            pc3.Comments = "Test WPP";
            dbcontext.Add(pc3);

            ProductComments pc4 = new ProductComments();
            pc4.Id = "5";
            pc4.ProductId = 5;
            pc4.Rating = 5;
            pc4.ThisDateTime = DateTime.Now;
            pc4.Comments = "Test WPP";
            dbcontext.Add(pc4);

            ProductComments pc6 = new ProductComments();
            pc6.Id = "6";
            pc6.ProductId = 6;
            pc6.Rating = 5;
            pc6.ThisDateTime = DateTime.Now;
            pc6.Comments = "Test WPP";
            dbcontext.Add(pc6);

            ProductComments pc7 = new ProductComments();
            pc7.Id = "7";
            pc7.ProductId = 7;
            pc7.Rating = 1;
            pc7.ThisDateTime = DateTime.Now;
            pc7.Comments = "Test WPP";
            dbcontext.Add(pc7);

            ProductComments pc8 = new ProductComments();
            pc8.Id = "8";
            pc8.ProductId = 8;
            pc8.Rating = 5;
            pc8.ThisDateTime = DateTime.Now;
            pc8.Comments = "Test WPP";
            dbcontext.Add(pc8);

            ProductComments pc9 = new ProductComments();
            pc9.Id = "9";
            pc9.ProductId = 9;
            pc9.Rating = 5;
            pc9.ThisDateTime = DateTime.Now;
            pc9.Comments = "Test WPP";
            dbcontext.Add(pc9);

            ProductComments pc10 = new ProductComments();
            pc10.Id = "10";
            pc10.ProductId = 10;
            pc10.Rating =2;
            pc10.ThisDateTime = DateTime.Now;
            pc10.Comments = "Test WPP";
            dbcontext.Add(pc10);

            ProductComments pc11 = new ProductComments();
            pc11.Id = "11";
            pc11.ProductId = 11;
            pc11.Rating = 4;
            pc11.ThisDateTime = DateTime.Now;
            pc11.Comments = "Test WPP";
            dbcontext.Add(pc11);
            //add Cart
            /*ddd
            Cart cart = new Cart();
            Cart.Id = 1;
            Cart.productID = "Illustrator";
            Cart.customer.ID = "Create beautiful vector art and illustrations.";
            Cart.Quantity. = 110;
            Cart.dateAdded = "Design";
            */

            //Test
            Cart c1 = new Cart()
            {
                Id = "a",
                ProductID = product1.Id,
                CustomerID = customer1.Id,
                Quantity = 3,
                Subtotal = 300,
                DateAdded = DateTime.Now,
            };

            Cart c2 = new Cart()
            {
                Id = "b",
                ProductID = product2.Id,
                CustomerID = customer1.Id,
                Quantity = 3,
                Subtotal=300,
                DateAdded = DateTime.Now,
            };

            dbcontext.Add(c1);
            dbcontext.Add(c2);
            

            //Add Order
            
            //Order o1 = new Order();
            //o1.Id = "1";
            //o1.CustomerID = customer.Id;
            //o1.DateOfPurchase= new DateTime(1991, 1, 28, 00, 00, 00).ToUniversalTime();
            //o1.TotalPrice = 1000;
            //dbcontext.Add(o1);


            //Order o2 = new Order();
            //o2.Id = "2";
            //o2.CustomerID = customer.Id;
            //o2.DateOfPurchase = new DateTime(1991, 1, 28, 00, 00, 00).ToUniversalTime();
            //o2.TotalPrice = 2000;
            //dbcontext.Add(o2);
          

            //Order o3 = new Order();
            //o2.Id = 3;
            //o2.CustomerID = customer1.Id;
            //o2.DateOfPurchase = new DateTime(1991, 1, 28, 00, 00, 00).ToUniversalTime();
            //o2.TotalPrice = 3000;
            //dbcontext.Add(o3);

           
            //Add OrderDetail
            //OrderDetails od = new OrderDetails();
            //od.Id = "1";
            //od.OrderID = o1.Id;
            //od.ProductID = product.Id;
            //od.ActivationCode = "222";
            //od.OrderQty = 2;
            //od.OrderStatus = "Purchase";
            //dbcontext.Add(od);

            //OrderDetails od1 = new OrderDetails();
            //od1.Id = "2";
            //od1.OrderID = o1.Id;
            //od1.ProductID = product1.Id;
            //od1.ActivationCode = "111";
            //od1.OrderQty = 3;
            //od1.OrderStatus = "Purchase"; 
            //dbcontext.Add(od1);
            
            //OrderDetails od2 = new OrderDetails();
            //od2.Id = "3";
            //od2.OrderID = o2.Id;
            //od2.ProductID = product1.Id;
            //od2.ActivationCode = "123";
            //od2.OrderQty = 3;
            //od2.OrderStatus = "Purchase";

            //dbcontext.Add(od2);

            dbcontext.SaveChanges();
            

            /*
            product = dbcontext.Products
                .Where(x => x.Name == "Photoshop")
                .FirstOrDefault();
            if(product!= null)
            {
                Debug.WriteLine(product.Name);
            }*/

        }
    }
}
