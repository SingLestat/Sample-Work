#include "stdafx.h"
#include "Create.h"
#include "Table.h"
#include <sstream>
#include <fstream>
#include <iterator>
#include <string>
#include <vector>
#include "Add.h"
#include "Overload.h"

using namespace std;


Create::Create()
{
}

void Create::MakeTable(string input, string name)
{
	Table Table;
	Add Add;
	Overload OverLoad;

	string Input = input;
	string Name = name;
	string Values;
	string Value;
	char AddY_N;
	int X = 0;

	cout << Input << "\n" << "Values:\n";
	getline(cin, Values);

	Table.Name = Name;

	//getline requires a stream data type for the 1st parameter
	//stringstream is a stream that helps with the manipulation of strings
	stringstream ss;
	//put string into the stringstream
	ss.str(Values);
	//gets the number of delimiting commas used so you can calculate the number of values
	int numCommas = 0;
	for (int i = 0; i < Values.size(); ++i)
	{
		if (Values[i] == ',')
		{
			numCommas++;
		}
	}
	//will contain the part of the string that gets parsed out.
	string outputString = "";
	//gets number of values
	const int NUM_VALUES = numCommas + 1;
	//parses inputString into values
	for (int i = 0; i < NUM_VALUES; ++i)
	{
		//comma is the delimiter
		getline(ss, outputString, ',');
		//put into vector
		Table.ColumnHeader.push_back(outputString);
	}

	cout << ++(numCommas)+"This is my overloaded thingly\n";

	cout << "Add data? Y/N" << endl;
	cin >> AddY_N;
	switch (AddY_N)
	{
	case 'Y':
		Add.AddTo(Name, Input);
		break;
	case 'N':
		cout << "Save? Y/N" << endl;
		cin >> AddY_N;
		switch (AddY_N)
		{
		case 'Y':
			Create::SaveTable(Table);
			break;
		case 'N':
			return;
		default:
			cout << "Invaild Entry";
			break;
		}
		return;
	default:
		cout << "Invaild Entry";
		break;
	}
}

bool Create::SaveTable(Table table) // come back to.
{
	string FileName = table.Name + ".jdb";

	FILE *File = fopen(FileName.c_str(), "wb");
	fwrite((char *)&table, sizeof(Table), 1, File); // treats as char array
	fclose(File);

	return false;
}

void Create::LoadTable(Table table) // come back to.
{
	string FileName = table.Name + ".jdb";

	Table Table;

	ifstream in;
	FILE *File = fopen(FileName.c_str, "rb");
	fread((char *)&Table, sizeof(Table), 1, File);
	fclose(File);
}

Create::~Create()
{
}
