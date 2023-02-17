using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;

public class DeleteButton : MonoBehaviour
{
    [SerializeField] Button deleteButton;

    private GameObject currentSelectedObject;

    // Start is called before the first frame update
    void Start()
    {
        deleteButton.onClick.AddListener(ButtonClick);
    }

    public void SelectEnter(SelectEnterEventArgs args)
    {
        currentSelectedObject = args.interactableObject.transform.gameObject;
        deleteButton.interactable = true;
    }

    public void SelectExit(SelectExitEventArgs args)
    {
        deleteButton.interactable = false;
    }

    void ButtonClick()
    {
        Destroy(currentSelectedObject);
    }
}
