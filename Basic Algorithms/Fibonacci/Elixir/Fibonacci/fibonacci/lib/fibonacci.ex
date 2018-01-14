defmodule Fibonacci do
  @moduledoc """
  Documentation for Fibonacci.
  """

  @doc """
  Fibonacci

  ## Examples

      iex> Fibonacci.gen1(10)
      55

  """
  def gen1(num) do
    fibonacci(num)
  end

  def gen_up_to(num) do
    fibonacci(num)
    gen_up_to(num-1)
  end

  def fibonacci(0) do 0 end
  def fibonacci(1) do 1 end
  def fibonacci(2) do 1 end
  def fibonacci(num) do
    fibonacci(num-1) + fibonacci(num-2)
  end

end
