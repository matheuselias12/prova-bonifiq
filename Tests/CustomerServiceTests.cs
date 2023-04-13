using ProvaPub.Services;
using Xunit;

namespace ProvaPub.Tests
{
    public class CustomerServiceTests
    {
        CustomerService _customerService;
        public CustomerServiceTests(CustomerService customerService)
        {
            _customerService = customerService;
        }

        [Fact]
        public async void Teste()
        {

            // Arrange
            decimal purchaseValue = 1000;
            int customerId = 1;

            // Act
            var result = await _customerService.CanPurchase(customerId,purchaseValue);

            // Assert
            Assert.True(result);
        }
    }
}
