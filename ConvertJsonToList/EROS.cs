public class Rootobject
{
    public ERO[] EROS { get; set; }
}

public class ERO
{
    public string moduleName { get; set; }
    public string URL { get; set; }
    public string Screename { get; set; }
    public Field[] Fields { get; set; }
    public Savedata[] SaveData { get; set; }
    public Alreadyexistsdata[] AlreadyExistsData { get; set; }
    public Searchdata[] SearchData { get; set; }
}

public class Field
{
    public string fieldName { get; set; }
    public string locatorId { get; set; }
    public bool mandatory { get; set; }
}

public class Savedata
{
    public string fieldname { get; set; }
    public string fieldvalue { get; set; }
}

public class Alreadyexistsdata
{
    public string fieldname { get; set; }
    public string fieldvalue { get; set; }
}

public class Searchdata
{
    public string fieldname { get; set; }
    public string fieldvalue { get; set; }
}


