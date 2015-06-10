using System.Collections.Generic;


public static class BaconConsole
{
    public static List<string> Lines
    {
        get { return lines; }
    }

    static int currentlinenumber = 0;

    private static int		maxline = 6;
    private static readonly List<string> lines;

    static BaconConsole()
    {
        lines = new List<string>();
    }

    
	
	public static void 	WriteLine(string toadd)
	{
        if (Lines != null)
		Lines.Add(currentlinenumber  + toadd);
	    currentlinenumber ++;
		if (Lines.Count > maxline)
			Lines.RemoveAt(0);
	}

}
