```csharp

static bool EsPrimo(int n)
{
    if (n < 2) return false;
    for (int i = 2; i <= Math.Sqrt(n); i++)
        if (n % i == 0) return false;
    return true;
}

static void FibonacciPrimos(int n)
{
    int a = 0, b = 1;

    for (int i = 1; i <= n; i++)
    {
        int fib = a;
        if (EsPrimo(fib))
            Console.WriteLine(fib);

        int temp = a + b;
        a = b;
        b = temp;
    }
}


```