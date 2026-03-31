using UnityEngine;

public class healthPack : MonoBehaviour
{
    public float health = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.GetComponent<playerHealth>().AddHealth(health);
        Destroy(gameObject);
    }
}
