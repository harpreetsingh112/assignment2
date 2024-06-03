using Assignment_02;
namespace ProductTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void ProductTestID1()
        {
            var product = new Product(100, "Dell", 37.0, 50);
            product.ProductID = 100;
            //Asset to run Test and check value is equal or not   
            Assert.That(product.ProductID, Is.EqualTo(100));
        }

        [Test]
        public void ProductTestID2()
        {
            var product = new Product(200, "Acer", 10.0, 150);
            product.ProductID = 200;
            //Asset to run Test and check value is equal or not
            Assert.That(product.ProductID, Is.EqualTo(200));
        }

        [Test]
        public void ProductTestID3()
        {
            var product = new Product(30, "Lenovo", 10.0, 135);
            product.ProductID = 30;
            //Asset to run Test and check value is equal or not
            Assert.That(product.ProductID, Is.EqualTo(30));
        }

        [Test]
        public void ProductNameTest1()
        {
            var product = new Product(1, "Apple", 20.0, 120);
            product.ProductName = "Apple";
            //Asset to run Test and check value is equal or not
            Assert.That(product.ProductName, Is.EqualTo("Apple"));
        }

        [Test]
        public void ProductNameTest2()
        {
            var product = new Product(2, "ASUS", 20.0, 110);
            product.ProductName = "ASUS";
            //Asset to run Test and check value is equal or not
            Assert.That(product.ProductName, Is.EqualTo("ASUS"));
        }

        [Test]
        public void ProductNameTest3()
        {
            var product = new Product(3, "HP", 20.0, 90);
            product.ProductName = "HP";
            //Asset to run Test and check value is equal or not
            Assert.That(product.ProductName, Is.EqualTo("HP"));
        }

        [Test]
        public void PriceTest1()
        {
            var product = new Product(101, "Lenovo", 10.0, 70);
            product.Price = 10.0;
            //Asset to run Test and check value is equal or not
            Assert.That(product.Price, Is.EqualTo(10.0));
        }

        [Test]
        public void PriceTest2()
        {
            var product = new Product(201, "Dell", 20.0, 90);
            product.Price = 20.0;
            //Asset to run Test and check value is equal or not
            Assert.That(product.Price, Is.EqualTo(20.0));
        }

        [Test]
        public void PriceTest3()
        {
            var product = new Product(3, "Dell", 30.0, 95);
            product.Price = 30.0;
            //Asset to run Test and check value is equal or not
            Assert.That(product.Price, Is.EqualTo(30.0));
        }

        [Test]
        public void StockTest1()
        {
            var product = new Product(1, "Asus", 40.0, 90);
            product.Stock = 90;
            //Asset to run Test and check value is equal or not
            Assert.That(product.Stock, Is.EqualTo(90));
        }

        [Test]
        public void StockTest2()
        {
            var product = new Product(2, "Apple", 40.0, 80);
            product.Stock = 80;
            //Asset to run Test and check value is equal or not
            Assert.That(product.Stock, Is.EqualTo(80));
        }

        [Test]
        public void StockTest3()
        {
            var product = new Product(3, "Apple", 40.0, 120);
            product.Stock = 120;
            //Asset to run Test and check value is equal or not
            Assert.That(product.Stock, Is.EqualTo(120));
        }

        [Test]
        public void IncreaseStockTest1()
        {
            var product = new Product(1, "Dell", 31.0, 120);
            product.IncreaseStockMethod(30);
            //Asset to run Test and check value is equal or not
            Assert.That(product.Stock, Is.EqualTo(150));
        }

        [Test]
        public void IncreaseStockTest2()
        {
            var product = new Product(2, "Acer", 21.0, 150);
            product.IncreaseStockMethod(5);
            //Asset to run Test and check value is equal or not
            Assert.That(product.Stock, Is.EqualTo(155));
        }

        [Test]
        public void IncreaseStock3Test3()
        {
            var product = new Product(3, "Apple", 22.0, 160);
            product.IncreaseStockMethod(30);
            //Asset to run Test and check value is equal or not
            Assert.That(product.Stock, Is.EqualTo(190));
        }

        [Test]
        public void DecreaseStockTest1()
        {
            var product = new Product(1, "ASUS", 24.0, 120);
            product.DecreaseStockMethod(20);
            //Asset to run Test and check value is equal or not
            Assert.That(product.Stock, Is.EqualTo(100));
        }

        [Test]
        public void DecreaseStockTest2()
        {
            var product = new Product(1, "Acer", 19.0, 100);
            product.DecreaseStockMethod(10);
            //Asset to run Test and check value is equal or not
            Assert.That(product.Stock, Is.EqualTo(90));
        }

        [Test]
        public void DecreaseStockTest3()
        {
            var product = new Product(1, "HP", 18.0, 130);
            product.DecreaseStockMethod(30);
            //Asset to run Test and check value is equal or not
            Assert.That(product.Stock, Is.EqualTo(100));
        }

    }
}