
    internal class Class
    {
    public string ClassName { get; set; }
    public int NumberOf025Can { get; set; }
    public int NumberOf033Can { get; set; }
    public int NumberOf05Can { get; set; }

    public int Points => (NumberOf025Can*1) + (NumberOf033Can*2) + (NumberOf05Can*3);

    public Class() { }
    public Class(string className, int numberOf025Can, int numberOf033Can, int numberOf05Can) 
    { ClassName = className;
    NumberOf025Can = numberOf025Can;
        NumberOf033Can = numberOf033Can;
        NumberOf05Can = numberOf05Can;
    }
}

