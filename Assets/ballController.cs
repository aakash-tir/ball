using UnityEngine;

public class ballController : MonoBehaviour{

    [SerializeField] private Rigidbody sphereRigidbody;
    [SerializeField]  float ballSpeed;


    public void MoveBall(Vector2 input){
        Vector3 inputXZPlane = new(input.x, 0, input.y);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);
    }

}
