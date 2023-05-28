#include <iostream>
#include <ctime>

#include "Backtrack.h"

#define PUZZLE "003020600900305001001806400008102900700000008006708200002609500800203009005010300"
#define SOLUTION "483921657967345821251876493548132976729564138136798245372689514814253769695417382"

int main()
{
	std::string EasyPuzzle = PUZZLE;
	int lGrid[81];

	for (int i = 0; i < (SIZE * SIZE); ++i)
		lGrid[i] = EasyPuzzle[i] - '0';

	Sudoku lSudoku(lGrid);
	Backtrack lBacktrack(lSudoku);

	std::clock_t start = std::clock();
	std::string lOutput = lBacktrack.Solve();
	double duration = (std::clock() - start) / (double)CLOCKS_PER_SEC;

	std::cout << lOutput << std::endl;

	if (lOutput == SOLUTION)
		std::cout << "UnitTest Passed" << std::endl;

	std::cout << duration << std::endl;

	return 0;
}