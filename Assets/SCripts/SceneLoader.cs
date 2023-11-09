using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadTheHub()
    {
        SceneManager.LoadScene("TheHub");
    }
    public void LoadNileScene()
    {
        SceneManager.LoadScene("Scenes/NileRiver");
    }
    
    public void LoadPyramidsOfGiza()
    {
        SceneManager.LoadScene("PyramidsOfGiza");
    }
    
    public void LoadValleyofKings()
    {
        SceneManager.LoadScene("ValleyOfkings");
    }
    public void LoadTempleofRa()
    {
        SceneManager.LoadScene("TempleOfRa");
    }
    
    
    
}
