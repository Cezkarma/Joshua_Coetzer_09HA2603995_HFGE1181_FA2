using UnityEngine;

public class EnemyDestroy : MonoBehaviour
{
    [SerializeField] GameObject parentObject;

    public void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.tag == "Player")
        {
            Debug.Log("Ouch!");
            Destroy(parentObject);
        }
    }
}
