using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game Event")]

public class GameEvent : ScriptableObject
{
    HashSet<GameEventListener> _gameEventListeners = new HashSet<GameEventListener>();

    public void Register(GameEventListener gameEventListener) => _gameEventListeners.Add(gameEventListener);
    public void Deregister(GameEventListener gameEventListener) => _gameEventListeners.Remove(gameEventListener);

    [ContextMenu(itemName:"Invoke")]
    public void Invoke()
    {
        foreach (var gameEventListener in _gameEventListeners)
        {
            gameEventListener.RaiseEvent();
        }
    }
}


