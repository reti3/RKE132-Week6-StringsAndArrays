string hello = "welcome to my world?";
int stringLenght = hello.Length; //kui pikk sõne on

// kuidas tühikust lahti saada, nii sõne ees ja taga
string trimmedString = hello.Trim();

hello = hello.Trim();
char firstLetter = hello[0]; //esimene täht lauses, kohal 0
Console.WriteLine(firstLetter);


//hello = hello.Replace(hello[0], 'H'); // esimesel kohal (0) on mida soovin muuta ning teisel ('H') mida soovin asemele
hello = hello.Replace(hello[0], char.ToUpper(hello[0])) .Replace('?', '!'); //muudab esimese tähe suureks täheks

firstLetter = hello[0]; //väärtuse ümbersalvestamine
Console.WriteLine(firstLetter);
Console.WriteLine(hello);


/* kommentaar algab

Console.WriteLine(trimmedString.Length);



// teine variant, kuidas tühikutest lahti saada
hello = hello.Trim();
Console.WriteLine(hello.Length);

int wordCounter = 0;
//int wordCounter = 1; - siis ei pea järgnevasse lisama ühte
// Console.WriteLine($"Word count in {hello}: {wordCounter} words.");

for (int i = 0; i < hello.Length ; i++)
{
    if (hello[i] == ' ')
    {
        wordCounter++;
    }
    //Console.WriteLine($"{i} symbol in string: {hello[i]}"); //mis kohal asub mingi täht
}

for (int i = 0; i < hello.Length; i++)
{
    if (char.IsWhiteSpace(hello[i])) //tagastab kate väärtust, true (kui näeb tühikut) või false
    {
        wordCounter++;
    }
    //Console.WriteLine($"{i} symbol in string: {hello[i]}"); //mis kohal asub mingi täht
}


// Console.WriteLine(stringLenght); // mitu ühikut on sõnes (string)
Console.WriteLine($"Word count in {hello}: {wordCounter +1} words."); //+1, sest ühikuid on lauses vähem kui sõnu

kommentaar lõpeb */  