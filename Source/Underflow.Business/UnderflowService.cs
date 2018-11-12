using System;
using Microsoft.EntityFrameworkCore;
using Underflow.data;
using Underflow.Entity;

namespace Underflow.Business
{
    public class UnderflowService
    {
        private readonly UnderflowContext _context;

        public UnderflowService(UnderflowContext context)
        {

            _context = context;
        }

        public Questions CreateQuestion(Questions question)
        {
            _context.Questions.Add(question);
            _context.SaveChanges();
            return question;
        }

        





    }
}
