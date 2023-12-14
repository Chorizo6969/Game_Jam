using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ClientMovement : MonoBehaviour
{
    public GameObject bar;
    public GameObject exit;
    public int speed;
    public bool canMove;
    public void ClientLeaves(GameObject client)
    {
        //client.transform.Translate();
    }
    public void Update()
    {
        if (canMove)
        {
            Vector3 direction = bar.transform.position - transform.position;
            Vector3 velocite = speed * Time.deltaTime * direction.normalized;
            transform.Translate(velocite, Space.World);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        canMove = false;
        BarManager.Instance.canRequest = true;
    }
}
