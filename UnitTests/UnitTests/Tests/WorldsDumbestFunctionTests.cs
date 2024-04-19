using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Tests
{   
    // Naming convention - ClassName_MethodName_ExpectedResult
    public static class WorldsDumbestFunctionTests
    {
        // Ususually testing function doesn't need to return anything
        public static void WorldsDumbestFunction_ReturnsPikachuIfZero_ReturnString()
        {
            try
            {
                // Arrange - Go get your variables, whatever you need, e.g. classes, functions, etc.
                int num = 0;
                WorldsDumbestFunction worldsDumbest = new WorldsDumbestFunction();

                // Act - Execute this function
                string result = worldsDumbest.ReturnsPikachuIfZero(num);

                // Assert - whatever is returned is what you want.
                if (result == "Pikachu")
                {
                    Console.WriteLine("PASSED: WorldsDumbestFunction_ReturnsPikachuIfZero_ReturnString");
                }
                else
                {
                    Console.WriteLine("FAILED: WorldsDumbestFunction_ReturnsPikachuIfZero_ReturnString");
                }

            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
