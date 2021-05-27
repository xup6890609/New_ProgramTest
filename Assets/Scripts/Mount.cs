using KID;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//坐騎程式腳本
public class Mount : MonoBehaviour
{
    public GameObject player;
    public GameObject mount;
    public Animator PlayerAnimator;
    public Transform parent;

    ///如果按下xx按鈕，就...
    ///Fire1 = 滑鼠左鍵
    ///Fire2 = 滑鼠右鍵
    private void Update()
    {
        if (Input.GetButton("Fire1"))
            mountup();
        if (Input.GetButton("Fire2"))
            dismount();
    }

    public void SetParent(GameObject player)
    {
        mount.transform.parent = player.transform;
    }

    public void mountup()
    {
        PlayerAnimator.SetBool("滑行", true);
        StartCoroutine(Mounting());
        player.GetComponent<CharacterMovement2D>().enabled = true;
        mount.GetComponent<Knight>().enabled = true;
    }

    public void dismount()
    {
        transform.parent = null;

        mount.SetActive(false);
        player.GetComponent<CharacterMovement2D>().enabled = true;
        mount.GetComponent<Knight>().enabled = false;
    }

    IEnumerator Mounting() 
    {
        yield return new WaitForSeconds(1.5f);
        mount.SetActive(true);
        mount.GetComponent<Knight>().enabled = true;
        player.GetComponent<CharacterMovement2D>().enabled = true;
        mount.transform.position = player.transform.position;
        mount.transform.rotation = player.transform.rotation;
        SetParent(mount);
        PlayerAnimator.SetBool("滑行", true);
    }
}
