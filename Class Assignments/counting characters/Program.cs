using System;
public class CountingCharacters {
    public static void Main() {
        string str = "This is a test string";
        Console.WriteLine("String: " + str);
        while (str.Length > 0) {
            Console.Write(str[0] + " = ");
            int cal = 0;
            for (int j = 0; j <str.Length; j++) {
                if (str[0] == str[j]) {
                    cal ++;
                }
            }
            Console.WriteLine(cal);
            str = str.Replace(str[0].ToString(), string.Empty);
        }
        Console.ReadLine();
    }
}
