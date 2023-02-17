using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AR;
using UnityEngine.EventSystems;

public class CustomPlacementInteractable : ARPlacementInteractable
{
    private List<RaycastResult> raycastHits = new List<RaycastResult>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override bool CanStartManipulationForGesture(TapGesture gesture)
    {
        if(gestureInteractor.interactablesSelected.Count > 0)
        {
            return false;
        }
        

        PointerEventData eventData = new PointerEventData(EventSystem.current);
        eventData.position = gesture.startPosition;
        EventSystem.current.RaycastAll(eventData, raycastHits);

        if(raycastHits.Count > 0)
        {
            return false;
        }

        return base.CanStartManipulationForGesture(gesture);
    }
}
