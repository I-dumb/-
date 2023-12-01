int Sum(int x, int y)
{
    if(x>y)
    {
        return 0;
    }
    int ans = x;
    while (x < y)
    {
        x++;
        ans = ans + x;

    }
    return ans;

}
Console.WriteLine(Sum(10, 9));
