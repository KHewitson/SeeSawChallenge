namespace SeeSawChallenge.Incomplete
{
    public class Logic
    {
        private readonly ISeeSaw _seeSaw;

        public Logic(ISeeSaw seeSaw)
        {
            _seeSaw = seeSaw;
        }

        public Guess Guess()
        {
            var result = _seeSaw.Balance(new[] { "A" }, new[] { "L" });

            return new Guess("C", false);
        }
    }

    public class Guess
    {
        public Guess(string person, bool isHeavier)
        {
            Person = person;
            IsHeavier = isHeavier;
        }
        public string Person { get; }
        public bool IsHeavier { get; }
    }
}