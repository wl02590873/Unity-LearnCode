using UnityEngine;

public class DogManager:MonoBehaviour
{
    public Dog DogA = new Dog();
    public Dog DogB = new Dog();

    #region 事件
    private void Start()
    {
        DogA.name = "小白";
        DogA.Weight = 30.5f;
        DogA.type = "土狗";
        DogA.sex = "公";
        DogA.color = "黑";
        DogA.age = 2;

        DogB.name = "小黑";
        DogB.Weight = 35.5f;
        DogB.type = "貴賓";
        DogB.sex = "母";
        DogB.color = "白";
        DogB.age = 4;

        Debug.Log(DogA + DogA.name + "品種:" + DogA.type + "顏色:" + DogA.color);
        Debug.Log(DogB + DogB.name + "品種:" + DogB.type + "顏色:" + DogB.color);
    }
    #endregion

}
