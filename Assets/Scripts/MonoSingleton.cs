using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoSingleton<T> : MonoBehaviour where T: MonoSingleton<T>
{
    private static T instance;
    public T Instance { get { return instance; } }
  
    protected virtual void Awake()
    {
        if(instance == null)
        {
            instance = (T)this;
        }
        else
        {
            Destroy(this);
        }
    }

    void Update()
    {
        
    }
}
