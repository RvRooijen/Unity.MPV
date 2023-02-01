using UnityEngine;

public class Main : MonoBehaviour
{
    // In this case the model is assigned in the inspector
    [SerializeField]
    private Actor Actor;

    [SerializeField]
    private GameObject ActorViewPrefab;
    
    [SerializeField]
    private Canvas canvas;
    
    // View is already created in the scene
    [SerializeField]
    private InventoryView inventoryView;
    
    // Start is called before the first frame update
    void Start()
    {
        // Create the view
        ActorView view = Instantiate(ActorViewPrefab, canvas.transform, false).GetComponent<ActorView>();
        // Presenter is created from the view. This is done because the view could also be already created in the scene.
        view.Initialize(Actor);
        
        IInventorySystem inventorySystem = new InventorySystem();
        // Inventory system is passed down to the view for now because the presenter needs it. ( poor man's DI )
        // This will become quite messy if there are many systems. We can use DI later to solve this.
        inventoryView.Initialize(Actor, inventorySystem);
    }
}
