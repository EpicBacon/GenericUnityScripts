using System.Collections.Generic;


public static class BaconConsole
{
    public static List<string> Lines
    {
        get { return lines; }
    }

    private static int		maxline = 4;
    private static readonly List<string> lines;

    static BaconConsole()
    {
        lines = new List<string>();
    }

    
	
	public static void 	WriteLine(string toadd)
	{
        if (Lines != null)
		Lines.Add(toadd);
		if (Lines.Count > maxline)
			Lines.RemoveAt(0);
	}

}
