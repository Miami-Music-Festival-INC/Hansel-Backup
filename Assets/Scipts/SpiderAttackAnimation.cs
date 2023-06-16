using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderAttackAnimation : MonoBehaviour
{
    // Reference to the animator component
    private Animator animator;

    // Reference to the angel game object
    public GameObject angel;

    // Distance at which the spider will attack the angel
    public float attackDistance = 2f;

    // Speed at which the spider will move towards the angel
    public float movementSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        // Get the animator component
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate the distance between the spider and the angel
        float distance = Vector3.Distance(transform.position, angel.transform.position);

        // If the distance is within the attack range, trigger the attack animation
        if (distance <= attackDistance)
        {
            animator.SetTrigger("Attack");
        }
        // Otherwise, move towards the angel
        else
        {
            animator.SetTrigger("Move");
            transform.position = Vector3.MoveTowards(transform.position, angel.transform.position, movementSpeed * Time.deltaTime);
        }
    }
}
