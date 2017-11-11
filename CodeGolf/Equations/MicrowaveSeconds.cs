namespace CodeGolf.Equations
{
    /// <summary>
    /// https://codegolf.stackexchange.com/questions/147777/how-long-should-my-microwave-run
    /// </summary>
    public class MicrowaveSeconds
    {
        public int GetSeconds(int input) => input / 100 * 60 + input % 100;
    }
}