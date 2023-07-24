using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quantum : MonoBehaviour
{
    private static int quantum;

    // Start is called before the first frame update
    void Start()
    {
      quantum = 0;
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void setQuantum(int quantum){
        Quantum.quantum = quantum;
    }
    public int getQuantum(){
        return quantum;
    }
    protected void addQuantum(int quantum){
        Quantum.quantum += quantum;
        Debug.Log(Quantum.quantum+"fuckme");

    }
     public void subtractQuantum(int quantum){
        Quantum.quantum -= quantum;
    }
}
