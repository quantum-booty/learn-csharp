using System;

Console.WriteLine(0110 & 0100); // bitwise and
Console.WriteLine(0110 | 0100); // bitwise or
Console.WriteLine(0110 ^ 0100); // bitwise xor
Console.WriteLine(~0110); // = -111 = -7 due to overflow, bitwise not/compliment
Console.WriteLine(6 << 1); // bitwise left shift
Console.WriteLine(6 >> 1); // bitwise left shift


ContactPreferences emailAndPhone = ContactPreferences.Email | ContactPreferences.Phone;
Console.WriteLine(emailAndPhone);
Console.WriteLine((emailAndPhone | ContactPreferences.None) == emailAndPhone);
Console.WriteLine((emailAndPhone | ContactPreferences.Email) == emailAndPhone);
Console.WriteLine((emailAndPhone | ContactPreferences.Phone) == emailAndPhone);
Console.WriteLine((emailAndPhone | ContactPreferences.Text) == emailAndPhone);
Console.WriteLine(0b0001 | 0b0010);
Console.WriteLine((0b0001 | 0b0010) | 0b0000);


[Flags] // Flags attribute: allows pretty printing (ToString method) of combined enum values, otherwise it prints the integer value
public enum ContactPreferences
{
    None = 0b0001,
    Email = 0b0010,
    Phone = 0b0100,
    Text = 0b1000,
}
