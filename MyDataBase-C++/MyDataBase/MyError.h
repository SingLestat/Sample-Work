#include <exception>

#pragma once
class MyError : exception
{
public:
	MyError();

	virtual const char* what() const throw()
	{
		return "Do better.";
	}

	~MyError();
};

