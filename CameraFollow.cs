using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// HOW TO USE GO TO README
public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float rotateSpeed = 0.8f;
    private bool isDragging;

    private List<Transform> labelObjects = new List<Transform>();
    public BuildHarvester buildHarvester;
    void Start()
    {
        // Find all GameObjects with the "Label" tag and add their transforms to the labelObjects list.
        GameObject[] allLabels = GameObject.FindGameObjectsWithTag("Labels");
        foreach (var label in allLabels)
        {
            labelObjects.Add(label.transform);
        }
    }

    void Update()
    {
        if (buildHarvester.build)
        {
            GameObject[] allLabels = GameObject.FindGameObjectsWithTag("Labels");
            foreach (var label in allLabels)
            {
                labelObjects.Add(label.transform);
            }
            buildHarvester.build =false;
        }
        transform.position = player.position + offset;
        transform.LookAt(player);

        if (Input.GetMouseButtonDown(0))
        {
            isDragging = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
        }
        if (isDragging)
        {
            Quaternion rotation = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * rotateSpeed, Vector3.up);
            offset = rotation * offset;

            transform.rotation = rotation * transform.rotation;

            // Rotate all label objects with the same rotation as the camera.
            foreach (var label in labelObjects)
            {
                label.rotation = rotation * label.rotation;
            }
        }
    }
    public void AddLabelObject(Transform labelTransform)
    {
        labelObjects.Add(labelTransform);
    }
}
