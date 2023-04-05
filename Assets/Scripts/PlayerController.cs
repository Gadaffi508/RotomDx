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
        transform.position = new Vector2(Mathf.Clamp(transform.position.x,-2.85f,2.85f),Mathf.Clamp(transform.position.y,-3.5f,2.25f));
    }
}
