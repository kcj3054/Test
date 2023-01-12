namespace BabyCarrot.Tools;

public enum LogType
{
    Daily,
    Mothly,
}

public class LogManager
{
    private string _path;

    #region Constructors

    public LogManager(string path, LogType logType, string prefix, string postfix)
    {
        _path = path;
        SetLogPath(logType, prefix, postfix);
    }

    public LogManager(string prefix, string postfix)
        :this(Path.Combine(Application.Root, "Log"), LogType.Daily, prefix, postfix)
    {
        
    }

    public LogManager()
        : this(Path.Combine(Application.Root, "Log"), LogType.Daily, null, null)
    {
        
    }
    #endregion

    #region Methods

    private void SetLogPath(LogType logType, string prefix, string postfix)
    {
        string path = String.Empty;
        string name = string.Empty;

        switch (logType)
        {
            case LogType.Daily:
                path = String.Format(@"{0}\{1}", DateTime.Now.Year, DateTime.Now.ToString("MM"));
                name = DateTime.Now.ToString("yyyyMMdd");
                break;
            case LogType.Mothly:
                path = string.Format(@"{0}\", DateTime.Now.Year);
                name = DateTime.Now.ToString("yyyyMM");
                break;
        }

        _path = Path.Combine(_path, path);
        if (!Directory.Exists(_path))
            Directory.CreateDirectory(_path);

        if (string.IsNullOrEmpty(prefix))
        {
            name = prefix + name;
        }

        if (string.IsNullOrEmpty(postfix))
        {
            name = name + postfix;
        }

        name += ".txt";
        
        _path = Path.Combine(_path, name);
    }

    public void Write(string data)
    {
        try
        {
            using (StreamWriter writer = new(_path, true))
            {
                writer.Write(data);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public void WriteLine(string data)
    {
        try
        {
            using (StreamWriter writer = new(_path, true))
            {
                writer.WriteLine(data);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    #endregion
}