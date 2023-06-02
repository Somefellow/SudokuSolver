# frozen_string_literal: true

# rubocop:disable Lint/UselessAssignment Lint/Void

require './sudoku'

puzzle = [
  5, 3, 0, 0, 7, 0, 0, 0, 0,
  6, 0, 0, 1, 9, 5, 0, 0, 0,
  0, 9, 8, 0, 0, 0, 0, 6, 0,
  8, 0, 0, 0, 6, 0, 0, 0, 3,
  4, 0, 0, 8, 0, 3, 0, 0, 1,
  7, 0, 0, 0, 2, 0, 0, 0, 6,
  0, 6, 0, 0, 0, 0, 2, 8, 0,
  0, 0, 0, 4, 1, 9, 0, 0, 5,
  0, 0, 0, 0, 8, 0, 0, 7, 9
]

puzzle2 = [
  0, 0, 0, 2, 6, 0, 7, 0, 1,
  6, 8, 0, 0, 7, 0, 0, 9, 0,
  1, 9, 0, 0, 0, 4, 5, 0, 0,
  8, 2, 0, 1, 0, 0, 0, 4, 0,
  0, 0, 4, 6, 0, 2, 9, 0, 0,
  0, 5, 0, 0, 0, 3, 0, 2, 8,
  0, 0, 9, 3, 0, 0, 0, 7, 4,
  0, 4, 0, 0, 5, 0, 0, 3, 6,
  7, 0, 3, 0, 1, 8, 0, 0, 0
]

puzzle3 = '003020600900305001001806400008102900700000008006708200002609500800203009005010300'.chars.map(&:to_i)

puts Sudoku.new(puzzle).solutions
puts '-' * 17
puts Sudoku.new(puzzle).solutions
puts '-' * 17
puts Sudoku.new(puzzle).solutions

# rubocop:enable Lint/UselessAssignment Lint/Void
