using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    //�N���X�̒��A���\�b�h�̊O�ɏ������Ƃɒ���
    //�Ԃ�l�̌^�ɒ���

    ////�����̏o��
    //void PrintArray()
    //{
    //    //�ǉ��A������̐錾�Ə�����
    //    string debugText = "";
    //    for (int i = 0; i < map.Length; i++)
    //    {
    //        //�ύX�A������Ɍ������Ă���
    //        debugText += map[i].ToString() + ",";
    //    }
    //    // ����������������o��
    //    Debug.Log(debugText);
    //}

    ////�v���C���[�̈ʒu�̎擾
    //int GetPlayerIndex()
    //{
    //    //�v�f����map.Length�Ŏ擾
    //    for (int i = 0; i < map.Length; i++)
    //    {
    //        if (map[i] == 1)
    //        {
    //            return i;
    //        }
    //    }
    //    return -1;
    //}

    ////�v���C���[�̈ړ�
    //bool MoveNumber(int number, int moveFrom, int moveTo)
    //{
    //    //�ړ��悪�͈͊O�Ȃ�ړ��s��
    //    if (moveTo < 0 || moveTo >= map.Length)
    //    {
    //        //�����Ȃ��������ɏ����A�������^�[������
    //        return false;
    //    }

    //    //�ړ���ɔ�(2)��������
    //    if (map[moveTo] == 2)
    //    {
    //        //�ǂ̕����ֈړ����邩���Z�o
    //        int velocity = moveTo - moveFrom;
    //        //�v���C���[�̈ړ��悩��A����ɐ�֔����ړ�������E
    //        //���̈ړ������AMoveNumber���\�b�h����MoveNumver���\�b�h��
    //        //�ĂсA�������ċN���Ă���B�ړ��s��bool�ŋL�^
    //        bool succes = MoveNumber(2, moveTo, moveTo + velocity);
    //        //���������ړ����s������B�v���C���[�̈ړ������s
    //        if (!succes)
    //        {
    //            return false;
    //        }
    //    }
    //    //�v���C���[�A���ւ�炸�̈ړ�����
    //    map[moveTo] = number;
    //    map[moveFrom] = 0;
    //    return true;
    //}

    public GameObject playerPrefab;

    //�z��̐錾
    int[,] map;

    // Start is called before the first frame update
    void Start()
    {
        //GameObject instance = Instantiate(
        //    playerPrefab,
        //    new Vector3(0, 0, 0),
        //    Quaternion.identity
        //);

        //�z��̎��̂̍쐬�Ə�����
        map = new int[,] {
            { 0, 0, 0, 0, 0},
            { 0, 0, 1, 0, 0},
            { 0, 0, 0, 0, 0},
        };

        //�����̏o��
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
            //debugText += "\n";//���s
        }
        //Debug.Log(debugText);
    }

    // Update is called once per frame
    void Update()
    {
        ////�E�L�[���������Ƃ�
        //if (Input.GetKeyDown(KeyCode.RightArrow))
        //{
        //    //�v���C���[�̈ʒu�̎擾
        //    int playerIndex = GetPlayerIndex();

        //    //�v���C���[�̈ړ�
        //    MoveNumber(1, playerIndex, playerIndex + 1);

        //    //�����̏o��
        //    PrintArray();
        //}
        ////���L�[���������Ƃ�
        //else if (Input.GetKeyDown(KeyCode.LeftArrow))
        //{
        //    //�v���C���[�̈ʒu�̎擾
        //    int playerIndex = GetPlayerIndex();

        //    //�v���C���[�̈ړ�
        //    MoveNumber(1, playerIndex, playerIndex - 1);

        //    //�����̏o��
        //    PrintArray();
        //}
        ////���̑�
        //else
        //{
        //    //�v���C���[�̈ʒu�̎擾
        //    int playerIndex = GetPlayerIndex();

        //    //�����̏o��
        //   // PrintArray();
        //}
    }
}
