defmodule Fizzbuzz do
  @moduledoc """
  Documentation for Fizzbuzz.
  """

  @doc """
  ## Examples
  """
  def fizz do
    numbers = 1..100
    Enum.to_list(numbers)
    |> Enum.map(fn x -> x * x end)

  end

  def isFizzy(i) when Rem(i, 3) == 0, do: "Fizz" 
 # def isFizzy(i) when Rem(i,3) == 0 and Rem(i, 5) == 0 do: "FizzBuzz" end
 # def isFizzy(i) when Rem(i, 5) == 0 do: "Buzz" end
 # def isFizzy(i) do: i end

end
