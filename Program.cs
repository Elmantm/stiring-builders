// See https://aka.ms/new-console-template for more information
using ConsoleApp9;


string_builders sb = new string_builders();
sb.CustomBuilder();
sb.Append('a');
sb.Append('b');
sb.Append('c');
sb.Append('d');
sb.Append('e');
sb.Append('f');
sb.Append('y');
sb.Append('g');
sb.Append('l');
sb.Append('x');
sb.ReplaceChar('c', 'r');
Console.WriteLine(sb.GetResult());