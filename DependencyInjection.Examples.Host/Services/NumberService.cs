using DependencyInjection.Examples.Host.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DependencyInjection.Examples.Host.Services
{
    public class NumberService : INumberService
    {
        private readonly INumberRepository _numberRepository;

        private readonly Random _random;

        public NumberService(INumberRepository numberRepository)
        {
            _numberRepository = numberRepository;

            _random = new Random();
        }

        public int GetRandomNumber()
        {
            List<int> numbers = _numberRepository.GetAll().ToList();

            int randomIndexNumber = _random.Next(numbers.Count);

            return numbers[randomIndexNumber];
        }
    }
}
