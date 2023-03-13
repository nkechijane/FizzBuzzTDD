using FluentAssertions;
namespace FizzBuzz.Test;


/*
 * 1) Do the simplest change to make the test satisfied.
 * 2) Work with what is already there. Try not break previous tests.
 * 3) Try to understand the 'dimensions' of the problem.
 *    e.g.: fizzbuzz, primefactors are all 'counting' so
 *          your dimension is numbers and counting is usually good.
 *          MarsRover is cardinal points (N,E,S,W) turning L or R and movement M.
 * 4) Complete 1 dimension before starting another.
 * 5) Use the 'rule of 3' to see patterns and avoid premature optimisation.
 *    Rule of 3 says you refactor when you see something occur repetitively 3 times
 * 6) Try not to think ahead too much
 * 7) Don't try to solve too many things at once
 */
public class FizzBuzzShould
{
    [Test]
    public void Return1WhenInputIs1()
    {
        var fizzBuzz = new FizzBuzz();
        var result = fizzBuzz.Output(1); 
        result.Should().BeEquivalentTo("1");
    } 
    
   [Test]
    public void Return2WhenInputIs2()
    {
        var fizzBuzz = new FizzBuzz();
        var result = fizzBuzz.Output(2);
        result.Should().BeEquivalentTo("2");
    }
}

public class FizzBuzz
{
    public string Output(int naturalNumber)
    {
        if (naturalNumber == 1)
        {
            return "1";
        }
        return "2";
    }
}