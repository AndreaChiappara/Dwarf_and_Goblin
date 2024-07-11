using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Territory : MonoBehaviour
{
    [Header("Informazioni Territorio")]
    public string name;
    public List<Territory> neighboringTerritories;

    [Header("Cose da settare")]
    public float hoverColorIntensity = 1.5f;

    [Header("Tocca qualcosa qui e verrai stuprato")]
    public int troopsNumber;
    public Player owner;
    private Renderer thisRenderer;
    public Material territoryMaterial;


    // Start is called before the first frame update
    void Start()
    {
        thisRenderer = this.gameObject.GetComponent<Renderer>();
        thisRenderer.material = territoryMaterial;


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnLeftMouseClick()
    {
        Debug.Log("Hai LEFTcliccato sul Territorio: " + name);
    }
    public void OnRightMouseClick()
    {
        Debug.Log("Hai RIGHTcliccato sul Territorio: " + name);
    }

    public void OnMouseEnter()
    {
        Debug.Log("Sei entrato nel Territorio: " + name);
        HoverColor();

    }

    public void OnMouseExit()
    {
        Debug.Log("Sei uscito dal Territorio: " + name);
        UpdateColor();
    }

    public void HoverColor()
    {
        Material newMaterial = new Material(thisRenderer.material);
        Color originalColor = newMaterial.color;

        Color highlightColor = originalColor * hoverColorIntensity;

        newMaterial.color = highlightColor;

        thisRenderer.material.color = newMaterial.color;
    }

    public void UpdateColor()
    {
        if(owner != null)
        {
            thisRenderer.material = owner.playerMaterial;
        }else
        {
            thisRenderer.material = territoryMaterial;
        }
        
    }

}
