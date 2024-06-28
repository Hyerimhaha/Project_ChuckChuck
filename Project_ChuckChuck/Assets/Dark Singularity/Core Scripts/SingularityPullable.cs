using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class SingularityPullable : MonoBehaviour
{
    //Add this script to objects you want to be pulled by the singularity script
    public bool pullable = true;
    public GameObject startPointHole;
    private int n = 0;
    
    public void CountBall()
    {
        n++;
        if (n == 3)
        {
           gameObject.SetActive(false);
        }
    }

    public void OnTriggerEnter(Collider other) //이렇게 하면 countBall이 몇번 닿았는지 새기도 전에 collider로 감지돼서 startPoint로 나가려나..?
    {
        startPointHole = other.gameObject;

        if (other.CompareTag("core"))
        {
           
        }
    }
}
