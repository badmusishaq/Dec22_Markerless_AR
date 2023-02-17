using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class FurnitureManager : MonoBehaviour
{
    [SerializeField] FurnitureData[] newFurnitureData;

    [SerializeField] Transform contentTransform;

    [SerializeField] FurnitureMenuOption furnitureUIPrefab;

    private FurnitureMenuOption currentMenuOption;

    [SerializeField] ARPlacementInteractable placementInteractable;

    // Start is called before the first frame update
    void Start()
    {
        foreach(FurnitureData data in newFurnitureData)
        {
            FurnitureMenuOption menuOption = Instantiate(furnitureUIPrefab, contentTransform);
            menuOption.furnitureName.text = data.name;
            menuOption.furnitureIcon.texture = data.furnitureIcon;

            menuOption.button.onClick.AddListener(() => SelectFurniture(menuOption, data));
        }
    }

    void SelectFurniture(FurnitureMenuOption newMenuOption, FurnitureData selectFurnitureData)
    {
        if(currentMenuOption != null)
        {
            currentMenuOption.background.color = newMenuOption.background.color;
        }

        currentMenuOption = newMenuOption;
        placementInteractable.placementPrefab = selectFurnitureData.furniturePrefab;

        newMenuOption.background.color = Color.yellow;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
