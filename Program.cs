namespace Eurojackpot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserInput.SelectNumberOfBoards();
            NumberSelection.SelectNumbers(UserInput.NumberOfBoards);
        }
    }
}
