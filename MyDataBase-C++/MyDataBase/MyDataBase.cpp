// MyDataBase.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
#include "Table.h"
#include "Uppercass.h"
 

using namespace std;


string Header = "What Would you like to do?\n"
"You can Create a table using\n"
"Create ----\n"
"Column ----.\n"
"You can Select a table using\n"
"Select ----\n"
"From ----.\n"
"You add Joins tables using\n"
"Join----\n"
"With ----\n"
"You can Delete from a table using\n"
"Delete from ----\n"
"Column ----\n"
"Row ----.\n"
"Then to see if somehting is true add\n"
"Check ---- at the end.\n"
"Load ----\n";

int main()
{
	Table Table;
	Uppercass Up;

	string x;

	cout << Header;
	system("pause");
	system("cls");

	Up.UserInput(x);

	cout << endl << endl;
	system("pause");

    return 0;
}


//add try/catch
//overloaded op.
//work in rowheader

