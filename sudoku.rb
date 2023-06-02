# frozen_string_literal: true

class Sudoku
  SORTED_DATA = (1..9).to_a.freeze

  attr_reader :grid

  def initialize(grid)
    @grid = grid
  end

  def tile(x, y)
    grid[point_to_index(x, y)]
  end

  def first_zero
    grid.find_index(0)
  end

  def get_row(row_num)
    start_index = row_num * 9
    grid[start_index, 9]
  end

  def get_col(col_num)
    grid.each_slice(9).map { |row| row[col_num] }
  end

  def get_section(x, y)
    start_x = x * 3
    start_y = y * 3
    section = []

    (start_x..start_x + 2).each do |i|
      (start_y..start_y + 2).each do |j|
        index = i * 9 + j
        section << grid[index]
      end
    end

    section
  end

  def solutions(solution_list = [])
    return unless valid?

    if full?
      solution_list.append(self)
    else
      (1..9).each do |i|
        new_sudoku = Sudoku.new(grid.clone)
        new_sudoku.grid[new_sudoku.first_zero] = i
        new_sudoku.solutions(solution_list)
      end
    end

    solution_list
  end

  def valid?
    9.times do |i|
      return false unless no_duplicates_other_than_zero(get_row(i))
      return false unless no_duplicates_other_than_zero(get_col(i))
    end

    3.times do |x|
      3.times do |y|
        return false unless no_duplicates_other_than_zero(get_section(x, y))
      end
    end

    true
  end

  def full?
    grid.none?(&:zero?)
  end

  def to_s
    grid.each_slice(9).to_a.map { |row| row.join(' ') }.join("\n")
  end

  def no_duplicates_other_than_zero(list)
    list.reject(&:zero?).count == list.reject(&:zero?).uniq.count
  end

  private

  def point_to_index(x, y)
    x + (y * 9)
  end

  def index_to_point(_index)
    [x % 9, y / 9]
  end
end
