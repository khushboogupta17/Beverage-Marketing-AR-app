using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using GoogleARCore.Examples.Common;

public class gameManager : MonoBehaviour
{
    
    public static gameManager instance;

 

    GameObject planeGenerator;
    GameObject pointCloud;
    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(this);
            return;
        }
         
    }


    private void Start()
    {
       // Debug.Log("Game manager running");
        if (GameObject.FindGameObjectWithTag("planeGenerator") != null)
        {
          //  Debug.Log("Game manager plane generator");
            planeGenerator = GameObject.FindGameObjectWithTag ( "planeGenerator");
        }

        if (GameObject.FindGameObjectWithTag("pointCloud") != null)
        {
           // Debug.Log("Game manager point cloud");
            pointCloud = GameObject.FindGameObjectWithTag("pointCloud"); 
        }
    }
   

    public void Quit(string buttonName)
    {
        
       
        Application.Quit();
    }

    public void  SetVisualizers(bool setTo)
    {
        Debug.Log("Visializers set to " + setTo);

        planeGenerator.SetActive(setTo);
     
        pointCloud.SetActive(setTo);
    }

    
}

