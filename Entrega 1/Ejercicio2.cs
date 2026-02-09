```csharp

    static string SegundosAHora(int segundos)
{
    int h = segundos / 3600;
    int m = (segundos % 3600) / 60;
    int s = segundos % 60;

    return h.ToString("D2") + ":" +
           m.ToString("D2") + ":" +
           s.ToString("D2");
}


```