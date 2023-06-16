using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngelBattleAnimation : MonoBehaviour
{
    // Reference to the animator component
    private Animator animator;

    // Reference to the spider game object
    public GameObject spider;

    // Distance at which the angel will attack the spider
    public float attackDistance = 2f;

    // Speed at which the angel will move towards the spider
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
        // Calculate the distance between the angel and the spider
        float distance = Vector3.Distance(transform.position, spider.transform.position);

        // If the distance is within the attack range, trigger the attack animation
        if (distance <= attackDistance)
        {
            animator.SetTrigger("Attack");
        }
        // Otherwise, move towards the spider
        else
        {
            animator.SetTrigger("Move");
            transform.position = Vector3.MoveTowards(transform.position, spider.transform.position, movementSpeed * Time.deltaTime);
        }
    }
}
