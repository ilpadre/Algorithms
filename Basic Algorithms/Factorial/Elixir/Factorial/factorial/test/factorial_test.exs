defmodule FactorialTest do
  use ExUnit.Case
  doctest Factorial

  test "factorial of 10 == 3628800 " do
    assert Factorial.fact(10) == 3628800
  end
end
