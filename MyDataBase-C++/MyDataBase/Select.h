#pragma once
#include <string>
#include <iostream>

using namespace std;

class Select
{
public:
	Select();

	void SelectTable(string Name, string Input);

	void JoinThis(string name);

	int x = 0;

	~Select();
};



