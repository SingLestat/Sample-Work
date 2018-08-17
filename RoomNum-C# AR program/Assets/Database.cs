using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Data.SqlClient;
using System;
using System.Data;

public class Database : MonoBehaviour {
    private  List<string> CRN = new List<string>();
    private List<string> CourseNum = new List<string>();
    private List<string> CourseName = new List<string>();
    private List<string> TeacherEmail = new List<string>();
    private List<string> TeacherName = new List<string>();
    private List<string> StartDate = new List<string>();
    private List<string> EndDate = new List<string>();
    private List<string> StartTime = new List<string>();
    private List<string> EndTime = new List<string>();
    private List<string> Campus = new List<string>();
    private List<string> Room = new List<string>();
    private List<string> TermLength = new List<string>();
    private List<string> ClassDays = new List<string>();

    public  Text InfoText;
    public  Text SecondTest;
    public  Button Button;
    public string RoomName;

    private int count;
    private int i = 0;
    private int Max = 0;

    public  void PrintSql_List()
    {
        string cs = "Integrated Security=false;server=EULER;Database=ARClassScheduler;" +
            "User ID=sa;Password=welcome1n;Connection Timeout=120";

        InfoText.text = "Chase";

        SqlConnection con = new SqlConnection(cs);

        SqlCommand cmd = new SqlCommand();
        
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "SELECT [CRN]      ,[CourseNum]      ,[CourseName]      ,[TeacherEmail]      ,[TeacherName]      ,[StartDate]      ,[EndDate]      ,[StartTime]      ,[EndTime]      ,[Campus]      ,[Room]      ,[TermLength]      ,[ClassDays]  FROM [ARClassScheduler].[dbo].[ClassSchedules]  where Room like '" + RoomName + "';"; ;
        con.Open();

        SqlDataReader sr = cmd.ExecuteReader();

        while(sr.Read())
        {
            CRN.Add(sr[0].ToString());
            CourseNum.Add(sr[1].ToString());
            CourseName.Add(sr[2].ToString());
            TeacherEmail.Add(sr[3].ToString());
            TeacherName.Add(sr[4].ToString());
            StartDate.Add(sr[5].ToString());
            EndDate.Add(sr[6].ToString());
            StartTime.Add(sr[7].ToString());
            EndTime.Add(sr[8].ToString());
            Campus.Add(sr[9].ToString());
            Room.Add(sr[10].ToString());
            TermLength.Add(sr[11].ToString());
            ClassDays.Add(sr[12].ToString());
            Debug.Log(sr[0].ToString());
        }

        Button btn = Button.GetComponent<Button>();

        Max = CRN.Count;

        if (i <= Max)
        {
            btn.onClick.AddListener(OnClickFunction);
        }
        else
        {
            i = 0;
        }
         

        sr.Close();
        con.Close();
    }

    private  void OnClickFunction()
    {
            InfoText.text = "CRN:" + CRN[i] + "\nCourseNum:" + CourseNum[i] + "  Course Name: " + CourseName[i] + "\nTeacher Email:" + TeacherEmail[i] + " Teacher Name: " + TeacherName[i] + "\nStart Date: " + StartDate[i] + "  End Date: " + EndDate[i] + "\nStart Time: " + StartTime[i] + " End Time: " + EndTime[i] + "\nCampus: " + Campus[i] + " Room: " + Room[i] + "\nTerm Length: " + TermLength[i] + " Class Days:" + ClassDays[i];
            i++;
    }
    // Use this for initialization
    void Start () {
        RoomName = this.gameObject.name;
        PrintSql_List();
    }
	
	// Update is called once per frame
	void Update () {
    }
}
