using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    [SerializeField]
    private KimbaInput.InputEventProvider inputEventProvider;
    public KimbaInput.InputEventProvider InputEventProvider => inputEventProvider;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public static GameManager Instance
    {
        get 
        {
            if (instance == null)
            {
                return null;
            }
            else
            {
                return instance;
            }
        }
    }
}
