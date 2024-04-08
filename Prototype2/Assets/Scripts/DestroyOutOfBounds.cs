using UnityEngine;

public class MoveFoward : MonoBehaviour
{
    [SerlializedField] float speed = 40.0f;
    // Update is called once per frame
    void Update()
    {
         transform.Translate(Vector3.foward * (speed * Time.deltaTime));
        
        }
    }
