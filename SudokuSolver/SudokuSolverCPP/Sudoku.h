#pragma once
class Sudoku
{
private:
	int fGrid[81];

	bool CheckRow(int, int);
	bool CheckColumn(int, int);
	bool CheckSubGrid(int, int);
public:
	Sudoku(int[81]);
	Sudoku(const Sudoku& aSudoku);
	~Sudoku();

	int GetValue(int);
	void SetValue(int, int);

	bool Solved();
	
	void CanSetValue(int, int);
};

