#include "Sudoku.h"

bool Sudoku::CheckRow(int aIndex, int aValue)
{
	int lOffset = aIndex / SIZE * SIZE;

	for (int i = lOffset; i < (SIZE + lOffset); i++)
	{
		if (fGrid[i] == aValue) return false;
	}

	return true;
}

bool Sudoku::CheckColumn(int aIndex, int aValue)
{
	for (int i = (aIndex % SIZE); i < (SIZE * SIZE); i += SIZE)
	{
		if (fGrid[i] == aValue) return false;
	}

	return true;
}

bool Sudoku::CheckSubGrid(int aIndex, int aValue)
{
	int lXValue = aIndex % SIZE;
	int lYValue = aIndex / SIZE;

	int lXStart = lXValue - (lXValue % (SIZE / SIZE));
	int lYStart = lYValue - (lYValue % (SIZE / SIZE));

	for (int lX = lXStart; lX < ((SIZE / SIZE) + lXStart); lX++)
	{
		for (int lY = lYStart; lY < ((SIZE / SIZE) + lYStart); lY++)
		{
			if (fGrid[(lY * SIZE) + lX] == aValue) return false;
		}
	}

	return true;
}

Sudoku::Sudoku(int aGrid[SIZE * SIZE])
{
	for (int i = 0; i < (SIZE * SIZE); ++i)
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
	for (int i = 0; i < (SIZE * SIZE); i++)
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
	std::string result = "";

	for (int i = 0; i < (SIZE * SIZE); ++i)
	{
		result += std::to_string(fGrid[i]);
	}

	return result;
}
