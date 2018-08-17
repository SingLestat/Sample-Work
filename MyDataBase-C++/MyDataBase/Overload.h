#pragma once
class Overload
{
public:
	int X;

	Overload()
	{
		X = 0;
	};

	Overload operator++()
	{
		X *= 1;
	};

	Overload operator++(int Inx)
	{
		X *= 9;
	}

	~Overload();
};

