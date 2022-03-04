using UnityEngine;
using UnityEngine.Events;

public class OnHoleEnter : MonoBehaviour
{
    [SerializeField] private UnityEvent onHoleEnter; // true - победа, это для определения экрана паузы

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            onHoleEnter.Invoke();
        }
    }
}
