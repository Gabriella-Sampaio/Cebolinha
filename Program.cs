Console.Clear();

string primTexto;
string primLeet;
string segTexto;
string segLeet;
string terTexto;
string terLeet;

Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("*** VOCÊ CONTRA O CEBOLINHA ***"); Thread.Sleep(1000);
Console.WriteLine("😜      a brincadeira        😜"); Thread.Sleep(1000);
Console.ResetColor();
Console.WriteLine();

Console.WriteLine(@"
Funciona assim:
Você vai escrever um texto e o cebolinha vai imitar tudo
Vamos tentar, complete: ");Thread.Sleep(2500);
Console.WriteLine();

Console.ForegroundColor= ConsoleColor.Blue;
Console.WriteLine("o rato roeu a roupa...");
Console.ResetColor(); Thread.Sleep(1000);

Console.Write("Sua vez: ");
primTexto = Console.ReadLine()!;
primLeet = primTexto
    .Replace("r", "l")
    .Replace("R", "L"); Thread.Sleep(500);
Console.WriteLine();

Console.ForegroundColor= ConsoleColor.Green;
Console.Write("Cebolinha: "); Thread.Sleep(500);
Console.ResetColor();
Console.WriteLine($"{primLeet} 😏");Thread.Sleep(2500);
Console.Clear();



Console.WriteLine("Muito bem, agora desafie o cebolinha a falar certo"); Thread.Sleep(500);
Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write("Sua vez: ");
Console.ResetColor();

segTexto = Console.ReadLine()!;
segLeet = segTexto
    .Replace("r", "l")
    .Replace("R", "L"); Thread.Sleep(500);
Console.WriteLine();

Console.ForegroundColor= ConsoleColor.Green;
Console.Write("Cebolinha: "); Thread.Sleep(500);
Console.ResetColor();
Console.WriteLine($"{segLeet} 😝"); Thread.Sleep(2500);
Console.Clear();



Console.WriteLine("Continue, você consegue"); Thread.Sleep(500);
Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write("Sua vez: ");
Console.ResetColor();

terTexto = Console.ReadLine()!;
terLeet = terTexto
    .Replace("r", "l")
    .Replace("R", "L"); Thread.Sleep(500);
Console.WriteLine();

Console.ForegroundColor= ConsoleColor.Green;
Console.Write("Cebolinha: "); Thread.Sleep(500);
Console.ResetColor();
Console.WriteLine($"{terLeet.Substring(0, 5)}... Desiste, você não vai ganhal do dono da lua 😉"); Thread.Sleep(2500);
Console.WriteLine();
Console.WriteLine();

Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("*** Fim da brincadeira ***");
Console.ResetColor();