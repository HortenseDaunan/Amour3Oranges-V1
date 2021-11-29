using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class SlideY2 : MonoBehaviour
{
    private bool done;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        done = false;
    }

    IEnumerator action()
    {
        yield return new WaitForSeconds(2);

        SceneManager.LoadScene("Level_2");

    }

    private void Update()
    {
        if (done == false)
        {
            if (gameObject.GetComponent<LanguetteAxeY>().activated == true)
            {
                StartCoroutine(action());
                done = true;
            }
        }

    }
}
