namespace TestATM
{
    public interface IUnitTest1
    {
        void TestWithdrawInvalid(global::System.Double num);
        void TestWithdrawValid(global::System.Double num);
        void ValidateCheckInvalidAmount();
        void ValidateCheckInvalidMenu();
        void ValidateCheckValidAmount();
        void ValidateCheckValidMenu();
    }
}