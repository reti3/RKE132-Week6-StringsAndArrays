// massiivid = arrays
// kasutatakse selleks, et salvestada teatud anmeid teatud kohas
// Ühes massiivis võib olla ühte tüüpi andmed
// tähis []

//string[] fruit = { "apples", "bananas", "oranges" }; // massiivi deklareerimine
string[] fruit = new string[3];// elemendid ei ole deklareeritud; string tüüpi ja 3 tk

fruit[0] = "apples";
fruit[1] = "bananas";
fruit[2] = "oranges";
Console.WriteLine($"{fruit[0]}, {fruit[1]}, {fruit[2]}");

int fruitArrayLenght = fruit.Length; // kui ei tea, palju elemente tuleb

Console.WriteLine($"There are {fruitArrayLenght} in your array.");

for (int i = 0; i < fruitArrayLenght; i++) //mis elemendid on
{
    fruit[i] = fruit[i].Replace(fruit[i][0], char.ToUpper(fruit[i][0])); //kui i väärtus on 0 (apples)
}

foreach (string element in fruit) // iga sõne massiivis; väärtusi muuta selle käsuga ei ole võimal#if #if true

{
    Console.WriteLine(element);
}


