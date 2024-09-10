using Codice.Client.Commands;
using GluonGui.WorkspaceWindow.Views.WorkspaceExplorer.Explorer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Gun : MonoBehaviour
{
    public Particle2D[] bullet;
    public static int currBullet;
    /// <summary>
    /// The direction of the initial velocity of the fired projectile. That is,
    /// this is the direction the gun is aiming in.
    /// </summary>

    public Vector3 FireDirection
    {
        get
        {
            // TODO: YOUR CODE HERE
            return this.transform.eulerAngles;
        }
    }

    /// <summary>
    /// The position in world space where a projectile will be spawned when
    /// Fire() is called.
    /// </summary>
    public Vector3 SpawnPosition
    {
        get
        {
            // TODO: YOUR CODE HERE
            Vector2 pos = this.transform.position;
            return pos;
        }
    }

    /// <summary>
    /// The currently selected weapon object, an instance of which will be
    /// created when Fire() is called.
    /// </summary>
    public GameObject CurrentWeapon
    {
        get
        {
            // TODO: YOUR CODE HERE
            return bullet[currBullet].gameObject;
        }
    }

    /// <summary>
    /// Spawns the currently active projectile, firing it in the direction of
    /// FireDirection.
    /// </summary>
    /// <returns>The newly created GameObject.</returns>
    public GameObject Fire()
    {
        // TODO: YOUR CODE HERE
        GameObject newBullet = CurrentWeapon;
        newBullet.transform.position = SpawnPosition;
        newBullet.transform.eulerAngles = FireDirection;
        return newBullet;
    }

    /// <summary>
    /// Moves to the next weapon. If the last weapon is selected, calling this
    /// again will roll over to the first weapon again. For example, if there
    /// are 4 weapons, calling this 4 times will end up with the same weapon
    /// selected as if it was called 0 times.
    /// </summary>
    public void CycleNextWeapon()
    {
        if(currBullet == 3)
        {
            currBullet = 0;
        }
        else
        {
            currBullet++;
        }
        // TODO: YOUR CODE HERE
    }

    void Update()
    {
        // TODO: YOUR CODE HERE (handle all input in Update, not FixedUpdate!)
        if (Input.GetKeyDown(KeyCode.W))
        {
            CycleNextWeapon();
        }
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Instantiate(Fire());
        }
        if(Input.GetKey(KeyCode.Alpha1))
        {
            this.transform.Rotate(0, 0, 1);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            this.transform.Rotate(0, 0, -1);
        }
    }
}
