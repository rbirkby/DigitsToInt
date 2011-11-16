using System;
using System.Collections.Generic;
using System.Linq;

class X {
  static void Main(string[] args) {
    foreach(int i in DigitsToInt(string.Join("", args))) {
      Console.WriteLine(i);	
    }
  }

  private static int DigitToInt(char digit) {
    if(digit >= '0' && digit <= '9') return digit - '0';
    throw new ArgumentException("digit");
  }

  private static IEnumerable<int> DigitsToInt(string digits) {
    return digits.Where(ch => ch>='0' && ch<='9').Select(DigitToInt);
  }
}
