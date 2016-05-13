#pragma once

#include <stack>
#include "Sudoku.h"

class Backtrack
{
private:
	std::stack<Sudoku> fStack;
	int fCheckCount;
public:
	Backtrack(Sudoku);
	std::string Solve(void);
	int GetCheckCount(void);
};

