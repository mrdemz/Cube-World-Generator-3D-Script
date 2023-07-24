using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIValueUpdater : Quantum
{
 
    private int totalQuantum;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        showQuantum();
    }
    

    private void showQuantum(){
       totalQuantum = base.getQuantum();
       this.GetComponent<TMPro.TextMeshProUGUI>().text = totalQuantum.ToString();
       Debug.Log("qs:"+totalQuantum);
    }
}
