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

[HellpAttribute("Information on the class MyClass")]
class MyClass
{

}


namespace ReflectionEx
{
    class Program
    {
        static void Main(string[] args)
        {
            MemberInfo info = typeof(MyClass);
            object[] attribute = info.GetCustomAttributes(true);
            
            for(int i=0; i<attribute.Length;i++)
            {
                Console.WriteLine(attribute[i]);
            }
            Console.ReadKey();
        }
    }
}
