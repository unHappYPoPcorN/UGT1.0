using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

public class SQL : MonoBehaviour
{
    MySqlConnection sqlconn = null;
    private string sqlDBip = "180.231.119.223";
    private string sqlDBname = "UGTdb";
    private string sqlDBid = "UGT";
    private string sqlDBpw = "UGT3333";



    // Start is called before the first frame update
    void Start()
    {
        sqlConnect();


        //sqlcmdall("INSERT INTO UGTdb.rank(score) VALUES('23')");
        DataTable ta = selsql("SELECT * FROM UGTdb.rank");


        for (int i = 0; i < ta.Rows.Count; i++)
        {
            for (int j = 0; j < ta.Columns.Count; j++)
            {
                String str = Convert.ToString(ta.Rows[i][j]);
                Debug.Log(str);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void sqlConnect()
    {
        //DB정보 입력
        string sqlDatabase = "Server=" + sqlDBip + ";Database=" + sqlDBname + ";UserId=" + sqlDBid + ";Password=" + sqlDBpw + ";";

        //접속 확인하기
        try
        {
            sqlconn = new MySqlConnection(sqlDatabase);
            sqlconn.Open();
            Debug.Log("SQL의 접속 상태 : " + sqlconn.State); //접속이 되면 OPEN이라고 나타남
        }
        catch (Exception msg)
        {
            Debug.Log(msg); //기타다른오류가 나타나면 오류에 대한 내용이 나타남
        }
    }

    private void sqldisConnect()
    {
        sqlconn.Close();
        Debug.Log("SQL의 접속 상태 : " + sqlconn.State); //접속이 끊기면 Close가 나타남 
    }

    public void sqlcmdall(string allcmd) //함수를 불러올때 명령어에 대한 String을 인자로 받아옴
    {
        sqlConnect(); //접속

        MySqlCommand dbcmd = new MySqlCommand(allcmd, sqlconn); //명령어를 커맨드에 입력
        dbcmd.ExecuteNonQuery(); //명령어를 SQL에 보냄

        sqldisConnect(); //접속해제
    }

    public DataTable selsql(string sqlcmd)  //리턴 형식을 DataTable로 선언함
    {
        DataTable dt = new DataTable(); //데이터 테이블을 선언함

        sqlConnect();
        MySqlDataAdapter adapter = new MySqlDataAdapter(sqlcmd, sqlconn);
        adapter.Fill(dt); //데이터 테이블에  채워넣기를함
        sqldisConnect();

        return dt; //데이터 테이블을 리턴함
    }

}
