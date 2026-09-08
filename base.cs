class Program
{
    static void Main()
    {
       Console.WriteLine("Гласных: " + CountVowels("Привет, как дела?"));
    }

    static int CountVowels(string text){
        int sum = 0;
        char[] letters = {'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я'};
        for(int i = 0; i < text.Length; i++){
            if(letters.Contains(text[i])){
                sum++;
            }
        }
        return sum;
    }
}

