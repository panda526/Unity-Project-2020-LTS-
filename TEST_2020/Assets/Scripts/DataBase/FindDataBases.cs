using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindDataBases : MonoBehaviour
{
    // Start is called before the first frame update
    string m_Path;

    void Start()
    {
        //Get the path of the Game data folder
        m_Path = Application.streamingAssetsPath;
        //Output the Game data path to the console
        Debug.Log("dataPath : " + m_Path);
    }
}
