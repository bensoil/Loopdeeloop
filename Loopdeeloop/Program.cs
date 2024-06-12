//OPPGAVE 1
    void forLoop()
    {
        for (int i = 0; i < 5; i++) {

        Console.WriteLine("Terje er kul");
        
        }
    }

forLoop();

//OPPGAVE 2

void forEachLoop()
{
    string bargs = "Hello";
    foreach (char c in bargs)
    {
        Console.WriteLine(c);
    }
}

forEachLoop();

//OPPGAVE 3

void WhileLoop(){

    bool condish = true;
int roundTime  = 0;

while (condish)
{
    if (roundTime < 10)
    {
        Console.WriteLine($"Rundenummer: {roundTime}");
            roundTime++;
    } else
    {
        condish = false;
    }

}

}
WhileLoop();