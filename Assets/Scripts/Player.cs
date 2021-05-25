using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour

{
 public GameObject final;
// 道具數量文字
 public Text textCount;
// 系統累計的數量
 public int count;

 private void OnTriggerEnter2D(Collider2D collision)

 {
 //判斷式語法:if(collision.名字/標籤=="指定物")

 if (collision.name == "傳送門")
 {
 print("碰到傳送門");
 final.SetActive(true);
 }

 if (collision.tag=="甲蟲")
 {
 //刪除(碰到的物件)
 Destroy(collision.gameObject);
 count++;
 textCount.text = "甲蟲數量 : " + count;
 }
 }
}
