using System;
using System.Collections.Generic;
using System.Text;

namespace Sofymatic.Repository.Core
{
    public interface IUnitOfWork
    {
        //put here your repository interface

       int Complete();

    }
}
