
using UnityEngine;

public class Particle2D : MonoBehaviour
{
    public Vector2 velocity;
    public float inverseMass;
    public Vector2 acceleration;
    public float damping;
    // TODO: YOUR CODE HERE!
    private void FixedUpdate()
    {
        Integrator.Integrate(this, Time.fixedDeltaTime);
    }
    

}
