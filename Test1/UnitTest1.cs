namespace Test1
{
    public class Tests
    {
        Monopoly m;
        Random r;
        [SetUp]
        public void Setup()
        {
            m = new Monopoly();
            r = new Random();
        }

        [Test]
        public void Test1()
        {
            bool passed = true;
            for(int i = 0; i < 1000; i++)
            {
                int a = r.Next(1, 7);
                int b = r.Next(1, 7);
                int total = a + b;
                if(a == b)
                {
                    if (!m.Roll(1, a, b).Equals("You move " + total + ". Roll again.")) passed = false;
                }
                else
                {
                    if (!m.Roll(1, a, b).Equals("You move " + total + ".")) passed = false;
                }
            }
            if (passed) Assert.Pass();
            else Assert.Fail("An output in your 1st roll was found to be incorrect.");
        }
    }
}