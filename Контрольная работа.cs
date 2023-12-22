dynamic StudyReg(string name, int age,string gender,float x)
{
    dynamic[] study = new dynamic[4];
    study[0] = name;
    study[1] = age; 
    study[2] = gender;
    study[3] = x;
    return study;
}


dynamic[] NumsOpp()
{
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    return new dynamic[] { "Сложение:"+(a+b), "Вычитание:"+(a-b),"Умножение:"+(a*b),"Деление по модулю:"+(a%b),"Деление:"+(a/b)};
}


string Sover()
{
    int x=Convert.ToInt32(Console.ReadLine());
    return x >= 18 ? "Вы совершенолетний" : "Вы несовершенолетний";
}


int[] Continue()
{
    int n=Convert.ToInt32((Console.ReadLine()));
    int[] answ = new int[n];
    int j = 0;
    int i = 1;
    while(j<answ.Length)
    {
        answ[j] = i;
        j++;
        i++;
    }
    return answ;
}


int SumOfRandom()
{
    int sum = 0;
    int[] x=new int[10];
    Random rand = new Random();
    for (int i = 0; i < x.Length; i++)
    {
        x[i] = rand.Next(1,50);
        Console.WriteLine(x[i]);
    }
    for(int i=0;i<x.Length;i++)
    {
        sum=sum+x[i];
    }
    return sum;
}
