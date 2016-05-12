#include "Sudoku.h"

bool Sudoku::CheckRow(int aIndex, int aValue)
{
	int lOffset = aIndex / 9 * 9;

	for (int i = lOffset; i < (9 + lOffset); i++)
	{
		if (fGrid[i] == aValue) return false;
	}

	return true;
}

bool Sudoku::CheckColumn(int aIndex, int aValue)
{
	for (int i = (aIndex % 9); i < 81; i += 9)
	{
		if (fGrid[i] == aValue) return false;
	}

	return true;
}

bool Sudoku::CheckSubGrid(int aIndex, int aValue)
{
	int lXValue = aIndex % 9;
	int lYValue = aIndex / 9;

	int lXStart = lXValue - (lXValue % 3);
	int lYStart = lYValue - (lYValue % 3);

	for (int lX = lXStart; lX < (3 + lXStart); lX++)
	{
		for (int lY = lYStart; lY < (3 + lYStart); lY++)
		{
			if (fGrid[(lY * 9) + lX] == aValue) return false;
		}
	}

	return true;
}

Sudoku::Sudoku(int aGrid[SIZE])
{
	for (int i = 0; i < SIZE; ++i)
	{
		fGrid[i] = aGrid[i];
	}
}

int Sudoku::ValueAt(int aIndex)
{
	return fGrid[aIndex];
}

void Sudoku::SetValue(int aIndex, int aValue)
{
	fGrid[aIndex] = aValue;
}

bool Sudoku::Solved(void)
{
	for (int i = 0; i < SIZE; i++)
	{
		if (fGrid[i] == 0) return false;
	}

	return true;
}

bool Sudoku::CanSetValue(int aIndex, int aValue)
{
	if (!CheckRow(aIndex, aValue)) return false;
	else if (!CheckColumn(aIndex, aValue)) return false;
	else if (!CheckSubGrid(aIndex, aValue)) return false;
	else return true;
}

std::string Sudoku::ToString(void)
{
	std::string result;

	for (int i = 0; i < (SIZE * SIZE); ++i)
	{
		result += std::to_string(fGrid[i]);
	}

	return result;
}
