using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameEvent : ScriptableObject
{
    private List<GameEventListener> listeners = new List<GameEventListener>();

    public void AddListener(GameEventListener newListener)
    {
        listeners.Add(newListener);
    }

    public void RemoveListener(GameEventListener listenerToRemove)
    {
        listeners.Remove(listenerToRemove);
    }

    public void Raise()
    {
        foreach (var eventListener in listeners)
        {
            eventListener.OnEventRaised();
        }
    }
}
