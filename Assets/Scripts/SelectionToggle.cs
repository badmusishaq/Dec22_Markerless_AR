using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionToggle : MonoBehaviour
{
    [SerializeField] private Renderer rendererToChange;

    [SerializeField] private Material selectionMaterial;

    private Material defaultMaterial;

    private void Awake()
    {
        defaultMaterial = rendererToChange.sharedMaterial;
    }

    private void OnEnable()
    {
        rendererToChange.sharedMaterial = selectionMaterial;
    }

    private void OnDisable()
    {
        rendererToChange.sharedMaterial = defaultMaterial;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
