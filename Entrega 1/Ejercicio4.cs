```csharp

    abstract class AbstractSample
{
    protected string message;

    public AbstractSample(string msg)
    {
        message = msg;
    }

    public abstract void PrintMessage(string msg);

    public virtual string InvertMessage(string msg)
    {
        char[] c = msg.ToCharArray();
        Array.Reverse(c);
        return new string(c);
    }
}

```


```csharp
class SampleNormal : AbstractSample
{
    public SampleNormal(string msg) : base(msg) { }

    public override void PrintMessage(string msg)
    {
        Console.WriteLine(msg);
    }
}

```


```csharp
class SampleInvertido : AbstractSample
{
    public SampleInvertido(string msg) : base(msg) { }

    public override void PrintMessage(string msg)
    {
        foreach (char c in msg)
            Console.Write(char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c));
        Console.WriteLine();
    }

    public override string InvertMessage(string msg)
    {
        string invertido = base.InvertMessage(msg);
        return invertido.ToLower();
    }
}

```



```csharp
class MessageManager
{
    public void Ejecutar()
    {
        AbstractSample a = new SampleNormal("Hola Mundo");
        AbstractSample b = new SampleInvertido("Hola Mundo");

        a.PrintMessage("Hola Mundo");
        b.PrintMessage("Hola Mundo");
    }
}

```