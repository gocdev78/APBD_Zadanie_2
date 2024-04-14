using System;

namespace LegacyApp
{
    public class UserService
    {
        private readonly IClientRepository _clientRepository;
        private readonly IUserCreditService _userCreditService;

        public UserService(IClientRepository clientRepository, IUserCreditService userCreditService)
        {
            _clientRepository = clientRepository;
            _userCreditService = userCreditService;
        }

        public bool AddUser(string firstName, string lastName, string email, DateTime dateOfBirth, int clientId)
        {
            if (!ValidateInput(firstName, lastName, email, dateOfBirth))
            {
                return false;
            }

            var client = _clientRepository.GetById(clientId);
            var user = CreateUser(firstName, lastName, email, dateOfBirth, client);

            if (!CheckCreditLimit(user))
            {
                return false;
            }

            UserDataAccess.AddUser(user);
            return true;
        }

        private bool ValidateInput(string firstName, string lastName, string email, DateTime dateOfBirth)
        {
            
        }

        private User CreateUser(string firstName, string lastName, string email, DateTime dateOfBirth, Client client)
        {
           
        }

        private bool CheckCreditLimit(User user)
        {
            
        }
    }
}
