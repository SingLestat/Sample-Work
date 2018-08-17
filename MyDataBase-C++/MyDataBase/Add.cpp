#include "stdafx.h"
#include "Add.h"
#include "Table.h"
#include <iostream>
#include <string>
#include <algorithm>

using namespace std;

Add::Add()
{
}

void Add::AddTo(string Name, string Input)
{
	Table Table;
	string Column;
	string Value;
	string Choice;
	int C = 0;

	cout << "What column do you want to add to?";

	getline(cin, Column);
	auto it = find(Table.ColumnHeader.begin(), Table.ColumnHeader.end(), Column);

	if(find(Table.ColumnHeader.begin(), Table.ColumnHeader.end(), Column) != Table.ColumnHeader.end())
	{
		auto index = std::distance(Table.ColumnHeader.begin(), it);

		cout << "What value do you want to add?\n";

		getline(cin, Value);


		if (Table.RowData[C][index].empty() == false)
		{
			C++;
		}
		Table.RowData[C][index] = Value;

		cout << "Do you want to add another entry? Yes/No.\n";
		getline(cin, Choice);

		if (Choice == "Yes")
		{
			AddTo(Name, Input);
		}
		else if (Choice == "No")
		{
			return;
		}
		else
		{
			cout << "Invild Entry.";
		}

	}
	else if(find(Table.ColumnHeader.begin(), Table.ColumnHeader.end(), Column) == Table.ColumnHeader.end())
	{
		cout << "No column found.\n";
		AddTo(Name, Input);
	}
}

Add::~Add()
{
}
