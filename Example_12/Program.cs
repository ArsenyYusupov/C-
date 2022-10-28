// Вид 1
void Method1()
{
    Console.WriteLine("Автор ...");

}
Method1();

// Вид 2
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg:"Текст", count: 4);
Method21(count: 4, msg:" New text");

// Вид 3
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

// Вид 4
string Method4(int count, string c)
{
    string result = String.Empty;
    for ( int i = 0; i < count; i++)
    {
        result = result + c;
    }
    return result;
}
string res = Method4(10, "No6");
Console.WriteLine(res);