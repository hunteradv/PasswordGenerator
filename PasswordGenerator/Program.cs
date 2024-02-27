var _random = new Random();
const string _chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
const string _specialChars = "!@#$%^&*()";

string GeneratePassword(int length, bool includeSpecialChars)
{
    var chars = includeSpecialChars ? _chars + _specialChars : _chars;

    return new string(Enumerable.Repeat(chars, length).Select(x => x[_random.Next(x.Length)]).ToArray());
}

Console.WriteLine(GeneratePassword(8, true));