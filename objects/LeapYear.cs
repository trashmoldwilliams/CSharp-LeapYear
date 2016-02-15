using System.Collections.Generic;

namespace LeapYearNS.Objects
{
  public class LeapYear
  {
    public LeapYear()
    {

    }

    public bool IsLeapYear(int year)
    {
      return year % 4 == 0 && !(year % 100 == 0) || year % 400 == 0;
    }
  }
}
