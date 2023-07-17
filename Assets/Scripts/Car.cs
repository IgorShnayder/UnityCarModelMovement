using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] 
    private float _speed;
    
    private void Update()
    {
        var position = gameObject.transform.position;
        var transformRotation = transform.rotation;
        var step = _speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
        {
            position.z += step;
        }
        
        else if (Input.GetKey(KeyCode.S))
        {
            position.z -= step;
        }
        
        else if (Input.GetKey(KeyCode.A))
        {
            transformRotation.y -= 0.02f;
        }
        
        else if(Input.GetKey(KeyCode.D))
        {
            transformRotation.y += 0.02f;
        }
        
        transform.position = position;
        transform.rotation = transformRotation;
    }
}
