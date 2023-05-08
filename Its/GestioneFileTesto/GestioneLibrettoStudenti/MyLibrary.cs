public class MyLibrary
{
    public static string Lettura(string path)
    {
        try
        {
            StreamReader SR = new StreamReader(path);
            string t = string.Empty;
            t = SR.ReadToEnd();
            SR.Close();
            return t;
        }
        catch (FileNotFoundException)
        {
            throw new Exception();
        }
        catch (Exception)
        {
            throw new Exception();
        }


    }
    public static void Scrittura(string path, string testo)
    {
        StreamWriter SW = new StreamWriter(path);
        SW.WriteLine(testo);
        SW.Flush();
        SW.Close();
    }
   

}

