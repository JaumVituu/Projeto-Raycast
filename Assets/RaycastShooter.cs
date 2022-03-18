using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastShooter : MonoBehaviour
{
    Ray ray;
    RaycastHit hitData;
    Vector3 point;
    public Camera camera;
    bool isLeftButtonDown;
    public GameObject Prefab;
    public bool spawner;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawner = Prefab.GetComponent<PrefabTraining>().spawn;

        
            if (Input.GetMouseButtonDown(0)){
                ray = new Ray(transform.position, transform.forward);

                 RaycastHit hitData;

        
                 if (Physics.Raycast(ray, out hitData)){
                    Vector3 hitPosition = hitData.point;
                    float hitDistance = hitData.distance;
                    GameObject hitObject = hitData.transform.gameObject;
                    Destroy(hitObject);
                    spawner = true;

                    Debug.DrawRay(ray.origin, hitPosition * hitDistance, Color.green);
                    
            }
        }
        void OnDrawGizmosSelected(){

            Gizmos.color = Color.red;

            Gizmos.DrawRay(ray);
        }
    }
}
