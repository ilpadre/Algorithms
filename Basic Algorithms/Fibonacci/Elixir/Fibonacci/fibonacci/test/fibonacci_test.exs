defmodule FibonacciTest do
  use ExUnit.Case
  doctest Fibonacci

  test "fib numbers up to" do
    assert Fibonacci.gen1(20) == 6765
  end
end
