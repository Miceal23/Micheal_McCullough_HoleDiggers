using System.Collections;
using UnityEngine;
using UnityEngine.Rendering;

public class Mining : MonoBehaviour
{
    [SerializeField] LayerMask terrainLayer;
    [SerializeField] Camera cam;
    [SerializeField] Transform player;
    [SerializeField] Animator animator;

    [SerializeField] float playerReach;
    [SerializeField] float miningEffectivity;
    [SerializeField] float miningRange;

    private MeshFilter meshFilter;
    private MeshCollider meshCollider;
    //[SerializeField] MeshGenerator meshGenerator;

    void Start()
    {
        meshFilter = GetComponent<MeshFilter>();
        meshCollider = GetComponent<MeshCollider>();
    }

    private bool canMine = true;

    void Update()
    {

        if (Input.GetMouseButton(0) && canMine)
        {
            StartCoroutine(MineCooldown());
            animator.SetBool("IsMining", true);
            //TerraformTerrain(hitInfo.point, -miningEffectivity, miningRange);
        }

        if (Input.GetMouseButtonUp(0))
        {
            animator.SetBool("IsMining", false);
        }

    }

    private float animLenght = 1f;
    private float animSpeed = 2f;

    private IEnumerator MineCooldown()
    {
        canMine = false;
        yield return new WaitForSeconds((animLenght / animSpeed) / 2);

                Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo, playerReach, terrainLayer))
        {
            TerraformTerrain(hitInfo.point, -miningEffectivity, miningRange);
        }

        yield return new WaitForSeconds((animLenght / animSpeed) / 2);
        canMine = true;
    }

    private Mesh mesh;
    private Vector3[] vertices;
    
    private void TerraformTerrain(Vector3 position, float height, float range)
    {
        mesh = meshCollider.sharedMesh;
        mesh = meshFilter.sharedMesh;
        //mesh = meshGenerator;
        vertices = mesh.vertices;
        position -= meshFilter.transform.position;
        position -= meshCollider.transform.position;

        int i = 0;
        foreach(Vector3 vert in vertices)
        {
            if (Vector3.Distance(new Vector3(vert.x, vert.z, vert.y), new Vector3(position.x, position.z, position.y)) <= range)
            {
                vertices[i] = vert + new Vector3(0, height, 0);
            }
            ++i;
        }

        mesh.vertices = vertices;
        meshFilter.mesh = mesh;
        meshCollider.sharedMesh = mesh;

    }

}
