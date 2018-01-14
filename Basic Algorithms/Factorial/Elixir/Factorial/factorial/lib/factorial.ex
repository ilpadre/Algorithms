defmodule Factorial do
  @moduledoc """
  Documentation for Factorial.
  """

  @doc """
  Factorial 

  ## Examples

      iex> Factorial.fact(4)
      24

  """

  def fact(0) do 1 end
  def fact(num) when num > 0 do num * fact(num-1)  end
end

