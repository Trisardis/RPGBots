using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    [SerializeField] UnityEvent _unityEvent;
    [SerializeField] GameEvent _gameEvent;
    void Awake() => _gameEvent.Register(gameEventListener: this);
    void OnDisable() => _gameEvent.Deregister(gameEventListener: this);
    public void RaiseEvent() => _unityEvent.Invoke();
}