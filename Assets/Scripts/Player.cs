using Unity.Cinemachine;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private InputManager inputManager;
    [SerializeField] private float speed = 50f;
    [SerializeField] private CinemachineCamera freeLookCamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
        inputManager.OnMove.AddListener(MovePlayer);
    }

    void Update()
    {
        transform.forward = freeLookCamera.transform.forward;
        transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0);

    }

    private void MovePlayer(Vector2 input){
       rb.AddForce(transform.forward * speed);
    }
}
