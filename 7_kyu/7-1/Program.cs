// Завершите функцию, которая принимает строку текста на английском языке и возвращает количество согласных в строке.

char[] consonants = { 'б', 'в', 'г', 'д', 'ж', 'з', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ь'};
int consCounter = 0;

Console.WriteLine("Введите строку на русском языке");
string text = Console.ReadLine();
char[] textArray = text.ToCharArray();


foreach (char con in consonants)
{
    foreach (char c in textArray)
    {
        if (con == c) consCounter++;
    }
}

Console.WriteLine($"Во введенном тексте {consCounter} согласных букв");
