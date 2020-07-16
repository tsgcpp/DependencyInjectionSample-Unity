using System;

public interface IObservable
{
    IDisposable Subscribe(Action<string> onNext);
}
