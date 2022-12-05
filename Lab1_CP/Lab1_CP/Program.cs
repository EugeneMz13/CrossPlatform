string path = ("C:\\Users\\eugene\\source\\repos\\Lab1_CP\\Lab1_CP\\INPUT.txt");
string inputfile = File.ReadAllText(path);
List<string> inputnum = new List<string>();
inputnum = inputfile.Split(' ').ToList();
int a = Convert.ToInt32(inputnum[0]);
int b = Convert.ToInt32(inputnum[1]);
int s = 0;
if (a > 1000 || b > 1000)
{
    string incorrect = "a and b should be <1000";
    File.WriteAllText("C:\\Users\\eugene\\source\\repos\\Lab1_CP\\Lab1_CP\\OUTPUT.txt", incorrect);
}
else
{
    for (int i = 1; i != a + 1; ++i)
    {
        for (int j = 1; j != b + 1; ++j)
        {
            s += i * j;
        }
    }
    string res = Convert.ToString(s);
    File.WriteAllText("C:\\Users\\eugene\\source\\repos\\Lab1_CP\\Lab1_CP\\OUTPUT.txt", res);
}