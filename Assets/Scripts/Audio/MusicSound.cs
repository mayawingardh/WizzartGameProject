using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicSound : MonoBehaviour
{
    private static MusicSound instance = null;

    public static MusicSound Instance
    {
        get { return instance; }
    }

    private void Awake()
    {
        if (instance != null && instance != this) //!= this means not in the scen where it was created
        {
            Destroy(this.gameObject);
            return;

        }

        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject); //dont destrou objekt when new scen are loaded
    }
}
