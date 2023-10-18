﻿using PersonalContactInformation.Library.Models;
using PersonalContactInformation.Library.Responses;

namespace PersonalContactInformation.Api.Services
{
    public interface IPersonService
    {
        Task<ServiceResponse> AddPersonAsync(Person person);
        Task<ServiceResponse> UpdatePersonAsync(Person person);
        Task<ServiceResponse> DeletePersonAsync(int id);
        Task<Person> GetPersonByIdAsync(int id);
        Task<List<Person>> GetPersonsAsync();
        Task<ServiceResponse> AddPersonJSONAsync(string jsonContent, UpdateStrategy strategy);
        Task<ServiceResponse> AddTelefonnummerAsync(Person person, string newNumber);
        Task<ServiceResponse> DeleteTelefonnummerAsync(Person person, string deleteNumber);
        Task<ServiceResponse> UpdateTelefonnummerAsync(Person person, string oldNumber, string newNumber);
    }
}
