using System.IO; 

public class Entry{


public string _date;
public string _name;
public string _prompt;
public string _response;


public void SetDate()
{
    _date = DateTime.Now.ToShortDateString();
}

public void SetName(string name)
{
    _name = name;
}


public void SetPrompt(string prompt)
{
    _prompt = prompt;
}


public void SetResponse(string response)
{
    _response = response;
}


public string GetDate()
{
    return _date;
}


public string GetName()
{
    return _name;
}


public string GetPrompt()
{
    return _prompt;
}


public string GetResponse()
{
    return _response;
}




      


}

