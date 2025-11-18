using UnityEngine;
using UnityEngine.InputSystem;

/**
 * This component spawns the given laser-prefab whenever the player clicks a given key.
 * It also updates the "scoreText" field of the new laser.
 */
public class LaserShooter : ClickSpawner
{
    [SerializeField]
    [Tooltip("How many points to add to the shooter, if the laser hits its target")]
    int pointsToAdd = 1;

    // קלט של ירייה (מקש רווח)
    [SerializeField] private InputAction shootAction = new InputAction(type: InputActionType.Button);

    // קצב ירי (0.2 שניות ברירת מחדל)
    [SerializeField] private float fireRate = 0.2f;

    private float nextFireTime = 0f;

    private NumberField scoreField;

    private void OnEnable() { shootAction.Enable(); }
    private void OnDisable() { shootAction.Disable(); }

    private void Start()
    {
        scoreField = FindObjectOfType<NumberField>();
        if (!scoreField)
            Debug.LogError($"No child of {gameObject.name} has a NumberField component!");
    }

    private void Update()
    {
        // ירי רציף כל עוד המקש לחוץ
        if (shootAction.IsPressed() && Time.time >= nextFireTime)
        {
            spawnObject();
            nextFireTime = Time.time + fireRate;
        }
    }

    private void AddScore()
    {
        scoreField.AddNumber(pointsToAdd);
    }

    protected override GameObject spawnObject()
    {
        GameObject newObject = base.spawnObject();
        DestroyOnTrigger2D newObjectDestroyer = newObject.GetComponent<DestroyOnTrigger2D>();
        if (newObjectDestroyer)
            newObjectDestroyer.onHit += AddScore;
        return newObject;
    }
}
