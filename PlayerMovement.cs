using UnityEngine;
// HOW TO USE GO TO README
public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;
    private Vector3 targetPosition;
    private bool isMoving;
    private Rigidbody rigidPlayer;

    private void Start()
    {
        rigidPlayer = GetComponent<Rigidbody>();

    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.tag == "Selectable")
                {
                    targetPosition = hit.point;
                    targetPosition.y = transform.position.y;
                    isMoving = true;
                }
            }
        }

        if (isMoving)
        {


            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

            if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
            {
                isMoving = false;
            }
        }
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Harvester"))  // or if(gameObject.CompareTag("YourWallTag"))
        {
            isMoving = false;
          

        }
    }
}
