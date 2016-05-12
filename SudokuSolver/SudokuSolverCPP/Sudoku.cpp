#include "Sudoku.h"

Sudoku::Sudoku(int aGrid[SIZE])
{
	for (int i = 0; i < SIZE; ++i)
	{
		fGrid[i] = aGrid[i];
	}
}

Sudoku::~Sudoku()
{
}
