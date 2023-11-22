using System;
// Define interfaces for Quality and Cost calculation
public interface IQualityCalculator
{
   double CalculateQuality(double inputParameters);
}
public interface ICostCalculator
{
   double CalculateCost(double externalConditions, double quantity);
}
// Implement classes for specific Quality and Cost calculations
public class QualityCalculatorA : IQualityCalculator
{
   public double CalculateQuality(double inputParameters)
   {
       // Implement quality computation for product type A
       return inputParameters * 2; // Example calculation
   }
}
public class CostCalculatorA : ICostCalculator
{
   public double CalculateCost(double externalConditions, double quantity)
   {
       // Implement cost computation for product type A considering external conditions and quantity
       return externalConditions * quantity * 5; // Example calculation
   }
}
// Product class using the interfaces for quality and cost calculations
public class Product
{
   public string ProductId { get; }
   private readonly IQualityCalculator qualityCalculator;
   private readonly ICostCalculator costCalculator;
   // Constructor taking in interfaces for quality and cost calculations
   public Product(string productId, IQualityCalculator qualityCalc, ICostCalculator costCalc)
   {
       ProductId = productId;
       qualityCalculator = qualityCalc;
       costCalculator = costCalc;
   }
   // Method to compute quality based on input parameters using the injected quality calculator
   public double ComputeQuality(double inputParameters)
   {
       return qualityCalculator.CalculateQuality(inputParameters);
   }
   // Method to compute cost based on external conditions and quantity using the injected cost calculator
   public double ComputeCost(double externalConditions, double quantity)
   {
       return costCalculator.CalculateCost(externalConditions, quantity);
   }
}
class Program
{
   static void Main(string[] args)
   {
       // Create instances of quality and cost calculators for product type A
       IQualityCalculator qualityCalculatorA = new QualityCalculatorA();
       ICostCalculator costCalculatorA = new CostCalculatorA();
       // Create a product instance for product type A using the specific calculators
       Product productTypeA = new Product("A", qualityCalculatorA, costCalculatorA);
       // Example usage
       double inputParams = 10; // Input parameters for quality computation
       double externalConditions = 2; // External conditions affecting cost
       double quantity = 5; // Quantity of product needed
       // Compute quality for product type A
       double qualityResult = productTypeA.ComputeQuality(inputParams);
       Console.WriteLine($"Quality result for product A: {qualityResult}");
       // Compute cost for product type A based on external conditions and quantity
       double costResult = productTypeA.ComputeCost(externalConditions, quantity);
       Console.WriteLine($"Cost result for product A: {costResult}");
   }
}
