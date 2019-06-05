using UnityEngine;

[System.Serializable]
public class Dog
{
    #region 欄位
    public string name;
    public float Weight;
    public string type;
    public string color;

    private string sex;
    private int age;
    #endregion

    //建構函式
    public Dog(string sex)
    {
        this.sex=sex;
        this.age = age;
    }

    #region
    /// <summary>
    /// 狗狗叫方法
    /// </summary>
    public void Bark()
    {
        Debug.Log(name + ":汪汪");
    }
    #endregion


    /// <summary>
    /// 轉換狗的年齡
    /// </summary>
    /// <returns></returns>
    public int ConverAge()
    {
        return age * 7;
    }
    public void Eat(string food, string speed = "慢")
    {
        Debug.Log(name + ":" + food + "，速度:" + speed);
    }

    /// <summary>
    /// 狗狗吃東西的方法
    /// </summary>
    /// <param name="food">食物</param>
    /// <param name="count">份量</param>
    public void Eat(string food, int count)
    {
        Debug.Log(name + ":" + food + "，份量:" + count);
    }

}
