using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using Random = UnityEngine.Random;

public class ProjectAppearence : MonoBehaviour
{
    public GameObject ImagesHandler;

    private SpriteRenderer[] Images;

    private void Start()
    {
        Images = ImagesHandler.GetComponentsInChildren<SpriteRenderer>();
        foreach (SpriteRenderer image in Images)
        {
            image.gameObject.SetActive(false);
        }
    }

    //Код для активации части картины
    public void OnPartFind()
    {
        int randomImage = Random.Range(0, Images.Length);
        if (Images[randomImage])
        {
            Images[randomImage].gameObject.SetActive(true);
            RemoveAt(ref Images, randomImage);
            CheckWinOrNot();
        }
    }

    void CheckWinOrNot()
    {
        if (Images.Length.Equals(0))
        {
            print("Win");
        }
    }
    
    //Код удаления объекта в массиве
    public static void RemoveAt<T>(ref T[] arr, int index)
    {
        for (int a = index; a < arr.Length - 1; a++)
        {
            // moving elements downwards, to fill the gap at [index]
            arr[a] = arr[a + 1];
        }
        // finally, let's decrement Array's size by one
        Array.Resize(ref arr, arr.Length - 1);
    }
}
