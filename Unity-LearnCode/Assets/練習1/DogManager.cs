using UnityEngine;

public class DogManager : MonoBehaviour //繼承程式
{
    public Dog DogA = new Dog("公,5");
    public Dog DogB = new Dog("母,3");

    #region 事件
    private void Start()
    {
        DogA.name = "小白";
        DogA.Weight = 30.5f;
        DogA.type = "土狗";
        //DogA.sex = "公";
        DogA.color = "黑";
        //DogA.age = 2;

        DogB.name = "小黑";
        DogB.Weight = 35.5f;
        DogB.type = "貴賓";
        //DogB.sex = "母";
        DogB.color = "白";
        //DogB.age = 4;

        Debug.Log(DogA + DogA.name + "品種:" + DogA.type + "顏色:" + DogA.color);
        Debug.Log(DogB + DogB.name + "品種:" + DogB.type + "顏色:" + DogB.color);

        DogA.Bark();
        DogB.Bark();
        Debug.Log(DogA.name + "的實際年齡為:" + DogA.ConverAge());
        Debug.Log(DogB.name + "的實際年齡為:" + DogB.ConverAge());

        DogA.Eat("寶路");
        DogB.Eat("骨頭",10);

    }
    #endregion

}
