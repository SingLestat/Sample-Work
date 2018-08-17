#include "stdafx.h"
#include "Uppercass.h"
#include <iostream>
#include <string>
#include <sstream>
#include <fstream>
#include <iterator>
#include <string>
#include <vector>
#include "MyError.h"

using namespace std;


Uppercass::Uppercass()
{
}

void Uppercass::UserInput(string)
{
	string Input; // Try/Catch for errors maybe?
	string Command;
	string Name;

	Create Create;
	Add Add;
	Select Select;
	Delete Delete;
	Table table;
	MyError Error;

	try
	{
		getline(cin, Input); // Create bob
		int x = 0;
		//for(int x = 0; x < Input.size(); x++)
		while (Input[x] != ' ')
		{
			Command += Input[x];
			x++;
		}
		if (Command != "Create" || Command != "Select" || Command != "Load")
		{
			throw MyError();
		}

		//getline requires a stream data type for the 1st parameter
		//stringstream is a stream that helps with the manipulation of strings
	std:stringstream ss;
		//put string into the stringstream
		ss.str(Input);
		//gets the number of delimiting commas used so you can calculate the number of values
		int numSpace = 0;
		for (int i = 0; i < Input.size(); ++i)
		{
			if (Input[i] == ' ')
				numSpace++;
		}
		//will contain the part of the string that gets parsed out.
		string outputString = " ";
		//gets number of values
		const int NUM_VALUES = numSpace + 1;
		//parses inputString into values
		for (int i = 0; i < NUM_VALUES; ++i)
		{
			//Space is the delimiter
			getline(ss, outputString, ' ');

			Input = outputString;

		}

		cout << Input << endl << Command << endl;
		system("pause");
	}
	catch (MyError& x)
	{
		cout << "Error\n";
	}
		
	if (Command == "Create")
		Create.MakeTable(Command, Input);
	else if (Command == "Select") // add delete to select
		Select.SelectTable(Command, Input);
	else if (Command == "Load") // look into more
		Create.LoadTable(table);
	else 
		cout << "Invald entry." << endl; 
}

Uppercass::~Uppercass()
{
}
