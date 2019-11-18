using UnityEngine;
using UnityEngine.UI;

public class DestroyOnDie : MonoBehaviour
{
    public void Die()
    {
        Destroy(gameObject);
    }
}
