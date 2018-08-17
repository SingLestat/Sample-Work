#include "stdafx.h"
#include "Delete.h"
#include "Add.h"
#include "Table.h"
#include <iostream>
#include <string>
#include <algorithm>
#include <vector>


Delete::Delete()
{
}

void Delete::DeleteThis(string, string)
{
	Table Table;

	string Choice;
	string Column;
	string Row;

	cout << "Do you want to delete a Row or a Column?\n";
	getline(cin, Choice);
	if (Choice == "Column")
	{
		cout << "What Column do you want to delete?\n";
		getline(cin, Column);
		
		auto findit = std::find(Table.ColumnHeader.begin(), Table.ColumnHeader.end(), Column);

		if (findit == Table.ColumnHeader.end())
		{
			cout << "Invald entry.\n";
		}
		else if (findit != Table.ColumnHeader.end())
		{
			auto index = distance(Table.ColumnHeader.begin(), findit);

			Table.ColumnHeader.erase(Table.ColumnHeader.begin() + index);
			Table.RowData.erase(Table.ColumnHeader.begin() + index);
		}
	}
	else if (Choice == "Row")
	{
		cout << "What row do you want to delete?\n";
		getline(cin, Row);

		auto findit = std::find(Table.RowData.begin(), Table.RowData.end(), Row);

		if (findit == Table.RowData.end())
		{
			cout << "Invald entry.\n";
		}
		else if (findit != Table.RowData.end())
		{
			auto index = distance(Table.RowData.begin(), findit);

			Table.RowData[index] = "Null";
		}
	}

}

Delete::~Delete()
{
}
