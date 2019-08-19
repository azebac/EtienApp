using System;
using System.Threading.Tasks;

public abstract class AsyncCommand<T>: Command<T>
{
    public abstract Task ExecuteAsync();
}
