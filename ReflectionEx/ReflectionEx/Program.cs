using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.All)]
public class HellpAttribute : System.Attribute
{
    public readonly string Url;
    private string topic;
    public string Topic
    {
        get
        {
            return Topic;
        }
        set
        {
            Topic = value;
        }
    }

    public HellpAttribute(string url)
    {
        this.Url = url;
    }
}

[HelpAttribute ]


namespace ReflectionEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(String);
            MethodInfo substr = t.GetMethod("Substring", new Type[]);
            
        }
    }
}
