#include <iostream>

#include "Sudoku.h"
#include "Backtrack.h"

#define PUZZLE "003020600900305001001806400008102900700000008006708200002609500800203009005010300"
#define SOLUTION "812753649943682175675491283154237896369845721287169534521974368438526917796318452"

int main()
{
	char* EasyPuzzle = PUZZLE;
	int lGrid[81];

	for (int i = 0; i < 81; ++i)
		lGrid[i] = EasyPuzzle[i] - '0';

	Sudoku lSudoku(lGrid);
	Backtrack lBacktrack(lSudoku);

	std::string lOutput = lBacktrack.Solve();
	std::cout << lOutput << std::endl;

	if (lOutput.compare(SOLUTION))
		std::cout << "UnitTest Passed" << std::endl;

	return 0;
}