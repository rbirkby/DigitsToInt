using System;
using System.Collections.Generic;
using System.Linq;

class X {
  static void Main(string[] args) {
    foreach(int i in DigitsToInt(string.Join("", args))) {
      Console.WriteLine(i);	
    }
  }

  private static IEnumerable<int> DigitsToInt(string digits) {
    return from ch in digits
      where ch > '0' && ch < '9'
      select ch - '0';
  }
}
