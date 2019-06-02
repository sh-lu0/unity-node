using UnityEngine;
using System.Collections;

public class JSONTest : MonoBehaviour
{

    void Start()
    {
        MyObject myObject = new MyObject();
        myObject.position = new Vector3(1, 2, 3);

        /* オブジェクトからJSONへの変換 */
        string json = JsonUtility.ToJson(myObject);
        Debug.Log(json);

        /* JSONからオブジェクトへの変換（その１） */
        MyObject obj1 = JsonUtility.FromJson<MyObject>(json);
        Debug.Log(
            obj1.position
        );

        /* JSONからオブジェクトへの変換（その２） */
        MyObject obj2 = new MyObject(); //初期化が必要
        JsonUtility.FromJsonOverwrite(json, obj2); //obj2が初期化されてないとエラーになる
        Debug.Log(
            obj2.position
        );
    }

}