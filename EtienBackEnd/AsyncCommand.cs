using System;

public abstract class AsyncCommand<T>: Command<T>
{
    public abstract Task ExecuteAsync();
}
