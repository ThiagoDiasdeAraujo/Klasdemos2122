using NUnit.Framework;

namespace WebShop.Tests
{
    [TestFixture]
    internal class CustomerTests
    {
        [SetUp]
        public void SetUp()
        {

        }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {

        }

        [TearDown]
        public void TearDown()
        {

        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {

        }

        [Test]
        public void Purchase_WithEnoughInventory_PurchaseSucceed()
        {
            // Arrange
            Customer sut = new Customer();
            Store store = CreateStoreWithStock(Product.Shampoo, 10);
            int quantityToPurchase = 5;



            // Act
            bool result = sut.Purchase(store, Product.Shampoo, quantityToPurchase);

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(5, sut.Basket[Product.Shampoo]);
            Assert.AreEqual(5, store.GetInventory(Product.Shampoo));
        }

        [Test]
        public void Purchase_WithNotEnoughInventory_PurchaseFails()
        {

            // Arrange
            Customer sut = new Customer();
            Store store = CreateStoreWithStock(Product.IceCream, 10);
            int quantityToPurchase = 15;

            // Act
            bool result = sut.Purchase(store, Product.IceCream, quantityToPurchase);

            // Assert
            Assert.IsFalse(result);
            Assert.IsEmpty(sut.Basket);
            Assert.AreEqual(10, store.GetInventory(Product.IceCream));
        }


        public Store CreateStoreWithStock(Product product, int quantity)
        {
            Store store = new Store();

            store.AddInventory(product, quantity);

            return store;
        }
    }

}
