int Poka0()
{
    int ans = 0;
    int slogaemoe = 0;
    do
    {
        slogaemoe = Convert.ToInt32(Console.ReadLine());
        ans = ans + slogaemoe;
    }
    while (slogaemoe != 0);
    return ans;
}
Console.WriteLine(Poka0());