using System;

class Encryptor
{
  static void Main()
  {
    Console.WriteLine("Please input phrase to convert");
    string userInput = Console.ReadLine();
    Encryption(userInput);
    Decode(Console.ReadLine());
  }

  static void Encryption(string phrase)
  {
    phrase = phrase.ToLower();
    string encryptedPhrase = phrase.Replace("a","don't ").Replace("b", "forget ").Replace("c","to ").Replace("d","drink ").Replace("e","your ").Replace("f","Ovaltine ").Replace("g","more ").Replace("h","please ").Replace("i","Little ").Replace("j","Orphan ").Replace("k","Annie's ").Replace("l","Secret ").Replace("m","Sleuth ").Replace("n","Society ").Replace("o","Transcoder ").Replace("p","Ralphie! ").Replace("q","Just a minute, Ma! ").Replace("r","sopa ").Replace("s","Taco Bell ").Replace("t","stoners ").Replace("u","drunks ").Replace("v","psychobabble ").Replace("w","witness protection ").Replace("x","programs ").Replace("y","who ").Replace("z","why? ");
    Console.WriteLine(encryptedPhrase);
  }

  static void Decode(string encryptedPhrase)
  {
    string decodedPhrase = encryptedPhrase.Replace("why? ","z");
    decodedPhrase = decodedPhrase.Replace("who ","y");
    decodedPhrase = decodedPhrase.Replace("programs ","x");
    decodedPhrase = decodedPhrase.Replace("witness protection ","w");
    decodedPhrase = decodedPhrase.Replace("psychobabble ","v");
    decodedPhrase = decodedPhrase.Replace("drunks ","u");
    decodedPhrase = decodedPhrase.Replace("stoners ","t");
    decodedPhrase = decodedPhrase.Replace("Taco Bell ","s");
    decodedPhrase = decodedPhrase.Replace("sopa ","r");
    decodedPhrase = decodedPhrase.Replace("Just a minute, Ma! ","q");
    decodedPhrase = decodedPhrase.Replace("Ralphie! ","p");
    decodedPhrase = decodedPhrase.Replace("Transcoder ","o");
    decodedPhrase = decodedPhrase.Replace("Society ","n");
    decodedPhrase = decodedPhrase.Replace("Sleuth ","m");
    decodedPhrase = decodedPhrase.Replace("Secret ","l");
    decodedPhrase = decodedPhrase.Replace("Annie's ","k");
    decodedPhrase = decodedPhrase.Replace("Orphan ","j");
    decodedPhrase = decodedPhrase.Replace("Little ","i");
    decodedPhrase = decodedPhrase.Replace("please ","h");
    decodedPhrase = decodedPhrase.Replace("more ","g");
    decodedPhrase = decodedPhrase.Replace("Ovaltine ","f");
    decodedPhrase = decodedPhrase.Replace("your ","e");
    decodedPhrase = decodedPhrase.Replace("drink ","d");
    decodedPhrase = decodedPhrase.Replace("to ","c");
    decodedPhrase = decodedPhrase.Replace("forget ","b");
    decodedPhrase = decodedPhrase.Replace("don't ","a");
    Console.WriteLine(decodedPhrase);
  }
}
