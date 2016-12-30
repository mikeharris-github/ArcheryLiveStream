using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowManager : MonoBehaviour {

    public static ArrowManager Instance;

    public GameObject arrowPrefab;
    private GameObject currentArrow;
    public SteamVR_TrackedObject trackedObj; //controller
    public GameObject stringAttachPoint;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    void OnDestroy()
    {
        if (Instance == this)
            Instance = null;
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        AttachArrow(); //this utilizes the public void below to make sure we always have an arrow attached to our scene.
	}

    private void AttachArrow() //we only want the system to be able to control this and access this.
    {
        if (currentArrow == null) //if there's no current arrow
        {
            currentArrow = Instantiate(arrowPrefab); //create an arrow
            currentArrow.transform.parent = trackedObj.transform; //attach arrow to the controller
            currentArrow.transform.localPosition = new Vector3(0f, 0f, .342f); //local position is what you see in the inspector. In this case, it'll always be .342f away. .342s was determined during the tutorial. Global is where it is in the world space.
           // the line above could be ignored and the .342 could be added to the arrow's transform manually. I keep it here for the sake of following the video.
       

        }
    }

    public void AttachBowToArrow() // this is public because we want anyone (the user) to be able to do this.
    {

    }
}
