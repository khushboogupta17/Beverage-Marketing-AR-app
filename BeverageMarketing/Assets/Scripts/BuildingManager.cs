using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Events;

public class BuildingManager : MonoBehaviour
{
    public GameObject building;
    public GameObject textCanvas;
    public GameObject globalBlurCanvas;
    // Start is called before the first frame update
    void Start()
    {
        GoogleARCore.Examples.ObjectManipulation.BuildingManipulator.onPrefabPlaced += OnPrefabPlaced;
    }

    void OnPrefabPlaced()
    {
        RaiseBuildingYScale(true);
    }

    public void RaiseBuildingYScale(bool rise)
    {
        if (rise)
        {
            
           
            building.SetActive(true);
            //building.transform.localScale = Vector3.one;
            //building.transform.DOShakeScale(1f).OnComplete(() =>
            //{
            //    textCanvas.SetActive(true);
                

            //});
            textCanvas.SetActive(true);
            textCanvas.transform.DOShakeScale(1.5f);




        }
        
        else
        {
            textCanvas.SetActive(false);
            // building.transform.DOShakeScale(1f).OnComplete(() =>
            //{
                
            //    building.SetActive(false);
            //}
            //) ;
            //building.transform.localScale = Vector3.zero;
            building.SetActive(false);
        }

       
             
    }

    private void OnCollisionEnter(Collision collision)
    {
        globalBlurCanvas.SetActive(true);
    }

    private void OnCollisionExit(Collision collision)
    {
        globalBlurCanvas.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
