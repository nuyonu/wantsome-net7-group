namespace OOP.Advanced
{
    internal class Account
    {
        private decimal balance;

        public decimal Balance 
        {
            get { return this.balance; }
            set 
            {
                // Behind value = 20_000;
                if (value < 0)
                {
                    throw new Exception("Can't assign negative values to balance.");
                }

                this.balance = value; 
            }
        }

        public int Example { get; set; }

        public void AddBalance(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
            else
            {
                throw new Exception("Amount can't be negative.");
            }
        }

        //public decimal GetBalance()
        //{
        //    return balance;
        //}
    }
}
