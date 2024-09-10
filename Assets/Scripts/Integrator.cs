using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Integrator
{
    public static void Integrate(Particle2D particle, float dt)
    {
        // TODO: YOUR CODE HERE

        particle.velocity += particle.gravity * Time.deltaTime;
        particle.transform.Translate(Vector3.up * (particle.velocity*particle.damping) * Time.deltaTime);
    }
}
