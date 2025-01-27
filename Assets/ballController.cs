using UnityEngine;

public class ballController : MonoBehaviour{

    [SerializeField] private Rigidbody sphereRigidbody;
    [SerializeField]  float ballSpeed;
    [SerializeField]  float ballJumpMultiplier;


    public void MoveBall(Vector2 input){
        Vector3 inputXZPlane = new(input.x, 0, input.y);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);
    }

    public void onJump(Vector3 input){
        sphereRigidbody.AddForce(input * ballJumpMultiplier,ForceMode.Impulse);
        
    }

    



}
