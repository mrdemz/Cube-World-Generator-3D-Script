using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePlatform : MonoBehaviour
{
    public GameObject cubePrefab;
    private List<GameObject> cubeList = new List<GameObject>();
    private Vector3 platformCenter;
    // HOW TO USE GO TO README
    // Start is called before the first frame update
    void Start()
    {
        // Generate the 36 cubes
        for (int i = 0; i < 72; i++)
        {
            GameObject newCube = Instantiate(cubePrefab);
            cubeList.Add(newCube);
        }

        // Calculate the center point of the platform
        Vector3 sumPositions = Vector3.zero;
        foreach (GameObject cube in cubeList)
        {
            sumPositions += cube.transform.position;
        }
        platformCenter = sumPositions / 72;

        // Set the position of each cube based on its relative position to the center
        int index = 0;
        for (int i = -1; i <= 6; i++)
        {
            for (int j = -1; j <= 7; j++)
            {
                cubeList[index].transform.position = new Vector3(platformCenter.x + i*2, platformCenter.y, platformCenter.z +  j*2);
                Debug.Log("x:"+(platformCenter.x + i*2)+" z:"+(platformCenter.z +  j*2));
                index++;
            }
        }




    }
}
