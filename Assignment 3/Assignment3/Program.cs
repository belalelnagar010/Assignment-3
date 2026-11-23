// ===== Q1: && operator =====
int pages = 464;
bool isAvailable = true;
Console.WriteLine("--- Q1 ---");
if (pages > 300 && isAvailable)
{
    Console.WriteLine("You can borrow this book");
}

// ===== Q2: switch statement =====
Console.WriteLine("\n--- Q2 ---");
string title = "Refactoring";
switch (title)
{
    case "Clean Code":
        Console.WriteLine("Great choice!");
        break;
    case "Refactoring":
        Console.WriteLine("Nice pick!");
        break;
    default:
        Console.WriteLine("Never heard of it");
        break;
}

// ===== Q3: ternary operator =====
Console.WriteLine("\n--- Q3 ---");
string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
Console.WriteLine(sizeLabel);

string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

// ===== Q4: for loop =====
Console.WriteLine("\n--- Q4 ---");
for (int i = 0; i < books.Length; i++)
{
    Console.WriteLine($"{i + 1}. {books[i]}");
}

// ===== Q5: while loop =====
Console.WriteLine("\n--- Q5 ---");
int index = 0;
while (index < books.Length)
{
    Console.WriteLine(books[index]);
    index++;
}

// ===== Q6: do-while loop =====
Console.WriteLine("\n--- Q6 ---");
int count = 0;
do
{
    Console.WriteLine("Checking book...");
    count++;
} while (count < 3);

// ===== Q7: foreach loop =====
Console.WriteLine("\n--- Q7 ---");
foreach (string book in books)
{
    Console.WriteLine(book);
}

// ===== Q8: break =====
Console.WriteLine("\n--- Q8 ---");
foreach (string book in books)
{
    Console.WriteLine(book);
    if (book == "Refactoring")
        break;
}

// ===== Q9: continue =====
Console.WriteLine("\n--- Q9 ---");
foreach (string book in books)
{
    if (book == "The Pragmatic Programmer")
        continue;
    Console.WriteLine(book);
}

// ===== Q10: return =====
Console.WriteLine("\n--- Q10 ---");
PrintFirstBook();

void PrintFirstBook()
{
    if (books.Length == 0)
        return;
    Console.WriteLine(books[0]);
}
