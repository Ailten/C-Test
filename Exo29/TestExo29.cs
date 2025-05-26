

//[TestClass] // mark as class test.
public class TestExo29
{
    //[TestMethod] // mark as a methode for test.
    public void VerifyIfDivideFilterZeroDivision()
    {
        // build test situation.
        Exo29 exo29 = new Exo29();

        // try.
        try
        {
            exo29.divide(10, 0); // do the test.
        }
        catch (DivideByZeroException exception)
        {
            //StringAssert.Contains(exception.Message, BankAccount.DebitAmountExceedsBalanceMessage);
        }
    }
}