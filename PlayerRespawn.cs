using UnityEngine;
using UnityEngine.LowLevelPhysics2D;

public class playerrespawn : MonoBehaviour
{
    [SerializeField]
    //MeshRenderer stageRenderer;
    //MeshRenderer playerRenderer;
    //bool checkCollision;
    Transform playerTrans, stageTrans;
    Vector3 startingPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startingPosition = playerTrans.position;

        //playerTrans = GetComponent<Transform>();
        //playerRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (stageTrans.position.y > playerTrans.position.y)
        {
            playerTrans.position = startingPosition;
        }
        //if (playerTrans.position.y < 0)
        //{
        //    playerTrans.position = new Vector3(10, 5, -7);
        //}
    }
}