using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ToggleManager : MonoBehaviour
{
    [SerializeField] RectTransform menuTransform;

    [SerializeField] float upPosition;
    [SerializeField] float downPosition;

    bool isOpen;
    // Start is called before the first frame update
    void Start()
    {
        Toggle();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Toggle()
    {
        isOpen = !isOpen;

        Vector2 targetPosition = new Vector2(0, isOpen ? upPosition : downPosition);
        menuTransform.DOAnchorPos(targetPosition, 0.5f);

        /*if(isOpen)
        {
            Vector2 targetPosition = new Vector2(0, upPosition);
            menuTransform.DOAnchorPos(targetPosition, 0.5f);
        }
        else
        {
            Vector2 targetPosition = new Vector2(0, downPosition);
            menuTransform.DOAnchorPos(targetPosition, 0.5f);
        }*/
    }
}
