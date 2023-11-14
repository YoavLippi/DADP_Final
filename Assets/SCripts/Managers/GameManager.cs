using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    // Add your variables that need to persist between scenes
    private int totalBodyPartsCollected;

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameObject("GameManager").AddComponent<GameManager>();
                DontDestroyOnLoad(instance.gameObject);
            }
            return instance;
        }
    }

    // Add methods to access and modify the data you want to persist
    public int TotalBodyPartsCollected
    {
        get { return totalBodyPartsCollected; }
        set { totalBodyPartsCollected = value; }
    }

    // Add any other methods or variables you need here

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}       

