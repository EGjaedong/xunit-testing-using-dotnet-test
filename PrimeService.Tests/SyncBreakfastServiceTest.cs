using System;
using Xunit;

namespace PrimeService.Tests
{
    public class SyncBreakfastServiceTest
    {
        private readonly SyncBreakfastService _syncBreakfastService;

        public SyncBreakfastServiceTest()
        {
            _syncBreakfastService = new SyncBreakfastService();
        }

        [Fact]
        public void execute_sync_cook_method()
        {
            _syncBreakfastService.SyncCook();
        }

        [Fact]
        public void test()
        {
            const string paymentType = "AliPay";
            var type = (PaymentType) Enum.Parse(typeof(PaymentType), paymentType);
            Assert.Equal(PaymentType.AliPay,type);
        }

        public enum PaymentType
        {
            WeChatPay,
            AliPay
        }
    }
}