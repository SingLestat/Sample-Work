#include "stdafx.h"
#include "Select.h"
#include "Create.h"
#include "Table.h"
#include "Add.h"
#include "Delete.h"
#include <sstream>
#include <fstream>
#include <iterator>
#include <string>
#include <vector>

using namespace std;


Select::Select()
{
}

void Select::SelectTable(string input, string name)
{
	Table Table;
	Add Add;
	Delete Delete;
	string Choice;

	cout << Table.Name;
	for (int c = 0; c < Table.ColumnHeader.size(); c++)
		cout << Table.ColumnHeader[c][0] << " " << Table.RowData[c][0];

	cout << "Do you want to use in a Join, Add, or Delete from this table?\n";
	getline(cin, Choice);
	if (Choice == "Add")
	{
		Add.AddTo(name, input);
	}
	else if(Choice == "Delete")
	{
		Delete.DeleteThis(name, input);
	}
	else if(Choice == "Join")
	{
		JoinThis(name);
	}
	else
	{
		cout << "Invaild entry.\n";
	};

}

void Select::JoinThis(string name)
{
	Table Table;
	string JoinTable;

	cout << "What table do you want to join to this one?\n";

	getline(cin, JoinTable);

	// I have no idea how to do joins.
}

Select::~Select()
{
}
