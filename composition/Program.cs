// See https://aka.ms/new-console-template for more information

using inheritance;

var choice = 0;
do
{
    choice = readchoice(choice);
    if(choice >=1 && choice <= 2)
    {
        var e = choose(choice);
        Console.WriteLine(e);
        Console.WriteLine("press any key");
    }
    Console.ReadKey();
       

}while (choice != 0);

static int readchoice(int choice)
{
    Console.WriteLine("which one");
    Console.WriteLine("------------");
    Console.WriteLine("1-overtime");
    Console.WriteLine("2-Residence");
    if (int.TryParse(Console.ReadLine(), out int ch))
    {
        choice = ch;
    }


    return choice;
}
static employees choose(int choice)
{
    employees e = null;
    switch (choice)
    {
        case 1:
            e = new overtime();
            break;
        case 2:
            e = new Residence();
            break;
        default:
            break;
    }
    return e;
}