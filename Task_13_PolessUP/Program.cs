public class VersionComparer
{
    public int CompareVersions(string version1, string version2)
    {
        string[] revisions1 = version1.Split('.');
        string[] revisions2 = version2.Split('.');

        int maxLength = Math.Max(revisions1.Length, revisions2.Length);

        for (int i = 0; i < maxLength; i++)
        {
            int revision1 = i < revisions1.Length ? int.Parse(revisions1[i]) : 0;
            int revision2 = i < revisions2.Length ? int.Parse(revisions2[i]) : 0;

            if (revision1 < revision2)
                return -1;

            if (revision1 > revision2)
                return 1;
        }

        return 0;
    }
}
class Program
{
    static void Main(string[] args)
    {
        VersionComparer comparer = new VersionComparer();
        Console.WriteLine(comparer.CompareVersions("1.0", "1.1"));   
        Console.WriteLine(comparer.CompareVersions("1.2.3", "1.2.3"));  
        Console.WriteLine(comparer.CompareVersions("2.0", "1.9.9"));  

    }
}
