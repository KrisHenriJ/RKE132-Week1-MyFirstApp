// JOU MEES

//rakendus küsib kasutajal sisestada tema nime
//rakendus tervitab kasutajat nimepidi

Console.WriteLine("Enter your name");
//string-sõne

string userName = Console.ReadLine();

Console.WriteLine("Hello" + ", " + userName + " !"); //output
    //string interpolation

Console.WriteLine($"Hello {userName} !"); //output