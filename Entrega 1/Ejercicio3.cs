```csharp

    static int CalcularPremio(string apostado, string resultado, int monto)
{
    if (apostado == resultado)
        return monto * 4500;

    char[] a = apostado.ToCharArray();
    char[] r = resultado.ToCharArray();
    Array.Sort(a);
    Array.Sort(r);

    if (new string(a) == new string(r))
        return monto * 200;

    if (apostado.Substring(1) == resultado.Substring(1))
        return monto * 400;

    if (apostado.Substring(2) == resultado.Substring(2))
        return monto * 50;

    if (apostado[3] == resultado[3])
        return monto * 5;

    return 0;
}


```