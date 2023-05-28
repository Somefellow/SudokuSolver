#include "Backtrack.h"

Backtrack::Backtrack(Sudoku aSudoku)
{
	fStack.push(aSudoku);
	fCheckCount = 0;
}

std::string Backtrack::Solve(void)
{
	while (fStack.size() > 0)
	{
		Sudoku lSudoku = fStack.top();
		fStack.pop();

		if (lSudoku.Solved())
		{
			return lSudoku.ToString();
		}

		int lBlankIndex;

		for (lBlankIndex = 0; lBlankIndex < (SIZE * SIZE); lBlankIndex++)
		{
			if (lSudoku.ValueAt(lBlankIndex) == 0)
			{
				break;
			}
		}

		for (int i = SIZE; i > 0; i--)
		{
			if (lSudoku.CanSetValue(lBlankIndex, i))
			{
				Sudoku lMoveSudoku(lSudoku);
				lMoveSudoku.SetValue(lBlankIndex, i);
				fStack.push(lMoveSudoku);
			}
		}

		fCheckCount++;
	}

	return "No solution found...";
}

int Backtrack::GetCheckCount(void)
{
	return fCheckCount;
}
