using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    //クラスの中、メソッドの外に書くことに注意
    //返り値の型に注意

    ////文字の出力
    //void PrintArray()
    //{
    //    //追加、文字列の宣言と初期化
    //    string debugText = "";
    //    for (int i = 0; i < map.Length; i++)
    //    {
    //        //変更、文字列に結合していく
    //        debugText += map[i].ToString() + ",";
    //    }
    //    // 結合した文字列を出力
    //    Debug.Log(debugText);
    //}

    ////プレイヤーの位置の取得
    //int GetPlayerIndex()
    //{
    //    //要素数はmap.Lengthで取得
    //    for (int i = 0; i < map.Length; i++)
    //    {
    //        if (map[i] == 1)
    //        {
    //            return i;
    //        }
    //    }
    //    return -1;
    //}

    ////プレイヤーの移動
    //bool MoveNumber(int number, int moveFrom, int moveTo)
    //{
    //    //移動先が範囲外なら移動不可
    //    if (moveTo < 0 || moveTo >= map.Length)
    //    {
    //        //動けない条件を先に書き、早期リターンする
    //        return false;
    //    }

    //    //移動先に箱(2)がいたら
    //    if (map[moveTo] == 2)
    //    {
    //        //どの方向へ移動するかを算出
    //        int velocity = moveTo - moveFrom;
    //        //プレイヤーの移動先から、さらに先へ箱を移動させる・
    //        //箱の移動処理、MoveNumberメソッド内でMoveNumverメソッドを
    //        //呼び、処理が再起している。移動可不可をboolで記録
    //        bool succes = MoveNumber(2, moveTo, moveTo + velocity);
    //        //もし箱が移動失敗したら。プレイヤーの移動も失敗
    //        if (!succes)
    //        {
    //            return false;
    //        }
    //    }
    //    //プレイヤー、箱関わらずの移動処理
    //    map[moveTo] = number;
    //    map[moveFrom] = 0;
    //    return true;
    //}

    public GameObject playerPrefab;

    //配列の宣言
    int[,] map;

    // Start is called before the first frame update
    void Start()
    {
        //GameObject instance = Instantiate(
        //    playerPrefab,
        //    new Vector3(0, 0, 0),
        //    Quaternion.identity
        //);

        //配列の実体の作成と初期化
        map = new int[,] {
            { 0, 0, 0, 0, 0},
            { 0, 0, 1, 0, 0},
            { 0, 0, 0, 0, 0},
        };

        //文字の出力
        //string debugText = "";
        for (int y = 0; y < map.GetLength(0); y++)
        {
            for (int x = 0; x < map.GetLength(1); x++)
            {
                if (map[y, x] == 1)
                {
                    GameObject instance = Instantiate(
                        playerPrefab,
                        new Vector3(x, y, 0),
                        Quaternion.identity
                        );
                }
                //debugText += map[y, x].ToString() + ",";
            }
            //debugText += "\n";//改行
        }
        //Debug.Log(debugText);
    }

    // Update is called once per frame
    void Update()
    {
        ////右キーを押したとき
        //if (Input.GetKeyDown(KeyCode.RightArrow))
        //{
        //    //プレイヤーの位置の取得
        //    int playerIndex = GetPlayerIndex();

        //    //プレイヤーの移動
        //    MoveNumber(1, playerIndex, playerIndex + 1);

        //    //文字の出力
        //    PrintArray();
        //}
        ////左キーを押したとき
        //else if (Input.GetKeyDown(KeyCode.LeftArrow))
        //{
        //    //プレイヤーの位置の取得
        //    int playerIndex = GetPlayerIndex();

        //    //プレイヤーの移動
        //    MoveNumber(1, playerIndex, playerIndex - 1);

        //    //文字の出力
        //    PrintArray();
        //}
        ////その他
        //else
        //{
        //    //プレイヤーの位置の取得
        //    int playerIndex = GetPlayerIndex();

        //    //文字の出力
        //   // PrintArray();
        //}
    }
}
