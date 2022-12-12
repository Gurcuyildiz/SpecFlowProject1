

  public class Example
{

    /*the bool type  keyword is an alias for the .Net Sysytem.Boolean structure type that represent a Boolean
     value which can be either true or false
    */
    public static void Main()
    {

        bool check = true;

        Console.WriteLine(check ? "Checked" : "Not checked"); // output : Checked

        Console.WriteLine(false ? "Checked" : "Not checked"); // output : Not checked
    }

    // Converting Boolean values to strings: ToString


    //Parsing strings to convert them to Boolean values: Parse and TryParse


    //Comparing values : CompareTo and Equals

}


