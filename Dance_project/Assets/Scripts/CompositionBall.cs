using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompositionBall : MonoBehaviour
{
    public GameObject gearBlack;
    public GameObject gearRed;
    public GameObject gearBlue;
    public GameObject gearAqua;
    GameObject cube;
    public Transform spawnPoint;
    [SerializeField] int numberOfCubes;
    //public List<GameObject> gears;
    [SerializeField] float sphereRadius = 30f;
    float r = 50;
    float x;
    float y;
    float z;
    //[SerializeField] private GameObject _cubePrefab;   
   
    //[ContextMenu("Gen")]
    int number = 4;

    [SerializeField] private Vector3 _rotation;
    [SerializeField] private float _speed;
    void Start()
    {
        //Generate a sphere from cubes
        //var points = GetDistributedPointsOnSphere(numberOfCubes, sphereRadius);
        //foreach (var point in points)
        //{
        //    var cube = Instantiate(_cubePrefab, point, Quaternion.identity);
        //}

        
       // int numberOfCubes = 200;
        //Generate a sphere from cubes
        for (int i = 0; i < numberOfCubes; i++)
        {
            Vector3 pos = Random.onUnitSphere * sphereRadius;
            number = Random.Range(0, 4);
            switch (number)
            {
                case 0:
                    cube = gearBlack;
                    break;
                case 1:
                    cube = gearRed;
                    break;
                case 2:
                    cube = gearBlue;
                    break;
                case 3:
                    cube = gearAqua;
                    break;
            }
            Instantiate(cube, pos, Quaternion.identity);
        }


        //x = 0;
        //y = 0;
        //z = 0;
        //for (int i = -250; i < 250; i++)
        //{
        //    if (Mathf.Abs(y) <= r) ;
        //    {
        //        float rr = Mathf.Sqrt(Mathf.Pow(r, 2) - Mathf.Pow(y, 2));
        //        for (int j = 0; j < 360; j += 6)
        //        {
        //            float angleX = Mathf.PI * 2 * j / 360;                    
        //            x = rr * Mathf.Cos(angleX);                    
        //            z = rr * Mathf.Sin(angleX);
        //            Debug.Log(x);
        //            int number = Random.Range(0, 4);
        //            switch (number)
        //            {
        //                case 0:
        //                    gears.Add(Instantiate(gearBlack, new Vector3(spawnPoint.position.x + x, y, spawnPoint.position.z + z), Quaternion.identity));
        //                    break;
        //                case 1:
        //                    gears.Add(Instantiate(gearRed, new Vector3(spawnPoint.position.x + x, y, spawnPoint.position.z + z), Quaternion.identity));
        //                    break;
        //                case 2:
        //                    gears.Add(Instantiate(gearBlue, new Vector3(spawnPoint.position.x + x, y, spawnPoint.position.z + z), Quaternion.identity));
        //                    break;
        //                case 3:
        //                    gears.Add(Instantiate(gearAqua, new Vector3(spawnPoint.position.x + x, y, spawnPoint.position.z + z), Quaternion.identity));
        //                    break;
        //            }
        //        }
        //    }
        //    y = i * 2f;
        //}
        //for (int i = 0; i < numberOfCubes; i++)
        //{
        //    GameObject gearClone = Instantiate(gearBlack);
        //    {
        //        gearBlack.transform.position += new Vector3(i * 1.5f, 0, 0);
        //        gearBlack.transform.position = new Vector3(Mathf.Cos(i * 1.5f), Mathf.Sin(i * 1.5f), 0.2f) * 50;
        //    }
        //    GameObject gearClone1 = Instantiate(gearRed);
        //    {
        //        gearRed.transform.position += new Vector3(i * 1.5f, 0, 0);
        //        gearRed.transform.position = new Vector3(Mathf.Cos(i * 1.5f), Mathf.Sin(i * 1.5f), 0.3f) * 50;
        //    }
        //    GameObject gearClone2 = Instantiate(gearBlue);
        //    {
        //        gearBlue.transform.position += new Vector3(i * 1.5f, 0, 0);
        //        gearBlue.transform.position = new Vector3(Mathf.Cos(i * 1.5f), Mathf.Sin(i * 1.5f), 0) * 50;
        //    }
        //    GameObject gearClone3 = Instantiate(gearAqua);
        //    {
        //        gearAqua.transform.position += new Vector3(i * 1.5f, 0, 0);
        //        gearAqua.transform.position = new Vector3(Mathf.Cos(i * 1.5f), Mathf.Sin(i * 1.5f), 0.1f) * 50;
        //    }
        //}
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(_rotation * _speed * Time.deltaTime);
    }
    //private Vector3[] GetDistributedPointsOnSphere(int count, float radius)
    //{
    //    Vector3[] points = new Vector3[count];
    //    float offset = 2f / count;
    //    float increment = Mathf.PI * (3f - Mathf.Sqrt(5f));
    //    for (int i = 0; i < count; i++)
    //    {
    //        float y = ((i * offset) - 1) + (offset / 2);
    //        float r = Mathf.Sqrt(1 - Mathf.Pow(y, 2));
    //        float phi = ((i + 1) % count) * increment;
    //        float x = Mathf.Cos(phi) * r;
    //        float z = Mathf.Sin(phi) * r;
    //        points[i] = new Vector3(x, y, z) * radius;
    //    }
    //    return points;
    //}
}
