#pragma once

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
	~Sudoku();

	int GetValue(int);
	void SetValue(int, int);

	bool Solved();

	void CanSetValue(int, int);
};

