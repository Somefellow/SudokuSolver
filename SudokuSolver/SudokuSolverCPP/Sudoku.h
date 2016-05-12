#pragma once

#include <string>

#define SIZE 9

class Sudoku
{
private:
	int fGrid[SIZE];

	bool CheckRow(int, int);
	bool CheckColumn(int, int);
	bool CheckSubGrid(int, int);
public:
	Sudoku(int[SIZE]);

	int ValueAt(int);
	void SetValue(int, int);

	bool Solved(void);
	bool CanSetValue(int, int);
	std::string ToString(void);
};

