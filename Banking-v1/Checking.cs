namespace Banking_v1 {
    public class Checking {
        private Account _Account { get; set; }
        private static int NextCheckNo = 100;
        public int CheckNo { get; set; }
        public int AccountNo => _Account.AccountNo;
        public decimal Balance { get { return _Account.Balance; } }
        public string Description { get { return _Account.Description; } set { _Account.Description = value; } }
        /*public int AccountNo { get { return _Account.AccountNo; }}*/
        public Checking() {
            _Account = new Account();

        }

        public void print() {
            _Account.Print();
        }
        public bool WriteCheck(decimal Amount) {
            if (!Withdraw(Amount))
                return false;
            int checkno = NextCheckNo++;
            return true;
            //Console.WriteLine("#"+checkno+" for $"+Amount);
        }
        public bool Deposit(decimal Amount) {
            return _Account.Deposit(Amount);
        }
        public bool Withdraw(decimal Amount) {
            return _Account.Withdraw(Amount);
        }
        public void Transfer(Checking Checking, decimal amount) {
            if (this.Withdraw(amount)) {
                Checking.Deposit(amount);
                return;
            } else {
                Console.WriteLine("Transfer Failed ");
            }
        }
    }
}
