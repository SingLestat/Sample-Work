#pragma once
#include <vector>
#include <string>
#include <iostream>

using namespace std;

class Table
{
public:
	Table();

	string Name;
	vector<string> ColumnHeader; // 
	vector<vector<string>> RowData; //
};

