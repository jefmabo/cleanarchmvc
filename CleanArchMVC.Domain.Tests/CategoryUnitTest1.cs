using Xunit;
using CleanArchMVC.Domain.Entities;
using CleanArchMVC.Domain.Validation;
using FluentAssertions;
using System;

namespace CleanArchMVC.Domain.Tests
{
    public class CategoryUnitTest1
    {
        [Fact(DisplayName ="Create category with valid state")]
        public void CreateCategory_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Category(1, "Category name");
            action.Should()
                .NotThrow<DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create category with invalid Id")]
        public void CreateCategory_WithNegativeIdValue_ResultObjectValidState()
        {
            Action action = () => new Category(-1, "Category name");
            action.Should()
                .Throw<DomainExceptionValidation>()
                .WithMessage("Invalid Id value.");
        }

        [Fact(DisplayName = "Create category with invalid name")]
        public void CreateCategory_WithShortNameValue_ResultObjectValidState()
        {
            Action action = () => new Category(1, "Ca");
            action.Should()
                .Throw<DomainExceptionValidation>()
                .WithMessage("Invalid name, too short, minimum 3 characters.");
        }

        [Fact(DisplayName = "Create category with missing value name")]
        public void CreateCategory_WithMissingValueName_ResultObjectValidState()
        {
            Action action = () => new Category(1, "");
            action.Should()
                .Throw<DomainExceptionValidation>()
                .WithMessage("Invalid name. Name is required.");
        }
    }
}
