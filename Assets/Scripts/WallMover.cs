using UnityEngine;

public class WallMover : MonoBehaviour
{
    public GameObject[] walls;
    public GameObject redButton;
    public GameObject greenButton;
    public float moveDistance = 1.0f;

    [SerializeField]
    private int totalStages = 3;
    private int currentStage = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == redButton)
            MoveWallsCloser();

        else if (collision.gameObject == greenButton)
            MoveWallsAway();
    }

    public void MoveWallsCloser()
    {
        if (currentStage < totalStages)
        {
            foreach (GameObject wall in walls)
            {
                Vector3 directionToOrigin = (Vector3.zero - wall.transform.position).normalized;
                directionToOrigin.y = 0; // Ignore y-component
                wall.transform.position += directionToOrigin * moveDistance;
            }
            currentStage++;
        }
    }

    public void MoveWallsAway()
    {
        if (currentStage > 0)
        {
            foreach (GameObject wall in walls)
            {
                Vector3 directionToOrigin = (Vector3.zero - wall.transform.position).normalized;
                directionToOrigin.y = 0; // Ignore y-component
                wall.transform.position -= directionToOrigin * moveDistance;
            }
            currentStage--;
        }
    }
}