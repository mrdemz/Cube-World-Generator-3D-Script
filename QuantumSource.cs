using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// HOW TO USE GO TO README
public class QuantumSource : Quantum
{
    public GameObject qsFloatingText;

    private float timer = 0f;
    private int quantumSource = 0;
    private int capacity;
    bool canHarvest = false;
    // Start is called before the first frame update
    
    void Start()
    {
        capacity = 10;
         qsFloatingText = new GameObject("0");
           var textMesh = qsFloatingText.AddComponent<TMPro.TextMeshPro>();
              textMesh.alignment = TMPro.TextAlignmentOptions.Center;
            textMesh.fontSize = 11;
            textMesh.text = quantumSource.ToString();
            textMesh.transform.SetParent(transform);
         

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 0.5f && quantumSource < capacity)
        {
            quantumSource += 1;
            Debug.Log("Current Position:"+this.transform.position.z+", "+this.transform.position.y);
            timer = 0f;
        }


        OnMouseDown();
        showFloatingText();

    }

    void showFloatingText()
    {

        qsFloatingText.transform.position =  this.transform.position;
        qsFloatingText.GetComponent<TMPro.TextMeshPro>().text = quantumSource.ToString();
    }

    private void OnMouseDown()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (quantumSource == capacity)
        {
            canHarvest = true;
        }

        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log("debug1");
            if (hit.collider.gameObject.transform.position== this.transform.position && canHarvest && Input.GetMouseButtonDown(0))
            {
                 
                base.addQuantum(quantumSource);
                quantumSource = 0;
                canHarvest = false;
            }
        }
    }

}
