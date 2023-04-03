using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float X, Y;
    public float speed;
    private void Update()
    {
        X = Input.GetAxis("Horizontal")*Time.deltaTime* speed;
        Y = Input.GetAxis("Vertical")*Time.deltaTime* speed;
        transform.Translate(new Vector2(X,Y));
    }
}
