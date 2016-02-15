using Xunit;
using LeapYearNS.Objects;

namespace LeapYearNS
{
  public class LeapYearTest
  {

    [Fact]
    public void IsLeapYear_ForNumberDivisibleByFour_true()
    {
      // eventually your testing code will go here
      LeapYear testLeapYear = new LeapYear();
      Assert.Equal(true, testLeapYear.IsLeapYear(2012));
    }

    [Fact]
    public void IsLeapYear_ForNumberDivisibleByOneHundred_false()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.Equal(false, testLeapYear.IsLeapYear(1900));
    }

    [Fact]
    public void IsLeapYear_ForNumberDivisibleByFourHundred_true()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.Equal(true, testLeapYear.IsLeapYear(2000));
    }
    /**/
  }
}
