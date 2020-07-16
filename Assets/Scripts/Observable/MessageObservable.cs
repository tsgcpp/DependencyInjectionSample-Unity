using System;
using System.Collections.Generic;
using UnityEngine;

public class MessageObservable : MonoBehaviour, IObservable
{
    private List<Action<string>> onNextList = new List<Action<string>>();

    public IDisposable Subscribe(Action<string> onNext)
    {
        onNextList.Add(onNext);

        return new Unsubscriber(() => { onNextList.Remove(onNext); });
    }

    private class Unsubscriber : IDisposable
    {
        private Action _disposeAction;

        public Unsubscriber(Action action)
        {
            _disposeAction = action;
        }

        public void Dispose()
        {
            if (_disposeAction == null) { return; }
            _disposeAction();
            _disposeAction = null;
        }
    }
}
