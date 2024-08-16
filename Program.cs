// --> Bu yerda savollar va javoblar saqlanadi.
var questions = new List<(string question, List<string> answers, int correctAnswerIndex)>();

// --> Bu yerda savollar va javoblarni qoshiladi.
while (true)
{
    Console.WriteLine("Savol kiriting (yoki chiqish uchun 'exit' deb yozing):");
    string question = Console.ReadLine()!;
    if (question.ToLower() == "exit") break;

    // --> ToLower() - string (matn) tipidagi ma'lumotlarni kichik harflarga o'tkazish uchun ishlatiladi. 

    var answers = new List<string>();
    Console.WriteLine("Javoblarni kiriting (bo'sh qator kiriting, tugatish uchun):");
    while (true)
    {
        string answer = Console.ReadLine()!;
        if (string.IsNullOrWhiteSpace(answer)) break;
        answers.Add(answer);
    }

    Console.WriteLine("To'g'ri javobning raqamini kiriting:");
    int correctAnswerIndex = int.Parse(Console.ReadLine()!);

    questions.Add((question, answers, correctAnswerIndex));
}

// --> Bu yerda savollarni ko'rsatiladi va javoblarni tekshiriladi.
int correctCount = 0;
int wrongCount = 0;

foreach (var (question, answers, correctAnswerIndex) in questions)
{
    Console.WriteLine($"\n{question}");
    for (int i = 0; i < answers.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {answers[i]}");
    }

    Console.WriteLine("Javob raqamini tanlang:");
    int userAnswer = int.Parse(Console.ReadLine()!);

    if (userAnswer == correctAnswerIndex)
    {
        Console.WriteLine("To'g'ri javob!");
        correctCount++;
    }
    else
    {
        Console.WriteLine("Noto'g'ri javob!");
        wrongCount++;
    }
}

// --> Yakuniy hisobni ko'rsatadi
Console.WriteLine($"\nTo'g'ri javoblar soni: {correctCount}");
Console.WriteLine($"Noto'g'ri javoblar soni: {wrongCount}");
