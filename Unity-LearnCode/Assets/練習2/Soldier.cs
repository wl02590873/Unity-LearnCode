using UnityEngine;
[System.Serializable]
public class Soldier
{
    public int exp;
    public int lv;

    /// <summary>
    /// 設定經驗值計算方式
    /// </summary>
    /// <returns>傳回計算後經驗值</returns>
    public int GetExp()
    {
        exp = lv * 10;
        return exp;
    }

    /// <summary>
    /// 設定經驗值
    /// </summary>
    /// <param name="getExp">取得的經驗值</param>
    public void SetExp(int getExp)
    {
        exp = getExp;
    }
}