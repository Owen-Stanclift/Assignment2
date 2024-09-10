using System.Numerics;
using UnityEngine;

public class Particle2D : MonoBehaviour
{
    public float velocity;
    public float inverseMass;
    public float gravity;
    public float damping;
    // TODO: YOUR CODE HERE!
    private void Update()
    {
        Integrator.Integrate(this, Time.deltaTime);
    }
}
