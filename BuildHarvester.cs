using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// HOW TO USE GO TO README
public class BuildHarvester : Quantum
{
   
    public GameObject quantumHarvester;
    public GameObject qHarvesterText;
    // Start is called before the first frame update
    public Button buildButton;
    public bool build = false;
    private GameObject selectedObject;
    
    // Start is called before the first frame update
    void Start()
    {
        buildButton.onClick.AddListener(BuildQuantumHarvester);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                selectedObject = hit.transform.gameObject;
            }
        }
    }

    void BuildQuantumHarvester()
    {
        Debug.Log(base.getQuantum()+"quantumAvailable");
  if (base.getQuantum() >= 5)
    {
        if (selectedObject != null)
        {
            Vector3 spawnPosition = selectedObject.transform.position;
            spawnPosition.y = transform.position.y + 4.5f;
            Collider[] hitColliders = Physics.OverlapSphere(spawnPosition, 3f);

            bool canBuild = true;
            for (int i = 0; i < hitColliders.Length; i++)
            {
                if (hitColliders[i].gameObject.CompareTag("Harvester"))
                {
                    canBuild = false;
                    break;
                }
            }

            if (canBuild)
            {
                GameObject newQuantumHarvester = Instantiate(quantumHarvester, spawnPosition, Quaternion.identity);
                base.subtractQuantum(5);
            }
            else
            {
                Debug.Log("Quantum Harvester already exists within 3x3 area");
            }
        }
        else
        {
            Debug.Log("No object selected");
        }
    }
    else
    {
        Debug.Log("Not enough resources");
    }
    }
}
