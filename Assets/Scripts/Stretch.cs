
using UnityEngine;

public class Stretch : MonoBehaviour
{
    // TODO: YOUR CODE HERE!
    private void FixedUpdate()
    {
        this.transform.localScale = new Vector3(this.transform.localScale.x,this.transform.localScale.y-1,this.transform.localScale.z);
    }
    

}
