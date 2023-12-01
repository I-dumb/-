int Poka100()
{
    int ans = 0;
    int slogaemoe = 0;
    int kolvo = 0;
    do
    {
        slogaemoe = Convert.ToInt32(Console.ReadLine());
        ans = ans + slogaemoe;
        kolvo++;
    }
    while (ans < 100);
    return kolvo;
}
Console.WriteLine(Poka100());
