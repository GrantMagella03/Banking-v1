
using Banking_v1;
using System.Security.Cryptography.X509Certificates;

namespace BankTest01 {
    public class TestSavings {
        Savings? Sav1 = null;
        Savings? Sav2 = null;
        public TestSavings() {
            Sav1 = new();
            Sav2 = new();
        }
        [Theory]
        [InlineData(100,100,0)]
        [InlineData(200,300,100)]
        [InlineData(-100,300,300)]
        public void TestDepo(decimal IN, decimal OUT, decimal START) {
            Sav1.Balance = START;
            Sav1.Deposit(IN);
            //Assert.True(Sav1.Deposit(IN));
            Assert.Equal(OUT, Sav1.Balance);
        }
        [Theory]
        [InlineData(37.89,100,137.89)]
        [InlineData(999999999,0,999999999)]
        [InlineData(-237.88,100000,100000)]
        public void TestWithdraw(decimal IN, decimal OUT, decimal START) {
            Sav1.Balance = START;
            Sav1.Withdraw(IN);
            Assert.Equal(OUT, Sav1.Balance);
        }
        [Theory]
        [InlineData(100,100,100,0,200)]
        [InlineData(-137,101,-100,-137,101)]
        [InlineData(-11789,99878,1,-11789,99878)]
        public void TestTransfer(decimal A1S, decimal A2S, decimal IN, decimal A1OUT, decimal A2OUT) {
            Sav1.Balance = A1S;
            Sav2.Balance = A2S;
            Sav1.transfer(Sav2, IN);
            Assert.Equal(A1OUT, Sav1.Balance);
            Assert.Equal(A2OUT, Sav2.Balance);
        }
        //[Theory]
        //public void TestCalcIntByMonth() {

        //}
    }
}