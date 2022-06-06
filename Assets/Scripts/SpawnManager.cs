using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    List<GameObject> props;
    [SerializeField] ParticleSystem spawnParticle;
    [SerializeField] ParticleSystem bangParticle;
    public int numberOfTaps = 0;
    AudioManager audioManager;

    void Start()
    {
        audioManager = FindObjectOfType<AudioManager>().GetComponent<AudioManager>();
    }
    void Awake()
    {
        props = new List<GameObject>(Resources.LoadAll<GameObject>("Props"));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            if (touch.phase == TouchPhase.Began && !PauseMenu.IsGamePaused)
            {
                numberOfTaps++;
                Instantiate(ReturnPrefab(numberOfTaps), touchPos, Quaternion.identity);
                Instantiate(spawnParticle, touchPos, Quaternion.identity);
                audioManager.Play("Spawn");
            }
        }

        SpawnHigherLevelProp(numberOfTaps);
    }

    GameObject ReturnPrefab(int numberOfTaps)
    {
        if(numberOfTaps < 100)
        {
            return props[0];
        }
        else if(numberOfTaps > 100 && numberOfTaps < 200)
        {
            return props[1];
        }
        else if(numberOfTaps > 200 && numberOfTaps < 300)
        {
            return props[2];
        }
        else if(numberOfTaps > 300 && numberOfTaps < 400)
        {
            return props[3];
        }
        else if(numberOfTaps > 400)
        {
            return props[4];
        }
        return null;
    }

    void DestroyOld(string tag)
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(tag);
        for (int i = 0; i < enemies.Length; i++)
        {
            Destroy(enemies[i]);
        }
    }

    void SpawnNew(int index)
    {
        Instantiate(props[index], new Vector2(Random.Range(-2, 3), 0), Quaternion.identity);
        Instantiate(bangParticle, new Vector2(0, 5), Quaternion.identity);
        audioManager.Play("Bang");
        numberOfTaps++;
    }

    void SpawnHigherLevelProp(int numOfTaps)
    {
        switch(numberOfTaps)
        {
            case 10:
                DestroyOld("Prop1");
                SpawnNew(1);
                break;
            case 20:
                DestroyOld("Prop1");
                SpawnNew(1);
                break;
            case 30:
                DestroyOld("Prop1");
                SpawnNew(1);
                break;
            case 40:
                DestroyOld("Prop1");
                SpawnNew(1);
                break;
            case 50:
                DestroyOld("Prop1");
                SpawnNew(1);
                break;
            case 60:
                DestroyOld("Prop1");
                SpawnNew(1);
                break;
            case 70:
                DestroyOld("Prop1");
                SpawnNew(1);
                break;
            case 80:
                DestroyOld("Prop1");
                SpawnNew(1);
                break;
            case 90:
                DestroyOld("Prop1");
                SpawnNew(1);
                break;
            case 100:
                DestroyOld("Prop1");
                SpawnNew(1);
                DestroyOld("Prop2");
                SpawnNew(2);
                break;
            case 110:
                DestroyOld("Prop2");
                SpawnNew(2);
                break;
            case 120:
                DestroyOld("Prop2");
                SpawnNew(2);
                break;
            case 130:
                DestroyOld("Prop2");
                SpawnNew(2);
                break;
            case 140:
                DestroyOld("Prop2");
                SpawnNew(2);
                break;
            case 150:
                DestroyOld("Prop2");
                SpawnNew(2);
                break;
            case 160:
                DestroyOld("Prop2");
                SpawnNew(2);
                break;
            case 170:
                DestroyOld("Prop2");
                SpawnNew(2);
                break;
            case 180:
                DestroyOld("Prop2");
                SpawnNew(2);
                break;
            case 190:
                DestroyOld("Prop2");
                SpawnNew(2);
                break;
            case 200:
                DestroyOld("Prop2");
                SpawnNew(2);
                DestroyOld("Prop3");
                SpawnNew(3);
                break;
            case 210:
                DestroyOld("Prop3");
                SpawnNew(3);
                break;
            case 220:
                DestroyOld("Prop3");
                SpawnNew(3);
                break;
            case 230:
                DestroyOld("Prop3");
                SpawnNew(3);
                break;
            case 240:
                DestroyOld("Prop3");
                SpawnNew(3);
                break;
            case 250:
                DestroyOld("Prop3");
                SpawnNew(3);
                break;
            case 260:
                DestroyOld("Prop3");
                SpawnNew(3);
                break;
            case 270:
                DestroyOld("Prop3");
                SpawnNew(3);
                break;
            case 280:
                DestroyOld("Prop3");
                SpawnNew(3);
                break;
            case 290:
                DestroyOld("Prop3");
                SpawnNew(3);
                break;
            case 300:
                DestroyOld("Prop3");
                SpawnNew(3);
                DestroyOld("Prop4");
                SpawnNew(4);
                break;
            case 310:
                DestroyOld("Prop4");
                SpawnNew(4);
                break;
            case 320:
                DestroyOld("Prop4");
                SpawnNew(4);
                break;
            case 330:
                DestroyOld("Prop4");
                SpawnNew(4);
                break;
            case 340:
                DestroyOld("Prop4");
                SpawnNew(4);
                break;
            case 350:
                DestroyOld("Prop4");
                SpawnNew(4);
                break;
            case 360:
                DestroyOld("Prop4");
                SpawnNew(4);
                break;
            case 370:
                DestroyOld("Prop4");
                SpawnNew(4);
                break;
            case 380:
                DestroyOld("Prop4");
                SpawnNew(4);
                break;
            case 390:
                DestroyOld("Prop4");
                SpawnNew(4);
                break;
            case 400:
                DestroyOld("Prop4");
                break;
        }
    }

}
