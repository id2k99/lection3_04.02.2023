// Вид 1

void Method1()
{
    Console.WriteLine("Я автор программы");
}

// Method1();



//Вид 2

void Method2(string msg)
{
    Console.WriteLine(msg);
}

// Method2("Текст сообщения");

void Method2_1(string msg, int count)
{   
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
    Console.WriteLine(msg);
}

// Method2_1("Текст сообщения", 4);
// Method2_1(msg: "Текст сообщения", count: 4);


//ВИд 3

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
// Console.WriteLine(year);

// Вид 4

// с циклом while
string Method4(int count,string text)
{
    int i = 0;
    string result = String.Empty;

    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(4, "Текст");
// Console.WriteLine(res);

// с циклом for
string Method4_1(int count,string text)
{
    string result = String.Empty;
    for(int i = 0;  i < count; i++)
    {
        result = result + text;
            }
    return result;
}

string res1 = Method4_1(4, "Текст1");
// Console.WriteLine(res1);



// цикл в цикле

 for(int i = 2;  i <= 10; i++)
{
    for(int j = 2;  j <= 10; j++)
    {
        Console.WriteLine($"{i}*{j} = {i*j}");
    }
    Console.WriteLine();
}

