// <copyright file="AttributeParserTest.cs" company="Michael Sawczyn">Copyright © Michael Sawczyn 2018</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sawczyn.EFDesigner.EFModel;

namespace Sawczyn.EFDesigner.EFModel.Tests
{

   /// <summary>This class contains parameterized unit tests for AttributeParser</summary>
   [PexClass(typeof(AttributeParser))]
   [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
   [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
   [TestClass]
   public partial class AttributeParserTest
   {
      /// <summary>Test stub for Parse(String)</summary>
      [PexMethod(MaxBranches = 80000, MaxConstraintSolverTime = 20, Timeout = 2400, MaxRunsWithoutNewTests = 200, MaxConditions = 1000)]
      public ParseResult ParseTest(string txt)
      {
         ParseResult result = AttributeParser.Parse(txt);
         return result;
      }
   }
}
