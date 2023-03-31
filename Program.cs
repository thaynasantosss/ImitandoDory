Console.WriteLine("*** Imitando Dory ***\n");

Console.Write(" diga uma frase para imitar a Dory: ");
string frase = Console.ReadLine()!;

string fraseEmBaleies = frase
    .Replace("a", "aaa")
    .Replace("á", "ááá")
    .Replace("Á", "ÁÁÁ")
    .Replace("A", "AAA")
    .Replace("e", "eee")
    .Replace("é", "ééé")
    .Replace("E", "EEE")
    .Replace("i", "iii")
    .Replace("I", "III")
    .Replace("o", "ooo")
    .Replace("O", "OOO")
    .Replace("u", "uuu")
    .Replace("U", "UUU")
    .Replace("É", "ÉÉÉ")
;

Console.WriteLine($"\nEm baleiês: {fraseEmBaleies}");
