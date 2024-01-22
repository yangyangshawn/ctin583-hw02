// TODO: Problem 4: Write in the comments what each line of code is doing
using System.Collections;//This line includes the System.Collections namespace, providing access to interfaces and classes that define various collections of objects, such as lists, queues, bit arrays, hash tables, and dictionaries.
using System.Collections.Generic;//This line includes the System.Collections.Generic namespace, which contains interfaces and classes that define generic collections. These allow users to create strongly typed collections that provide better type safety and performance than non-generic strongly typed collections.
using UnityEngine;//This includes the UnityEngine namespace, which is the main namespace for the Unity engine. It provides classes and functions for building and running games in Unity.

public class PlayerController : MonoBehaviour//his defines a public class named EnemyCollision that inherits from MonoBehaviour. MonoBehaviour is the base class from which every Unity script derives. This class will be attached to a GameObject in the Unity scene.
{
    // TODO: Problem 1: Define a private variable for your player or character's name and print it out to Unity's console
    // Start is called before the first frame update
    void Start()
    {
        string playerName;
        playerName = "yy";
        Debug.Log("My player's name is" + playerName);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [Header("General Setup Settings")]
    [SerializeField] private InputAction movement;
    [Tooltip("How fast player moves up and down based upon player input")][SerializeField] float controlSpeed = 30f;
    [Tooltip("How far player moves horizontally")][SerializeField] float xRange = 10f;
    [Tooltip("How far player moves vertically")][SerializeField] float yRange = 10f;

    private void OnEnable()
    {
        movement.Enable();
    }

    private void OnDisable()
    {
        movement.Disable();
    }
}