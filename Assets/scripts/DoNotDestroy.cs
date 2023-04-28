using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotDestroy : MonoBehaviour
{
    private static DoNotDestroy DNDInstance;
    void Awake()
    {
        DontDestroyOnLoad(this);
        
        if (DNDInstance == null)
        {
            DNDInstance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
