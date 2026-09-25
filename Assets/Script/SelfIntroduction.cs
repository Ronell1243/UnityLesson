using UnityEngine;

public class SelfIntroduction : MonoBehaviour
{
    void Start()
    {
        string name = "김미소";
        int age = 10+11;
        float height = 160.1f;
        bool istrue = true;

        Debug.Log("안녕하세요. 제 이름은" + name + "이고, 나이는" + age + "세 이며, 키는" + height + "입니다.");
        Debug.Log(istrue);
    }

}
