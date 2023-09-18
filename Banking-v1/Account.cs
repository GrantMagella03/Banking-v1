namespace Banking_v1 {
    public class Account {
        public static string RoutingNumber { get; set; } = "123 456 789";
        public decimal Balance { get; set; } = 0;
        public int AccountNo { get; set; }
        public static int NextAccountNo { get; set; } = 1;
        public string Description { get; set; } = string.Empty;
        public DateTime DateCreated { get; set; } = DateTime.Now;

        public Account() {
            AccountNo = NextAccountNo;
            NextAccountNo++;
        }
        public void Print() {
            Console.WriteLine($"#{AccountNo} [{Description}] ${Balance} DOC: {DateCreated}");
        }
        private bool IsPos(decimal Amt) {
            if (Amt <= 0) {
                Console.WriteLine("Amount must be greater than 0");
                return false;
            }
            return true;
        }
        public bool Deposit(decimal Amount) {
            if (IsPos(Amount)) {
                Balance += Amount;
                return true;
            }
            return false;
        }
        public bool Withdraw(decimal Amount) {
            if (Balance >= Amount && IsPos(Amount)) {
                Balance -= Amount;
                return true;
            }
            Console.WriteLine("Insufficient Funds");
            return false;
        }
        public void transfer(Account ToAccount, decimal Amount) {
            if (Withdraw(Amount)) {
                ToAccount.Deposit(Amount);
                return;
            }
        }

    }
}
