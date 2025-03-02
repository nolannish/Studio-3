using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    public Vector3 rotation;
    [SerializeField] private GameManager manager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotation * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider coinTrigger){
        if(coinTrigger.CompareTag("Player")){
            manager.IncrementScore();
            Destroy(gameObject);
        }
    }   
}
