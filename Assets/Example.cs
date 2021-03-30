using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    private GameObject[] cubes = new GameObject[10];
    GameObject plane = new GameObject();
    GameObject sphere = new GameObject();
    GameObject capsule = new GameObject();
    GameObject cylinder = new GameObject();



    private Renderer planeRenderer, sphereRenderer, capsuleRenderer, cylinderRenderer;


    public float timer, interval = 2f;

    void Start()
    {





        Vector3 pos = new Vector3(-5, 0, 0);


        for (int i = 0; i < 10; i++)
        {

            cubes[i] = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cubes[i].transform.position = pos;
            cubes[i].name = "Cube_" + i;
            pos.x++;
        }

        plane = GameObject.CreatePrimitive(PrimitiveType.Plane);
        sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        capsule = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        //get renderer  
        planeRenderer = plane.GetComponent<Renderer>();
        sphereRenderer = sphere.GetComponent<Renderer>();
        capsuleRenderer = capsule.GetComponent<Renderer>();
        cylinderRenderer = cylinder.GetComponent<Renderer>();



    }

    void Update()
    {


        //Get the Renderer component from the new cube




        //Call SetColor using the shader property name "_Color" and setting the color to red









        timer += Time.deltaTime;
        if (timer >= interval)
        {
            for (int i = 0; i < 10; i++)
            {
                int randomValue = Random.Range(0, 2);
                if (randomValue == 0)
                {
                    Renderer cubesRenderer = cubes[i].GetComponent<Renderer>();
                    cubesRenderer.material.color = new Color(Random.Range(55, 255), Random.Range(15, 254), Random.Range(26, 99));

                    cubes[i].SetActive(false);
                }
                else cubes[i].SetActive(true);

                Vector3 pos = new Vector3(0, 0, 0);
                Vector3 pos3 = new Vector3(Random.Range(1, 3), Random.Range(0, 2), 0);
                Vector3 pos1 = new Vector3(Random.Range(1, 4), Random.Range(0, 3), 0);


                plane.transform.position = pos3;
                sphere.transform.position = pos1;
                capsule.transform.position = pos;
                cylinder.transform.position = pos3;

                planeRenderer.material.SetColor("_Color", Color.red);
                sphereRenderer.material.SetColor("_Color", Color.cyan);
                capsuleRenderer.material.SetColor("_Color", Color.green);
                cylinderRenderer.material.SetColor("_Color", Color.yellow);

                // planeRenderer.material.color = new Color(Random.Range(13, 254), Random.Range(69, 241), Random.Range(150, 254));
                // sphereRenderer.material.color = new Color(Random.Range(56, 254), Random.Range(56, 254), Random.Range(33, 254));
                // capsuleRenderer.material.color = new Color(Random.Range(56, 254), Random.Range(1, 254), Random.Range(56, 254));
                // cylinderRenderer.material.color = new Color(Random.Range(59, 254), Random.Range(200, 254), Random.Range( 254,255));
            }
            timer = 0;
        }
    }
}
