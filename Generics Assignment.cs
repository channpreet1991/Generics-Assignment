using System;
using System.Collections.Generic;

class Employee<T> {
      
    // public data member
    public List<T> things;
    
}
class Driver {
    
  static void Main() {
    Employee<string> e1 = new Employee<string>();

    e1.things = new List<string>()
                    {
                        "Computer",
                        "ID Card",
                        "Company Phone",
                    };
    foreach (string thing in e1.things)
        {
            Console.WriteLine(thing);
        }
    Employee<int> e2 = new Employee<int>();
    e2.things = new List<int>(){1,2,3,4,421};
    foreach (int thing in e2.things)
        {
            Console.WriteLine(thing);
        }
  }
}