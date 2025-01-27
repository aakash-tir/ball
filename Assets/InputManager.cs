using UnityEngine;
using UnityEngine.Events;
public class InputManager : MonoBehaviour{

    public UnityEvent<Vector2> OnMove = new UnityEvent<Vector2>();
    public UnityEvent<Vector3> Jump = new UnityEvent<Vector3>();
    private bool isGrounded=false;


    // Update is called once per frame
    void Update()
    {
        Vector2 inputVector = Vector2.zero;
        Vector3 inputVector3 = Vector3.zero;
        

        if (Input.GetKey(KeyCode.W)){
            inputVector += Vector2.up;
            
        }
        if (Input.GetKey(KeyCode.A)){
            inputVector += Vector2.left;
        }
        if (Input.GetKey(KeyCode.S)){
            inputVector += Vector2.down;
        }
        if (Input.GetKey(KeyCode.D)){
            inputVector += Vector2.right;
        }
        if (Input.GetKey(KeyCode.Space) && isGrounded ){
            inputVector3+=Vector3.up;
            isGrounded=false;
            
        }
        
        OnMove?.Invoke(inputVector);
        Jump?.Invoke(inputVector3);
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            isGrounded = true; 
        }
    }

  
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            isGrounded = false; 
        }
    }

}
