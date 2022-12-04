using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnList : MonoBehaviour
{
    public Transform[] SpawnPoints;
    public List<GameObject> SpawnPrefab = new List<GameObject> { };
    private int random;
    private int tokenRnd;
    public int tokenCount;
    private Vector3 SpawnPosition;
    public bool[] spawnChecker;

    public List<Transform> SpawnLists = new List<Transform> { };

    private void Start()
    {
        tokenCount = 0;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {


            tokenSpawn();


        }

    }


    public void tokenSpawn()
    {
        
        random = Random.Range(0, 9);
        tokenRnd = Random.Range(0, 3);
        Debug.Log("i am spawning: " + random + " and token " + tokenRnd);
        if (SpawnLists.Count > 0)
        {

            switch (random)
            {
                case 0:
                    if (spawnChecker[random] == true)
                    {
                        Vector3 SpawnPosition = SpawnLists[random].transform.position;
                        Instantiate(SpawnPrefab[tokenRnd], SpawnPosition, Quaternion.identity);
                        //Instantiate(SpawnPrefab[random], SpawnPosition, Quaternion.identity);
                        SpawnLists.RemoveAt(random);
                        //tokenCounterPlus();
                        spawnChecker[random] = false;
                    }
                    else
                        tokenSpawn();
                    break;

                case 1:
                    if (spawnChecker[random] == true)
                    {
                        Vector3 SpawnPosition = SpawnLists[random].transform.position;
                        Instantiate(SpawnPrefab[tokenRnd], SpawnPosition, Quaternion.identity);
                        //Instantiate(SpawnPrefab[random], SpawnPosition, Quaternion.identity);
                        SpawnLists.RemoveAt(random);
                        //tokenCounterPlus();
                        spawnChecker[random] = false;
                    }
                    else
                        tokenSpawn();
                    break;
                case 2:
                    if (spawnChecker[random] == true)
                    {
                        Vector3 SpawnPosition = SpawnLists[random].transform.position;
                        Instantiate(SpawnPrefab[tokenRnd], SpawnPosition, Quaternion.identity);
                        //Instantiate(SpawnPrefab[random], SpawnPosition, Quaternion.identity);
                        SpawnLists.RemoveAt(random);
                        //tokenCounterPlus();
                        spawnChecker[random] = false;
                    }
                    else
                        tokenSpawn();
                    break;
                case 3:
                    if (spawnChecker[random] == true)
                    {
                        Vector3 SpawnPosition = SpawnLists[random].transform.position;
                        Instantiate(SpawnPrefab[tokenRnd], SpawnPosition, Quaternion.identity);
                        //Instantiate(SpawnPrefab[random], SpawnPosition, Quaternion.identity);
                        SpawnLists.RemoveAt(random);
                        //tokenCounterPlus();
                        spawnChecker[random] = false;
                    }
                    else
                        tokenSpawn();
                    break;
                case 4:
                    if (spawnChecker[random] == true)
                    {
                        Vector3 SpawnPosition = SpawnLists[random].transform.position;
                        Instantiate(SpawnPrefab[tokenRnd], SpawnPosition, Quaternion.identity);
                        //Instantiate(SpawnPrefab[random], SpawnPosition, Quaternion.identity);
                        SpawnLists.RemoveAt(random);
                        //tokenCounterPlus();
                        spawnChecker[random] = false;
                    }
                    else
                        tokenSpawn();
                    break;
                case 5:
                    if (spawnChecker[random] == true)
                    {
                        Vector3 SpawnPosition = SpawnLists[random].transform.position;
                        Instantiate(SpawnPrefab[tokenRnd], SpawnPosition, Quaternion.identity);
                        //Instantiate(SpawnPrefab[random], SpawnPosition, Quaternion.identity);
                        SpawnLists.RemoveAt(random);
                        //tokenCounterPlus();
                        spawnChecker[random] = false;
                    }
                    else
                        tokenSpawn();
                    break;
                case 6:
                    if (spawnChecker[random] == true)
                    {
                        Vector3 SpawnPosition = SpawnLists[random].transform.position;
                        Instantiate(SpawnPrefab[tokenRnd], SpawnPosition, Quaternion.identity);
                        //Instantiate(SpawnPrefab[random], SpawnPosition, Quaternion.identity);
                        SpawnLists.RemoveAt(random);
                        //tokenCounterPlus();
                        spawnChecker[random] = false;
                    }
                    else
                        tokenSpawn();
                    break;
                case 7:
                    if (spawnChecker[random] == true)
                    {
                        Vector3 SpawnPosition = SpawnLists[random].transform.position;
                        Instantiate(SpawnPrefab[tokenRnd], SpawnPosition, Quaternion.identity);
                        //Instantiate(SpawnPrefab[random], SpawnPosition, Quaternion.identity);
                        SpawnLists.RemoveAt(random);
                        //tokenCounterPlus();
                        spawnChecker[random] = false;
                    }
                    else
                        tokenSpawn();
                    break;
                case 8:
                    if (spawnChecker[random] == true)
                    {
                        Vector3 SpawnPosition = SpawnLists[random].transform.position;
                        Instantiate(SpawnPrefab[tokenRnd], SpawnPosition, Quaternion.identity);
                        //Instantiate(SpawnPrefab[random], SpawnPosition, Quaternion.identity);
                        SpawnLists.RemoveAt(random);
                        //tokenCounterPlus();
                        spawnChecker[random] = false;
                    }
                    else
                        tokenSpawn();
                    break;

                default: break;
            }

        }
        else
        {
            Debug.Log("Not spawning everything is full");
            for (int i = 0; i < 9; i++)
            {
                SpawnLists.Add(SpawnPoints[i]);
            }

        }

    }


    public void TestSpawn()
    {
        random = Random.Range(0, 9);
        tokenRnd = Random.Range(0, 3);
        Debug.Log("i am spawning: " + random + " and token " + tokenRnd);
        if (SpawnLists.Count > 0)
        {
            Vector3 SpawnPosition = SpawnLists[random].transform.position;
            Instantiate(SpawnPrefab[tokenRnd], SpawnPosition, Quaternion.identity);
            SpawnLists.RemoveAt(random);
        }
        else
        {
            

            
        }
    }

    void tokenCounterPlus()
    {
        tokenCount++;

    }

    public void tokenCounterMinus()
    {
        tokenCount--;
    }
}
