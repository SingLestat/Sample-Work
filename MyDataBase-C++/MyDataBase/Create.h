#pragma once
#include <iostream>
#include <string>
#include "Table.h"

using namespace std;

class Create
{
public:
	Create();
	~Create();

	void MakeTable(string Name, string Input);
	bool SaveTable(Table table);
	void LoadTable(Table table);
};

