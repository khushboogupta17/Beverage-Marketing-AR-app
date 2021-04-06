using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;

public class MenuController : MonoBehaviour
{ 
    public BuildingManager buildingManager;
    public GameObject coffee;
    public GameObject tea;
    public GameObject backPanel;
    public GameObject AugmentedImageController;
    

  
    private void Update()
    {

        GameObject menuItem = CheckWithRaycasting();

        if (menuItem != null)
        {
            if (menuItem.name == "BobTea")
            {
                Debug.Log("Found tea");
                backPanel.SetActive(true);
                // buildingManager.RaiseBuildingYScale(false);
                tea.SetActive(true);
                tea.transform.DOShakeRotation(1.5f);
            }
            else if(menuItem.name== "Chahin_Coffee")
            {
                Debug.Log("Found Coffee");
                backPanel.SetActive(true);
                // buildingManager.RaiseBuildingYScale(false);
                //coffee.SetActive(true);
                AugmentedImageController.SetActive(true);
            }
            else if(menuItem.name == "BobTea_model")
            {
                tea.transform.GetChild(1).gameObject.SetActive(!tea.transform.GetChild(1).gameObject.activeSelf);
            }

            else if(menuItem.name== "ChahinCoffee_model")
            {
                coffee.transform.GetChild(1).gameObject.SetActive(!tea.transform.GetChild(1).gameObject.activeSelf);
            }
        }
   
    }


    GameObject CheckWithRaycasting()
    {
       // Debug.Log("update working " + Input.touchCount);
        RaycastHit hit = new RaycastHit();
        for (int i = 0; i < Input.touchCount; ++i)
        {
            Debug.Log("checking");
            if (Input.GetTouch(i).phase.Equals(TouchPhase.Began))
            {
                int layerMask = LayerMask.GetMask("Menu");
                // Construct a ray from the current touch coordinates
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
                if (Physics.Raycast(ray, out hit, 20f, layerMask))
                {
                    Debug.Log("hit object: " + hit.collider.gameObject);

                    if(buildingManager.gameObject.activeSelf)
                    buildingManager.RaiseBuildingYScale(false);

                    //if (hit.collider.gameObject.name == name)
                        return hit.collider.gameObject;

                }
            }
        }
        return null;

    }


    public void Back()
    {
       coffee.SetActive(false);
        tea.SetActive(false);
        backPanel.SetActive(false);
        AugmentedImageController.SetActive(false);
        
        buildingManager.RaiseBuildingYScale(true);
    }
}
