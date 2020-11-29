using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DifficultyChange : MonoBehaviour
{
    public void ChangeDifficulty()
    {
        if(RenderSettings.fog == true)
        {
            RenderSettings.fog = false;
        }
        else if(RenderSettings.fog == false)
        {
            RenderSettings.fog = true;
        }
    }
}
