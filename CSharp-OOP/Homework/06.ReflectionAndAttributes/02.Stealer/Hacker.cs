
namespace _02.Stealer
{
    public class Hacker
    {
        private string username = "securityGod82";
        public string password = "mySuperSecretPassw0rd";

        public string PassWord
        {
            get => password;
            set => password = value;
        }

        private int Id { get; set; }
        public double BankAccountBalance { get; private set; }
        public void DownloadAllBankAccountsInTheWorld()
        {

        }
    }
}
